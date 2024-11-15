﻿using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Permiso
    {
        private string connectionString = Conexion.Instancia.Cadena;

        public List<PermisoSimple> ListarPermisosConEstado(int idUsuario)
        {
            List<PermisoSimple> permisos = new List<PermisoSimple>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT p.IdPermiso, p.Nombre, 
                       CASE WHEN up.IdPermiso IS NOT NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS Asignado
                FROM Permisos p
                LEFT JOIN UsuariosPermisos up ON p.IdPermiso = up.IdPermiso AND up.IdUsuario = @IdUsuario";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    permisos.Add(new PermisoSimple(reader.GetInt32(0), reader.GetString(1))
                    {
                        Asignado = reader.GetBoolean(2)
                    });
                }
            }

            return permisos;
        }

        public List<GrupoPermiso> ListarGruposPermisosConEstado(int idUsuario)
        {
            List<GrupoPermiso> grupos = new List<GrupoPermiso>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT gp.IdGrupoPermiso, gp.NombreGrupoPermiso AS Nombre, 
                       CASE WHEN ugp.IdGrupoPermiso IS NOT NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS Asignado
                FROM GruposPermisos gp
                LEFT JOIN UsuariosGruposPermisos ugp ON gp.IdGrupoPermiso = ugp.IdGrupoPermiso AND ugp.IdUsuario = @IdUsuario";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    grupos.Add(new GrupoPermiso(reader.GetInt32(0), reader.GetString(1))
                    {
                        Asignado = reader.GetBoolean(2)
                    });
                }
            }

            return grupos;
        }

        public PermisoSimple ObtenerPermisoPorNombre(string nombre)
        {
            PermisoSimple permiso = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdPermiso, Nombre FROM Permisos WHERE Nombre = @Nombre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    permiso = new PermisoSimple(reader.GetInt32(0), reader.GetString(1));
                }
            }

            return permiso;
        }

        public GrupoPermiso ObtenerGrupoPermisoPorNombre(string nombre)
        {
            GrupoPermiso grupo = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdGrupoPermiso, NombreGrupoPermiso AS Nombre FROM GruposPermisos WHERE NombreGrupoPermiso = @Nombre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    grupo = new GrupoPermiso(reader.GetInt32(0), reader.GetString(1));
                }
            }

            return grupo;
        }

        public void AsignarPermisoAUsuario(int idUsuario, int idPermiso)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "IF NOT EXISTS (SELECT 1 FROM UsuariosPermisos WHERE IdUsuario = @IdUsuario AND IdPermiso = @IdPermiso) " +
                               "INSERT INTO UsuariosPermisos (IdUsuario, IdPermiso) VALUES (@IdUsuario, @IdPermiso)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                command.Parameters.AddWithValue("@IdPermiso", idPermiso);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RevocarPermisoDeUsuario(int idUsuario, int idPermiso)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM UsuariosPermisos WHERE IdUsuario = @IdUsuario AND IdPermiso = @IdPermiso";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                command.Parameters.AddWithValue("@IdPermiso", idPermiso);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void AsignarGrupoPermisoAUsuario(int idUsuario, int idGrupoPermiso)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "IF NOT EXISTS (SELECT 1 FROM UsuariosGruposPermisos WHERE IdUsuario = @IdUsuario AND IdGrupoPermiso = @IdGrupoPermiso) " +
                               "INSERT INTO UsuariosGruposPermisos (IdUsuario, IdGrupoPermiso) VALUES (@IdUsuario, @IdGrupoPermiso)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                command.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RevocarGrupoPermisoDeUsuario(int idUsuario, int idGrupoPermiso)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM UsuariosGruposPermisos WHERE IdUsuario = @IdUsuario AND IdGrupoPermiso = @IdGrupoPermiso";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                command.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public int AgregarGrupoPermiso(string nombre)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO GruposPermisos (NombreGrupoPermiso) OUTPUT INSERTED.IdGrupoPermiso VALUES (@Nombre)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public void EditarGrupoPermiso(int idGrupoPermiso, string nuevoNombre)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE GruposPermisos SET NombreGrupoPermiso = @NuevoNombre WHERE IdGrupoPermiso = @IdGrupoPermiso";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                command.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EliminarGrupoPermiso(int idGrupoPermiso)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Instancia.Cadena))
            {
                con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Eliminar las referencias en GruposPermisosDetalles
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM GruposPermisosDetalles WHERE IdGrupoPermiso = @IdGrupoPermiso", con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                            cmd.ExecuteNonQuery();
                        }

                        // Eliminar el grupo de permisos
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM GruposPermisos WHERE IdGrupoPermiso = @IdGrupoPermiso", con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public GrupoPermiso ObtenerGrupoPermisoPorId(int idGrupoPermiso)
        {
            GrupoPermiso grupoPermiso = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdGrupoPermiso, NombreGrupoPermiso AS Nombre FROM GruposPermisos WHERE IdGrupoPermiso = @IdGrupoPermiso";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    grupoPermiso = new GrupoPermiso(reader.GetInt32(0), reader.GetString(1));
                }
            }

            return grupoPermiso;
        }

        public void AsignarPermisoAGrupo(int idGrupoPermiso, int idPermiso)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Primero verifica si el permiso ya está asignado al grupo
                string checkQuery = "SELECT COUNT(*) FROM GruposPermisosDetalles WHERE IdGrupoPermiso = @IdGrupoPermiso AND IdPermiso = @IdPermiso";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                checkCommand.Parameters.AddWithValue("@IdPermiso", idPermiso);

                connection.Open();
                int count = (int)checkCommand.ExecuteScalar();
                connection.Close();

                // Si el permiso no está asignado, procede a insertarlo
                if (count == 0)
                {
                    string query = "INSERT INTO GruposPermisosDetalles (IdGrupoPermiso, IdPermiso) VALUES (@IdGrupoPermiso, @IdPermiso)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                    command.Parameters.AddWithValue("@IdPermiso", idPermiso);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void RevocarPermisoDeGrupo(int idGrupoPermiso, int idPermiso)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM GruposPermisosDetalles WHERE IdGrupoPermiso = @IdGrupoPermiso AND IdPermiso = @IdPermiso";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                command.Parameters.AddWithValue("@IdPermiso", idPermiso);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Métodos para el patrón Composite

        public List<PermisoSimple> ListarPermisos()
        {
            List<PermisoSimple> permisos = new List<PermisoSimple>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdPermiso, Nombre FROM Permisos";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    permisos.Add(new PermisoSimple(reader.GetInt32(0), reader.GetString(1)));
                }
            }

            return permisos;
        }

        public List<GrupoPermiso> ListarGruposPermisos()
        {
            List<GrupoPermiso> grupos = new List<GrupoPermiso>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdGrupoPermiso, NombreGrupoPermiso FROM GruposPermisos";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    grupos.Add(new GrupoPermiso(reader.GetInt32(0), reader.GetString(1)));
                }
            }

            return grupos;
        }

        public List<Component> ObtenerTodosLosPermisos()
        {
            List<Component> permisos = new List<Component>();

            var permisosSimples = ListarPermisos();
            permisos.AddRange(permisosSimples);

            var gruposPermisos = ListarGruposPermisos();
            foreach (var grupo in gruposPermisos)
            {
                var permisosDelGrupo = ListarPermisosConEstadoParaGrupo(grupo.Id);
                foreach (var permiso in permisosDelGrupo)
                {
                    grupo.Add(permiso);
                }
                permisos.Add(grupo);
            }

            return permisos;
        }

        public List<PermisoSimple> ListarPermisosConEstadoParaGrupo(int idGrupoPermiso)
        {
            List<PermisoSimple> permisos = new List<PermisoSimple>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT p.IdPermiso, p.Nombre,
               CASE WHEN gp.IdGrupoPermiso IS NOT NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS Asignado
        FROM Permisos p
        LEFT JOIN GruposPermisosDetalles gp ON p.IdPermiso = gp.IdPermiso AND gp.IdGrupoPermiso = @IdGrupoPermiso";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    permisos.Add(new PermisoSimple(reader.GetInt32(0), reader.GetString(1))
                    {
                        Asignado = reader.GetBoolean(2)
                    });
                }
            }

            return permisos;
        }

        public void RevocarTodosPermisosDeGrupo(int idGrupoPermiso)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM GruposPermisosDetalles WHERE IdGrupoPermiso = @IdGrupoPermiso";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
