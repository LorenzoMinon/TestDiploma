using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Producto
    {
        private string connectionString = Conexion.Instancia.Cadena;

        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdProducto, Codigo, Nombre, p.Descripcion, c.IdCategoria, c.Descripcion AS DescripcionCategoria, Stock, PrecioCompra, PrecioVenta, p.Estado");
                    query.AppendLine("FROM PRODUCTO p");
                    query.AppendLine("INNER JOIN CATEGORIAS c ON c.IdCategoria = p.IdCategoria");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Producto producto = new Producto()
                            {
                                IdProducto = dr["IdProducto"] != DBNull.Value ? Convert.ToInt32(dr["IdProducto"]) : 0,
                                Codigo = dr["Codigo"] != DBNull.Value ? dr["Codigo"].ToString() : string.Empty,
                                Nombre = dr["Nombre"] != DBNull.Value ? dr["Nombre"].ToString() : string.Empty,
                                Descripcion = dr["Descripcion"] != DBNull.Value ? dr["Descripcion"].ToString() : string.Empty,
                                oCategoria = new Categoria()
                                {
                                    IdCategoria = dr["IdCategoria"] != DBNull.Value ? Convert.ToInt32(dr["IdCategoria"]) : 0,
                                    Descripcion = dr["DescripcionCategoria"] != DBNull.Value ? dr["DescripcionCategoria"].ToString() : string.Empty
                                },
                                Stock = dr["Stock"] != DBNull.Value ? Convert.ToInt32(dr["Stock"]) : 0,
                                PrecioCompra = dr["PrecioCompra"] != DBNull.Value ? Convert.ToDecimal(dr["PrecioCompra"]) : 0,
                                PrecioVenta = dr["PrecioVenta"] != DBNull.Value ? Convert.ToDecimal(dr["PrecioVenta"]) : 0,
                                Estado = dr["Estado"] != DBNull.Value ? Convert.ToBoolean(dr["Estado"]) : false
                            };

                            lista.Add(producto);
                        }
                    }

                    // Depuración: Verifica cuántos productos se encontraron
                    //MessageBox.Show($"Se encontraron {lista.Count} productos.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al listar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lista = new List<Producto>();
                }
            }

            return lista;
        }



        public int Registrar(Producto obj, out string Mensaje)
        {
            int idProductogenerado = 0;
            Mensaje = string.Empty;


            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    SqlCommand cmd = new SqlCommand("SP_RegistrarProducto", connection);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    cmd.ExecuteNonQuery();

                    idProductogenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                idProductogenerado = 0;
                Mensaje = ex.Message;
            }



            return idProductogenerado;
        }



        public bool Editar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    SqlCommand cmd = new SqlCommand("SP_ModificarProducto", connection); //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output; //Parametros de salida del SP
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }



            return respuesta;
        }


        public bool Eliminar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    SqlCommand cmd = new SqlCommand("SP_EliminarProducto", connection);
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }
        public bool ActualizarStock(int idProducto, int cantidadRecibida)
        {
            bool resultado = false;

            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Producto SET Stock = Stock + @cantidadRecibida WHERE IdProducto = @idProducto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@cantidadRecibida", cantidadRecibida);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    resultado = true;
                }
                catch (Exception ex)
                {
                    resultado = false;
                }
            }

            return resultado;
        }

    }
}



