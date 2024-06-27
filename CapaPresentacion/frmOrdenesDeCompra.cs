using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class frmOrdenesDeCompra : Form
    {
        private Usuario usuarioActual;

        public frmOrdenesDeCompra(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
        }

        private void frmOrdenesDeCompra_Load(object sender, EventArgs e)
        {
            CargarOrdenesDeCompra();
        }

        private void CargarOrdenesDeCompra()
        {
            List<Compra> lista = new CN_Compra().ListarOrdenesDeCompra();
            dgvOrdenesDeCompra.Rows.Clear();
            foreach (Compra compra in lista)
            {
                dgvOrdenesDeCompra.Rows.Add(compra.IdCompra, compra.oProveedor.RazonSocial, compra.FechaRegistro.ToString("dd/MM/yyyy"), compra.Estado);
            }
        }

        private void dgvOrdenesDeCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvOrdenesDeCompra.Columns["Seleccionar"].Index && e.RowIndex >= 0)
            {
                int idCompra = Convert.ToInt32(dgvOrdenesDeCompra.Rows[e.RowIndex].Cells["IdCompra"].Value);
                using (var modal = new frmDetalleCompra(idCompra, usuarioActual))
                {
                    modal.ShowDialog();
                    if (modal.DialogResult == DialogResult.OK)
                    {
                        CargarOrdenesDeCompra();  // Recargar listado si hay cambios
                    }
                }
            }
        }
    }
}
