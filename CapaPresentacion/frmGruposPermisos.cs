using CapaNegocio;
using CapaPresentacion.Modales;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmGruposPermisos : Form
    {
        private CN_Permiso permisoService = new CN_Permiso();

        public frmGruposPermisos()
        {
            InitializeComponent();
        }

        private void frmGruposPermisos_Load(object sender, EventArgs e)
        {
            CargarGruposPermisos();
        }

        private void CargarGruposPermisos()
        {
            var gruposPermisos = permisoService.ListarGruposPermisos();
            dgvGruposPermisos.Rows.Clear(); // Asegúrate de que no haya filas duplicadas
            foreach (var grupo in gruposPermisos)
            {
                dgvGruposPermisos.Rows.Add(grupo.IdGrupoPermiso, grupo.Nombre, false);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new mdAgregarGrupoPermiso();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarGruposPermisos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvGruposPermisos.Rows.Cast<DataGridViewRow>().FirstOrDefault(row => Convert.ToBoolean(row.Cells["colSeleccionar"].Value));
            if (selectedRow != null)
            {
                var idGrupoPermiso = Convert.ToInt32(selectedRow.Cells["colIdGrupoPermiso"].Value);
                var frm = new mdEditarGrupoPermiso(idGrupoPermiso);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarGruposPermisos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un grupo de permisos para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvGruposPermisos.Rows.Cast<DataGridViewRow>().FirstOrDefault(row => Convert.ToBoolean(row.Cells["colSeleccionar"].Value));
            if (selectedRow != null)
            {
                var idGrupoPermiso = Convert.ToInt32(selectedRow.Cells["colIdGrupoPermiso"].Value);
                permisoService.EliminarGrupoPermiso(idGrupoPermiso);
                CargarGruposPermisos();
            }
            else
            {
                MessageBox.Show("Seleccione un grupo de permisos para eliminar.");
            }
        }
    }
}
