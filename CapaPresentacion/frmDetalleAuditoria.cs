using System;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class frmDetalleAuditoria : Form
    {
        private Auditoria _auditoria;

        public frmDetalleAuditoria(Auditoria auditoria)
        {
            InitializeComponent();
            _auditoria = auditoria;
            CargarDetalles();
        }

        private void CargarDetalles()
        {
            lblAuditoriaIDValue.Text = _auditoria.AuditoriaID.ToString();
            lblTablaValue.Text = _auditoria.Tabla;
            lblOperacionValue.Text = _auditoria.Operacion;
            lblUsuarioIDValue.Text = _auditoria.UsuarioID.ToString();
            lblFechaOperacionValue.Text = _auditoria.FechaOperacion.ToString("dd/MM/yyyy HH:mm");
            lblValorAnteriorValue.Text = _auditoria.ValorAnterior;
            lblValorNuevoValue.Text = _auditoria.ValorNuevo;
        }
    }
}
