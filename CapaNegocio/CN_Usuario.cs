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
    public class CN_Usuario
    {
        //Nuevo
        private string connectionString = Conexion.Instancia.Cadena;
        private CD_Usuario cdUsuario = new CD_Usuario();

        private CD_Usuario _cdUsuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return _cdUsuario.Listar();
        }

        public Usuario ObtenerUsuarioPorDocumento(string Documento)
        {
            Usuario usuario = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuarios WHERE Documento = @Documento";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Documento", Documento);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario
                        {
                            IdUsuario = (int)reader["IdUsuario"],
                            Documento = (string)reader["Documento"],
                            Clave = (string)reader["Clave"]
                            // Otros campos necesarios
                        };
                    }
                }
            }
            return usuario;
        }

        //public bool VerificarPermiso(string Documento, string nombrePermiso)
        //{
        //    CN_Permiso permisoNegocio = new CN_Permiso();
        //    List<Permiso> permisos = permisoNegocio.ObtenerPermisosPorDocumento(Documento);
        //    return permisos.Any(p => p.Nombre == nombrePermiso);
        //}



        private CD_Usuario objcd_usuario = new CD_Usuario();


        public List<Usuario> ListarUsuarios()
        {
            return objcd_usuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del usuario\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_usuario.Registrar(obj, out Mensaje);
            }


        }


        public bool Editar(Usuario obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del usuario\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }


            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(obj, out Mensaje);
            }


        }


        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objcd_usuario.Eliminar(obj, out Mensaje);
        }


        public Usuario ObtenerUsuarioPorCorreo(string correo)
        {
            return cdUsuario.ObtenerUsuarioPorCorreo(correo);
        }

        public bool ActualizarClave(int idUsuario, string nuevaClave)
        {
            return cdUsuario.ActualizarClave(idUsuario, nuevaClave);
        }
    }
}
