using CapaNegocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmReporteAuditoria : Form
    {
        private CN_Auditoria auditoriaNegocio = new CN_Auditoria();

        public frmReporteAuditoria()
        {
            InitializeComponent();
        }

        private void frmReporteAuditoria_Load(object sender, EventArgs e)
        {
            CargarAuditorias();
        }

        private void CargarAuditorias()
        {
            var auditorias = auditoriaNegocio.ObtenerAuditorias();
            dgvAuditorias.DataSource = auditorias.Select(a => new
            {
                a.AuditoriaID,
                a.Tabla,
                a.Operacion,
                a.UsuarioID,
                a.FechaOperacion,
                a.ValorAnterior,
                a.ValorNuevo
            }).ToList();
        }

        private void dgvAuditorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvAuditorias.Rows[e.RowIndex];
                int auditoriaID = (int)selectedRow.Cells["AuditoriaID"].Value;
                MostrarDetalleAuditoria(auditoriaID);
            }
        }

        private void MostrarDetalleAuditoria(int auditoriaID)
        {
            var auditoria = auditoriaNegocio.ObtenerAuditorias().FirstOrDefault(a => a.AuditoriaID == auditoriaID);
            if (auditoria != null)
            {
                frmDetalleAuditoria detalleForm = new frmDetalleAuditoria(auditoria);
                detalleForm.Show();
            }
        }
    }
}
