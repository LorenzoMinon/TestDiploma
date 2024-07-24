using CapaNegocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDetalleVenta : Form
    {
        private CN_Venta _ventaNegocio = new CN_Venta();

        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void CargarVentas(string filtroCliente = "", DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            var ventas = _ventaNegocio.ListarVentas(filtroCliente, fechaInicio, fechaFin);
            dgvVentas.DataSource = ventas.Select(v => new
            {
                v.IdVenta,
                v.NombreCliente,
                v.MontoTotal,
                v.FechaRegistro
            }).ToList();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtroCliente = txtFiltroCliente.Text;
            DateTime? fechaInicio = dtpFechaInicio.Value;
            DateTime? fechaFin = dtpFechaFin.Value;

            CargarVentas(filtroCliente, fechaInicio, fechaFin);
        }

        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idVenta = Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells["IdVenta"].Value);
                MostrarDetalleVenta(idVenta);
            }
        }

        private void MostrarDetalleVenta(int idVenta)
        {
            var venta = _ventaNegocio.ObtenerVenta(idVenta);
            lblCliente.Text = "Cliente: " + venta.NombreCliente;
            lblTotal.Text = "Total: " + venta.MontoTotal.ToString("C");

            dgvDetalleVenta.DataSource = venta.oDetalle_Venta.Select(d => new
            {
                d.oProducto.Nombre,
                d.Cantidad,
                d.PrecioVenta,
                d.SubTotal
            }).ToList();
        }
    }
}
