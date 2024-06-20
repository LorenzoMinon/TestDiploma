// CapaDatos/CD_Transaccion.cs
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Transaccion
    {
        public bool Registrar(Transaccion transaccion, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarTransaccion", conexion);
                    cmd.Parameters.AddWithValue("Fecha", transaccion.Fecha);
                    cmd.Parameters.AddWithValue("Monto", transaccion.Monto);
                    cmd.Parameters.AddWithValue("CuentaDebe", transaccion.CuentaDebe);
                    cmd.Parameters.AddWithValue("CuentaHaber", transaccion.CuentaHaber);
                    cmd.Parameters.AddWithValue("Descripcion", transaccion.Descripcion);
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

        public List<Transaccion> Listar()
        {
            List<Transaccion> lista = new List<Transaccion>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_ListarTransacciones", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Transaccion()
                            {
                                IdTransaccion = Convert.ToInt32(dr["IdTransaccion"]),
                                Fecha = Convert.ToDateTime(dr["Fecha"]),
                                Monto = Convert.ToDecimal(dr["Monto"]),
                                CuentaDebe = Convert.ToInt32(dr["CuentaDebe"]),
                                CuentaHaber = Convert.ToInt32(dr["CuentaHaber"]),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Transaccion>();
                }
            }
            return lista;
        }
    }
}
