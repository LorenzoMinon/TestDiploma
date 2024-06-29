using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDetalleCompra : Form
    {
        private int IdOrden;
        private Usuario usuarioActual;

        public frmDetalleCompra(int idOrden, Usuario usuario)
        {
            InitializeComponent();
            IdOrden = idOrden;
            usuarioActual = usuario;
            CargarDetallesOrdenCompra(IdOrden);
        }

        private void CargarDetallesOrdenCompra(int idOrden)
        {
            Compra oCompra = new CN_Compra().ObtenerCompraPorId(idOrden);
            if (oCompra != null)
            {
                txtTipoDocumento.Text = oCompra.TipoDocumento ?? string.Empty;
                txtNumeroDocumento.Text = oCompra.NumeroDocumento ?? string.Empty;
                txtFecha.Text = oCompra.FechaRegistro.ToString("dd/MM/yyyy");
                txtUsuario.Text = oCompra.oUsuario?.NombreCompleto ?? string.Empty;
                txtNumeroDocumentoProveedor.Text = oCompra.oProveedor?.Documento ?? string.Empty;
                txtRazonSocial.Text = oCompra.oProveedor?.RazonSocial ?? string.Empty;
                txtMontoTotal.Text = oCompra.MontoTotal.ToString("N2");
                cboEstado.SelectedItem = oCompra.Estado ?? string.Empty;

                dgvDetalleCompra.Rows.Clear();
                foreach (Detalle_Compra detalle in oCompra.oDetalleCompra ?? new List<Detalle_Compra>())
                {
                    int index = dgvDetalleCompra.Rows.Add();
                    dgvDetalleCompra.Rows[index].Cells["IdDetalleCompra"].Value = detalle.IdDetalleCompra;
                    dgvDetalleCompra.Rows[index].Cells["Producto"].Value = detalle.oProducto?.Nombre ?? string.Empty;
                    dgvDetalleCompra.Rows[index].Cells["IdProducto"].Value = detalle.oProducto?.IdProducto ?? 0;
                    dgvDetalleCompra.Rows[index].Cells["PrecioCompra"].Value = detalle.PrecioCompra;
                    dgvDetalleCompra.Rows[index].Cells["Cantidad"].Value = detalle.Cantidad;
                    dgvDetalleCompra.Rows[index].Cells["CantidadRecibida"].Value = detalle.CantidadRecibida;
                    dgvDetalleCompra.Rows[index].Cells["SubTotal"].Value = detalle.MontoTotal;
                }
            }
            else
            {
                MessageBox.Show("No se pudo cargar la información de la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDetalleCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDetalleCompra.Columns["CantidadRecibida"].Index)
            {
                // Obtener la cantidad recibida y actualizar el stock
                int cantidadRecibida = Convert.ToInt32(dgvDetalleCompra.Rows[e.RowIndex].Cells["CantidadRecibida"].Value);
                int idProducto = Convert.ToInt32(dgvDetalleCompra.Rows[e.RowIndex].Cells["IdProducto"].Value);

                // Actualizar el stock en la base de datos
                new CN_Producto().ActualizarStock(idProducto, cantidadRecibida);
            }
        }

        private void btnConfirmarRecepcion_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
            {
                if (row.Cells["IdDetalleCompra"].Value != null)
                {
                    int idDetalleCompra = Convert.ToInt32(row.Cells["IdDetalleCompra"].Value);
                    int cantidadRecibida = Convert.ToInt32(row.Cells["CantidadRecibida"].Value);

                    // Actualizar la cantidad recibida y opcionalmente el stock
                    new CN_Compra().ActualizarCantidadRecibida(idDetalleCompra, cantidadRecibida, true);
                }
            }

            // Actualizar el estado de la orden de compra
            string nuevoEstado = cboEstado.SelectedItem.ToString();
            new CN_Compra().ActualizarEstadoOrdenCompra(IdOrden, nuevoEstado);

            MessageBox.Show("Recepción confirmada y stock actualizado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
