using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private string connectionString = Conexion.cadena;

        public List<Permiso> ListarTodos()
        {
            List<Permiso> permisos = new List<Permiso>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IdPermiso, Nombre FROM Permisos";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        permisos.Add(new Permiso
                        {
                            IdPermiso = (int)reader["IdPermiso"],
                            Nombre = (string)reader["Nombre"]
                        });
                    }
                }
            }
            return permisos;
        }
        public List<Permiso> ListarPermisosConEstado(int idUsuario)
        {
            List<Permiso> permisos = new List<Permiso>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT p.IdPermiso, p.Nombre, 
               CASE WHEN up.IdPermiso IS NOT NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS Asignado
        FROM Permisos p
        LEFT JOIN UsuariosPermisos up ON p.IdPermiso = up.IdPermiso AND up.IdUsuario = @IdUsuario";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        permisos.Add(new Permiso
                        {
                            IdPermiso = (int)reader["IdPermiso"],
                            Nombre = (string)reader["Nombre"],
                            Asignado = (bool)reader["Asignado"]
                        });
                    }
                }
            }
            return permisos;
        }

        public Permiso ObtenerPermisoPorNombre(string nombre)
        {
            Permiso permiso = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IdPermiso, Nombre FROM Permisos WHERE Nombre = @Nombre";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        permiso = new Permiso
                        {
                            IdPermiso = (int)reader["IdPermiso"],
                            Nombre = (string)reader["Nombre"]
                        };
                    }
                }
            }
            return permiso;
        }


        public void AsignarPermisoAUsuario(int idUsuario, int idPermiso)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "IF NOT EXISTS (SELECT 1 FROM UsuariosPermisos WHERE IdUsuario = @IdUsuario AND IdPermiso = @IdPermiso) " +
                               "INSERT INTO UsuariosPermisos (IdUsuario, IdPermiso) VALUES (@IdUsuario, @IdPermiso)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@IdPermiso", idPermiso);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void RevocarPermisoDeUsuario(int idUsuario, int idPermiso)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM UsuariosPermisos WHERE IdUsuario = @IdUsuario AND IdPermiso = @IdPermiso";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@IdPermiso", idPermiso);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Permiso> ObtenerPermisosPorDocumento(string Documento)
        {
            List<Permiso> permisos = new List<Permiso>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT p.IdPermiso, p.Nombre 
                         FROM Permisos p 
                         JOIN UsuariosPermisos up ON p.IdPermiso = up.IdPermiso
                         JOIN Usuarios u ON u.IdUsuario = up.IdUsuario
                         WHERE u.Documento = @Documento";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Documento", Documento);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        permisos.Add(new Permiso
                        {
                            IdPermiso = (int)reader["IdPermiso"],
                            Nombre = (string)reader["Nombre"]
                        });
                    }
                }
            }
            return permisos;
        }


        public void AsignarGrupoPermisoAUsuario(int idUsuario, int idGrupoPermiso)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UsuariosGruposPermisos (IdUsuario, IdGrupoPermiso) VALUES (@IdUsuario, @IdGrupoPermiso)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Permiso> ObtenerPermisosPorGrupoID(int idGrupoPermiso)
        {
            List<Permiso> permisos = new List<Permiso>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT p.IdPermiso, p.Nombre 
                             FROM Permisos p 
                             JOIN GruposPermisosPermisos gpp ON p.IdPermiso = gpp.IdPermiso
                             WHERE gpp.IdGrupoPermiso = @IdGrupoPermiso";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        permisos.Add(new Permiso
                        {
                            IdPermiso = (int)reader["IdPermiso"],
                            Nombre = (string)reader["Nombre"]
                        });
                    }
                }
            }
            return permisos;
        }
        // Métodos para gestionar grupos de permisos y asignaciones
    }
}
