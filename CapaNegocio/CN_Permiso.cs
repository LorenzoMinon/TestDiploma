using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private string connectionString = Conexion.cadena;

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

        public List<GrupoPermiso> ListarGruposPermisosConEstado(int idUsuario)
        {
            List<GrupoPermiso> grupos = new List<GrupoPermiso>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT gp.IdGrupoPermiso, gp.NombreGrupoPermiso AS Nombre, 
                   CASE WHEN ugp.IdGrupoPermiso IS NOT NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS Asignado
            FROM GruposPermisos gp
            LEFT JOIN UsuariosGruposPermisos ugp ON gp.IdGrupoPermiso = ugp.IdGrupoPermiso AND ugp.IdUsuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        grupos.Add(new GrupoPermiso
                        {
                            IdGrupoPermiso = Convert.ToInt32(reader["IdGrupoPermiso"]),
                            Nombre = reader["Nombre"].ToString(),
                            Asignado = Convert.ToBoolean(reader["Asignado"])
                        });
                    }
                }
            }

            return grupos;
        }


        // Método para obtener un grupo de permiso por su nombre
        public GrupoPermiso ObtenerGrupoPermisoPorNombre(string nombre)
        {
            GrupoPermiso grupoPermiso = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IdGrupoPermiso, NombreGrupoPermiso AS Nombre FROM GruposPermisos WHERE NombreGrupoPermiso = @Nombre";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    grupoPermiso = new GrupoPermiso
                    {
                        IdGrupoPermiso = Convert.ToInt32(reader["IdGrupoPermiso"]),
                        Nombre = reader["Nombre"].ToString()
                    };
                }
            }

            return grupoPermiso;
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
                string query = "IF NOT EXISTS (SELECT 1 FROM UsuariosGruposPermisos WHERE IdUsuario = @IdUsuario AND IdGrupoPermiso = @IdGrupoPermiso) " +
                               "INSERT INTO UsuariosGruposPermisos (IdUsuario, IdGrupoPermiso) VALUES (@IdUsuario, @IdGrupoPermiso)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void RevocarGrupoPermisoDeUsuario(int idUsuario, int idGrupoPermiso)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM UsuariosGruposPermisos WHERE IdUsuario = @IdUsuario AND IdGrupoPermiso = @IdGrupoPermiso";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // GESTION DE GRUPOS DE PERMISOS

        // Método para agregar un grupo de permisos



        // Método para editar un grupo de permisos


        // ULTIMOS UPDATES:
        public List<Permiso> ListarPermisos()
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

        public List<GrupoPermiso> ListarGruposPermisos()
        {
            List<GrupoPermiso> grupos = new List<GrupoPermiso>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IdGrupoPermiso, NombreGrupoPermiso FROM GruposPermisos";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        grupos.Add(new GrupoPermiso
                        {
                            IdGrupoPermiso = (int)reader["IdGrupoPermiso"],
                            Nombre = (string)reader["NombreGrupoPermiso"]
                        });
                    }
                }
            }
            return grupos;
        }

        public int AgregarGrupoPermiso(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO GruposPermisos (NombreGrupoPermiso) OUTPUT INSERTED.IdGrupoPermiso VALUES (@Nombre)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public void EditarGrupoPermiso(int idGrupoPermiso, string nuevoNombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE GruposPermisos SET NombreGrupoPermiso = @NuevoNombre WHERE IdGrupoPermiso = @IdGrupoPermiso";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                cmd.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarGrupoPermiso(int idGrupoPermiso)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM GruposPermisos WHERE IdGrupoPermiso = @IdGrupoPermiso";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public GrupoPermiso ObtenerGrupoPermisoPorId(int idGrupoPermiso)
        {
            GrupoPermiso grupoPermiso = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IdGrupoPermiso, NombreGrupoPermiso AS Nombre FROM GruposPermisos WHERE IdGrupoPermiso = @IdGrupoPermiso";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        grupoPermiso = new GrupoPermiso
                        {
                            IdGrupoPermiso = (int)reader["IdGrupoPermiso"],
                            Nombre = (string)reader["Nombre"]
                        };
                    }
                }
            }
            return grupoPermiso;
        }

        public List<Permiso> ListarPermisosConEstadoParaGrupo(int idGrupoPermiso)
        {
            List<Permiso> permisos = new List<Permiso>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT p.IdPermiso, p.Nombre, 
                       CASE WHEN gp.IdPermiso IS NOT NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS Asignado
                FROM Permisos p
                LEFT JOIN GruposPermisosDetalles gp ON p.IdPermiso = gp.IdPermiso AND gp.IdGrupoPermiso = @IdGrupoPermiso";
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
                            Nombre = (string)reader["Nombre"],
                            Asignado = (bool)reader["Asignado"]
                        });
                    }
                }
            }
            return permisos;
        }

        public void AsignarPermisoAGrupo(int idGrupoPermiso, int idPermiso)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO GruposPermisosDetalles (IdGrupoPermiso, IdPermiso) VALUES (@IdGrupoPermiso, @IdPermiso)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                cmd.Parameters.AddWithValue("@IdPermiso", idPermiso);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void RevocarPermisoDeGrupo(int idGrupoPermiso, int idPermiso)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM GruposPermisosDetalles WHERE IdGrupoPermiso = @IdGrupoPermiso AND IdPermiso = @IdPermiso";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                cmd.Parameters.AddWithValue("@IdPermiso", idPermiso);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
