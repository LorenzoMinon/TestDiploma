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

        public List<Permiso> ObtenerPermisosPorDocumento(int Documento)
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
        public void AsignarPermisoAUsuario(int idUsuario, int idPermiso)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UsuariosPermisos (IdUsuario, IdPermiso) VALUES (@IdUsuario, @IdPermiso)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@IdPermiso", idPermiso);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
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
