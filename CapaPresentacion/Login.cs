using CapaEntidad;
using CapaNegocio;
using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        private CN_Usuario userService = new CN_Usuario();

        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            // Obtener el usuario ingresado
            string documento = txtdocumento.Text;
            string claveIngresada = txtclave.Text;


            // Obtener el usuario de la base de datos
            Usuario ousuario = new CN_Usuario().Listar()
                .Where(u => u.Documento == documento)
                .FirstOrDefault();

            if (ousuario != null)
            {
                // Verificar si la contraseña ingresada coincide con la contraseña almacenada (encriptada)
                if (BCrypt.Net.BCrypt.Verify(claveIngresada, ousuario.Clave))
                {
                    // Contraseña correcta
                    Inicio form = new Inicio(ousuario);
                    CN_Auditoria auditoriaNegocio = new CN_Auditoria();
                    auditoriaNegocio.RegistrarAuditoria("Usuarios", "LOGIN", ousuario.IdUsuario, null, "Usuario inició sesión");
                    form.Show();
                    this.Hide();
                    form.FormClosing += frm_closing;
                }
                else
                {
                    // Contraseña incorrecta
                    MessageBox.Show("Contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // Usuario no encontrado
                MessageBox.Show("No se encontró el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show();
        }


        private void txtdocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btningresar_Click(sender, e);
            }
        }

        private void btnRecuperarClave_Click(object sender, EventArgs e)
        {
            frmRecuperarClave recuperarClaveForm = new frmRecuperarClave();
            recuperarClaveForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
