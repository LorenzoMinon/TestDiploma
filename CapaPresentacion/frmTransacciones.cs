// CapaPresentacion/frmTransacciones.cs
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmTransacciones : Form
    {
        public frmTransacciones()
        {
            InitializeComponent();
        }

        private void frmTransacciones_Load(object sender, EventArgs e)
        {
            var transacciones = new CN_Transaccion().Listar();

            dgvTransacciones.Rows.Clear();
            foreach (var transaccion in transacciones)
            {
                dgvTransacciones.Rows.Add(
                    transaccion.IdTransaccion,
                    transaccion.Fecha,
                    transaccion.Monto,
                    transaccion.CuentaDebe,
                    transaccion.CuentaHaber,
                    transaccion.Descripcion
                );
            }
        }
    }
}
