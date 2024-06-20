// CapaDatos/CD_Cuenta.cs
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Cuenta
    {
        public bool Registrar(Cuenta cuenta, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarCuenta", conexion);
                    cmd.Parameters.AddWithValue("Nombre", cuenta.Nombre);
                    cmd.Parameters.AddWithValue("Tipo", cuenta.Tipo);
                    cmd.Parameters.AddWithValue("Codigo", cuenta.Codigo);
                    cmd.Parameters.AddWithValue("Padre", (object)cuenta.Padre ?? DBNull.Value);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return respuesta;
        }

        public List<Cuenta> Listar()
        {
            List<Cuenta> lista = new List<Cuenta>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_ListarCuentas", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cuenta()
                            {
                                IdCuenta = Convert.ToInt32(dr["IdCuenta"]),
                                Nombre = dr["Nombre"].ToString(),
                                Tipo = dr["Tipo"].ToString(),
                                Codigo = dr["Codigo"].ToString(),
                                Padre = dr["Padre"] != DBNull.Value ? (int?)Convert.ToInt32(dr["Padre"]) : null
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Cuenta>();
                }
            }
            return lista;
        }
    }
}
