using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public delegate void AuditoriaEventHandler(object sender, AuditoriaEventArgs e);
        public event AuditoriaEventHandler OnLoginAudit;
        public event AuditoriaEventHandler OnLogoutAudit;
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                try
                {
                    string query = "select IdUsuario, Documento, NombreCompleto, Correo, Clave, Estado from usuarios";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                    // Considera registrar el error en un log
                }
            }

            return lista;
        }

        public Usuario IniciarSesion(string correo, string clave)
        {
            Usuario usuario = null;

            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                string query = "SELECT * FROM usuarios WHERE Correo = @Correo AND Clave = @Clave";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Clave", clave);
                conexion.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario
                        {
                            IdUsuario = (int)reader["IdUsuario"],
                            Documento = (string)reader["Documento"],
                            NombreCompleto = (string)reader["NombreCompleto"],
                            Correo = (string)reader["Correo"],
                            Clave = (string)reader["Clave"],
                            Estado = (bool)reader["Estado"]
                        };
                    }
                }

                if (usuario != null)
                {
                    // Disparar evento de auditoría de login
                    OnLoginAudit?.Invoke(this, new AuditoriaEventArgs
                    {
                        UsuarioID = usuario.IdUsuario,
                        Tabla = "Usuarios",
                        Operacion = "LOGIN",
                        ValorAnterior = null,
                        ValorNuevo = "Usuario inició sesión"
                    });
                }
            }

            return usuario;
        }

        public void CerrarSesion(int usuarioID)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                conexion.Open();

                // Disparar evento de auditoría de logout
                OnLogoutAudit?.Invoke(this, new AuditoriaEventArgs
                {
                    UsuarioID = usuarioID,
                    Tabla = "Usuarios",
                    Operacion = "LOGOUT",
                    ValorAnterior = null,
                    ValorNuevo = "Usuario cerró sesión"
                });
            }
        }

        public class AuditoriaEventArgs : EventArgs
        {
            public int UsuarioID { get; set; }
            public string Tabla { get; set; }
            public string Operacion { get; set; }
            public string ValorAnterior { get; set; }
            public string ValorNuevo { get; set; }
        }




        public int Registrar(Usuario obj, out string Mensaje)
        {
            int idusuariogenerado = 0;
            Mensaje = string.Empty;


            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", conexion);
                    cmd.Parameters.AddWithValue("Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    cmd.ExecuteNonQuery();

                    idusuariogenerado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                idusuariogenerado = 0;
                Mensaje = ex.Message;
            }



            return idusuariogenerado;
        }



        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", conexion); //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdUsuario", obj.IdUsuario);
                    cmd.Parameters.AddWithValue("Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output; //Parametros de salida del SP
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

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


        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
                {


                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", conexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.IdUsuario);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

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
        public Usuario ObtenerUsuarioPorCorreo(string correo)
        {
            Usuario usuario = null;
            using (SqlConnection conn = new SqlConnection(Conexion.Instancia.Cadena))
            {
                string query = "SELECT * FROM usuarios WHERE Correo = @Correo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Correo", correo);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario
                        {
                            IdUsuario = (int)reader["IdUsuario"],
                            Documento = (string)reader["Documento"],
                            NombreCompleto = (string)reader["NombreCompleto"],
                            Correo = (string)reader["Correo"],
                            Clave = (string)reader["Clave"],
                            Estado = (bool)reader["Estado"]
                        };
                    }
                }
            }
            return usuario;
        }

        public bool ActualizarClave(int idUsuario, string nuevaClave)
        {
            using (SqlConnection conn = new SqlConnection(Conexion.Instancia.Cadena))
            {
                string query = "UPDATE usuarios SET Clave = @Clave WHERE IdUsuario = @IdUsuario";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Clave", nuevaClave);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

    }
}
