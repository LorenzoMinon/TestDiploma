﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private CN_Usuario userService = new CN_Usuario();

        private void btningresar_Click(object sender, EventArgs e)
        {
            //List<Usuario> Test = new CN_Usuario().Listar();
            //Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text).FirstOrDefault();

            //if(ousuario != null)
            //{
            //    Inicio form = new Inicio(ousuario);

            //    form.Show();
            //    this.Hide();

            //    form.FormClosing += frm_closing;
            //}
            //else
            //{
            //    MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

            string documento = txtdocumento.Text;
            string clave = txtclave.Text;

            Usuario usuario = userService.ObtenerUsuarioPorDocumento(documento);
            if (usuario != null && usuario.Clave == clave)
            {

                    Inicio form = new Inicio(usuario);

                    form.Show();
                    this.Hide();

                    form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }



        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show(); //Mostramos cuando ocultamos anteriormente
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
    }
}
