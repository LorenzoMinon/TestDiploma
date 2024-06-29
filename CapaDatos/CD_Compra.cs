using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Compra
    {
        public int ObtenerCorrelativo() {
            int idcorrelativo = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from COMPRA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }
            return idcorrelativo;
        }
        public void ActualizarDetalleCompra(int idProducto, int cantidadRecibida, string estado)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_ActualizarDetalleCompra", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                cmd.Parameters.AddWithValue("@CantidadRecibida", cantidadRecibida);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.ExecuteNonQuery();
            }
        }

        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                SqlTransaction transaction = null;

                try
                {
                    conexion.Open();
                    transaction = conexion.BeginTransaction();

                    SqlCommand cmd = new SqlCommand("sp_RegistrarCompra", conexion, transaction);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("IdProveedor", obj.oProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleCompra", DetalleCompra);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                    if (Respuesta)
                    {
                        // Registrar la transacción en el plan de cuentas

                        transaction.Commit();
                    }
                    else
                    {
                        transaction.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    if (transaction != null) transaction.Rollback();
                    Respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return Respuesta;
        }


        public Compra ObtenerCompra(string numero)
        {
            Compra obj = new Compra();
            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {

                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.IdCompra,");
                    query.AppendLine("u.NombreCompleto,");
                    query.AppendLine("pr.Documento,pr.RazonSocial,");
                    query.AppendLine("c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,convert(char(10), c.FechaRegistro, 103)[FechaRegistro]");
                    query.AppendLine("from COMPRA c");
                    query.AppendLine("inner join USUARIO u on u.IdUsuario = c.IdUsuario");
                    query.AppendLine("inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor");
                    query.AppendLine("where c.NumeroDocumento = @numero");


                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Compra()
                            {
                                IdCompra = Convert.ToInt32(dr["IdCompra"]),
                                oUsuario = new Usuario() { NombreCompleto = dr["NombreCompleto"].ToString() },
                                oProveedor = new Proveedor() { Documento = dr["Documento"].ToString(), RazonSocial = dr["RazonSocial"].ToString() },
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),
                            };
                        }

                    }


                }
                catch (Exception ex)
                {
                    obj = new Compra();
                }
            }



            return obj;
        }

        public List<Detalle_Compra> ObtenerDetalleCompra (int idcompra)
        {
            List<Detalle_Compra> oLista = new List<Detalle_Compra>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select p.Nombre, dc.PrecioCompra,dc.Cantidad,dc.MontoTotal from DETALLE_COMPRA dc");
                    query.AppendLine("inner join PRODUCTO p on p.IdProducto = dc.IdProducto");
                    query.AppendLine("where dc.IdCompra = @idcompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idcompra", idcompra);
                    cmd.CommandType = System.Data.CommandType.Text;


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Compra()
                            {
                                oProducto = new Producto() { Nombre = dr["Nombre"].ToString() },
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),

                            });
                        }

                    }

                }

            }
            catch(Exception ex)
            {
                oLista = new List<Detalle_Compra>();
            }
            return oLista;
        }
        public List<Compra> ListarOrdenesDeCompra()
        {
            List<Compra> lista = new List<Compra>();

            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.IdCompra, pr.RazonSocial, c.FechaRegistro, c.Estado");
                    query.AppendLine("FROM Compra c");
                    query.AppendLine("INNER JOIN Proveedor pr ON pr.IdProveedor = c.IdProveedor");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Compra
                            {
                                IdCompra = Convert.ToInt32(dr["IdCompra"]),
                                oProveedor = new Proveedor { RazonSocial = dr["RazonSocial"].ToString() },
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),
                                Estado = dr["Estado"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Compra>();
                }
            }

            return lista;
        }

        public Compra ObtenerCompraPorId(int idCompra)
        {
            Compra obj = null;

            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                try
                {
                    // Consulta para obtener la compra
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.IdCompra, u.NombreCompleto, pr.Documento, pr.RazonSocial,");
                    query.AppendLine("c.TipoDocumento, c.NumeroDocumento, c.MontoTotal, c.FechaRegistro, c.Estado");
                    query.AppendLine("FROM Compra c");
                    query.AppendLine("INNER JOIN Usuarios u ON u.IdUsuario = c.IdUsuario");
                    query.AppendLine("INNER JOIN Proveedor pr ON pr.IdProveedor = c.IdProveedor");
                    query.AppendLine("WHERE c.IdCompra = @idCompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idCompra", idCompra);
                    cmd.CommandType = System.Data.CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            obj = new Compra
                            {
                                IdCompra = Convert.ToInt32(dr["IdCompra"]),
                                oUsuario = new Usuario { NombreCompleto = dr["NombreCompleto"].ToString() },
                                oProveedor = new Proveedor { Documento = dr["Documento"].ToString(), RazonSocial = dr["RazonSocial"].ToString() },
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),
                                Estado = dr["Estado"].ToString()
                            };
                        }
                    }

                    // Obtener los detalles de la compra
                    if (obj != null)
                    {
                        query.Clear();
                        query.AppendLine("SELECT dc.IdDetalleCompra, p.Nombre, dc.PrecioCompra, dc.Cantidad, dc.CantidadRecibida, dc.MontoTotal");
                        query.AppendLine("FROM DETALLE_COMPRA dc");
                        query.AppendLine("INNER JOIN Producto p ON p.IdProducto = dc.IdProducto");
                        query.AppendLine("WHERE dc.IdCompra = @idCompra");

                        cmd = new SqlCommand(query.ToString(), conexion);
                        cmd.Parameters.AddWithValue("@idCompra", idCompra);
                        cmd.CommandType = System.Data.CommandType.Text;

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            obj.oDetalleCompra = new List<Detalle_Compra>();

                            while (dr.Read())
                            {
                                obj.oDetalleCompra.Add(new Detalle_Compra
                                {
                                    IdDetalleCompra = Convert.ToInt32(dr["IdDetalleCompra"]),
                                    oProducto = new Producto { Nombre = dr["Nombre"].ToString() },
                                    PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                                    Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                    CantidadRecibida = Convert.ToInt32(dr["CantidadRecibida"]),
                                    MontoTotal = Convert.ToDecimal(dr["MontoTotal"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    obj = null;
                }
            }

            return obj;
        }
        public bool ActualizarOrdenCompra(int idCompra, string estado, List<Detalle_Compra> detalles)
        {
            bool resultado = false;

            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                try
                {
                    conexion.Open();
                    SqlTransaction transaccion = conexion.BeginTransaction();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Compra SET Estado = @estado WHERE IdCompra = @idCompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion, transaccion);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@idCompra", idCompra);
                    cmd.CommandType = CommandType.Text;

                    cmd.ExecuteNonQuery();

                    foreach (var detalle in detalles)
                    {
                        query.Clear();
                        query.AppendLine("UPDATE DETALLE_COMPRA SET CantidadRecibida = @cantidadRecibida WHERE IdDetalleCompra = @idDetalleCompra");

                        cmd = new SqlCommand(query.ToString(), conexion, transaccion);
                        cmd.Parameters.AddWithValue("@cantidadRecibida", detalle.CantidadRecibida);
                        cmd.Parameters.AddWithValue("@idDetalleCompra", detalle.IdDetalleCompra);
                        cmd.CommandType = CommandType.Text;

                        cmd.ExecuteNonQuery();

                        if (estado == "Parcialmente Completado" || estado == "Completado")
                        {
                            query.Clear();
                            query.AppendLine("UPDATE Producto SET Stock = Stock + @cantidadRecibida WHERE IdProducto = @idProducto");

                            cmd = new SqlCommand(query.ToString(), conexion, transaccion);
                            cmd.Parameters.AddWithValue("@cantidadRecibida", detalle.CantidadRecibida);
                            cmd.Parameters.AddWithValue("@idProducto", detalle.oProducto.IdProducto);
                            cmd.CommandType = CommandType.Text;

                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaccion.Commit();
                    resultado = true;
                }
                catch (Exception ex)
                {
                    resultado = false;
                }
            }

            return resultado;
        }
        public bool ActualizarCantidadRecibida(int idDetalleCompra, int cantidadRecibida, bool actualizarStock)
        {
            bool respuesta = false;

            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                try
                {
                    conexion.Open();
                    SqlTransaction transaccion = conexion.BeginTransaction();

                    // Actualizar la cantidad recibida
                    SqlCommand cmd = new SqlCommand("sp_ActualizarCantidadRecibida", conexion, transaccion);
                    cmd.Parameters.AddWithValue("IdDetalleCompra", idDetalleCompra);
                    cmd.Parameters.AddWithValue("CantidadRecibida", cantidadRecibida);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    if (actualizarStock) //pasa como true .!
                    {
                        // Obtener el ID del producto asociado con el detalle de compra
                        cmd = new SqlCommand("SELECT IdProducto FROM DETALLE_COMPRA WHERE IdDetalleCompra = @IdDetalleCompra", conexion, transaccion);
                        cmd.Parameters.AddWithValue("IdDetalleCompra", idDetalleCompra);
                        int idProducto = (int)cmd.ExecuteScalar();

                        // Actualizar el stock
                        cmd = new SqlCommand("sp_ActualizarStock", conexion, transaccion);
                        cmd.Parameters.AddWithValue("IdProducto", idProducto);
                        cmd.Parameters.AddWithValue("CantidadRecibida", cantidadRecibida);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }

                    transaccion.Commit();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }





        // Método para actualizar el estado de la orden de compra
        public bool ActualizarEstadoOrdenCompra(int idOrden, string estado)
        {
            bool respuesta = false;

            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarEstadoOrdenCompra", conexion);
                    cmd.Parameters.AddWithValue("IdOrden", idOrden);
                    cmd.Parameters.AddWithValue("Estado", estado);
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
    }
}
