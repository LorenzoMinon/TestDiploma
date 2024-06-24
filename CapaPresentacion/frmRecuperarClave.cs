using System;
using System.Net.Mail;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class frmRecuperarClave : Form
    {
        public frmRecuperarClave()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;

            if (string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("Por favor, ingrese su correo electrónico.");
                return;
            }

            CN_Usuario cnUsuario = new CN_Usuario();
            Usuario usuario = cnUsuario.ObtenerUsuarioPorCorreo(correo);

            if (usuario != null)
            {
                string nuevaClave = GenerarNuevaClave();
                cnUsuario.ActualizarClave(usuario.IdUsuario, nuevaClave);
                EnviarCorreoRecuperacion(correo, nuevaClave);
                MessageBox.Show("Se ha enviado una nueva contraseña a su correo electrónico.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontró un usuario con ese correo electrónico.");
            }
        }

        private string GenerarNuevaClave()
        {
            return Guid.NewGuid().ToString().Substring(0, 8); // Generar una nueva clave de 8 caracteres
        }

        private void EnviarCorreoRecuperacion(string correo, string nuevaClave)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp-relay.brevo.com");

                mail.From = new MailAddress("770f9c001@smtp-brevo.com");
                mail.To.Add(correo);
                mail.Subject = "Recuperación de Contraseña";
                mail.Body = $"Su nueva contraseña es: {nuevaClave}";

                smtpServer.Port = 587; // Puerto para TLS
                smtpServer.Credentials = new System.Net.NetworkCredential("770f9c001@smtp-brevo.com", "WG2IN3sczMnSQphA");
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al enviar correo.", ex);
            }
        }

        private void frmRecuperarClave_Load(object sender, EventArgs e)
        {

        }
    }
}
