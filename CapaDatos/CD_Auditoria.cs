using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Auditoria
    {
        public void InsertarAuditoria(Auditoria auditoria)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                SqlCommand command = new SqlCommand("sp_InsertarAuditoria", conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Tabla", auditoria.Tabla);
                command.Parameters.AddWithValue("@Operacion", auditoria.Operacion);
                command.Parameters.AddWithValue("@UsuarioID", auditoria.UsuarioID);
                command.Parameters.AddWithValue("@FechaOperacion", auditoria.FechaOperacion);
                command.Parameters.AddWithValue("@ValorAnterior", (object)auditoria.ValorAnterior ?? DBNull.Value);
                command.Parameters.AddWithValue("@ValorNuevo", (object)auditoria.ValorNuevo ?? DBNull.Value);

                conexion.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Auditoria> ObtenerAuditorias()
        {
            List<Auditoria> auditorias = new List<Auditoria>();

            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                SqlCommand command = new SqlCommand("sp_ObtenerAuditorias", conexion);
                command.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Auditoria auditoria = new Auditoria
                        {
                            AuditoriaID = (int)reader["AuditoriaID"],
                            Tabla = reader["Tabla"].ToString(),
                            Operacion = reader["Operacion"].ToString(),
                            UsuarioID = (int)reader["UsuarioID"],
                            FechaOperacion = (DateTime)reader["FechaOperacion"],
                            ValorAnterior = reader["ValorAnterior"].ToString(),
                            ValorNuevo = reader["ValorNuevo"].ToString()
                        };
                        auditorias.Add(auditoria);
                    }
                }
            }

            return auditorias;
        }

    }
}
