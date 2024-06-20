// CapaPresentacion/frmCuenta.cs
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCuenta : Form
    {
        public frmCuenta()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta()
            {
                Nombre = txtNombre.Text,
                Tipo = cboTipo.SelectedItem.ToString(),
                Codigo = txtCodigo.Text,
                Padre = cboPadre.SelectedIndex > 0 ? (int?)cboPadre.SelectedValue : null
            };

            string mensaje;
            bool respuesta = new CN_Cuenta().Registrar(cuenta, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Cuenta registrada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            cboTipo.SelectedIndex = 0;
            txtCodigo.Text = "";
            cboPadre.SelectedIndex = 0;
        }

        private void frmCuenta_Load(object sender, EventArgs e)
        {
            cboTipo.Items.Add("Activo");
            cboTipo.Items.Add("Pasivo");
            cboTipo.Items.Add("Patrimonio");
            cboTipo.Items.Add("Ingreso");
            cboTipo.Items.Add("Gasto");
            cboTipo.SelectedIndex = 0;

            List<Cuenta> cuentas = new CN_Cuenta().Listar();
            cboPadre.DataSource = cuentas;
            cboPadre.DisplayMember = "Nombre";
            cboPadre.ValueMember = "IdCuenta";
            cboPadre.SelectedIndex = -1;
        }
    }
}
