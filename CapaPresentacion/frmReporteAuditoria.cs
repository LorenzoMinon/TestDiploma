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
            dgvAuditoria.DataSource = auditorias.Select(a => new
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
    }
}
