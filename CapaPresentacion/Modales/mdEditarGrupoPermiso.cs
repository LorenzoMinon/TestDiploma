using CapaEntidad;
using CapaNegocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdEditarGrupoPermiso : Form
    {
        private int IdGrupoPermiso;
        private CN_Permiso permisoService = new CN_Permiso();

        public mdEditarGrupoPermiso(int idGrupoPermiso)
        {
            InitializeComponent();
            this.IdGrupoPermiso = idGrupoPermiso;
        }

        private void mdEditarGrupoPermiso_Load(object sender, EventArgs e)
        {
            var grupoPermiso = permisoService.ObtenerGrupoPermisoPorId(IdGrupoPermiso);
            txtNombreGrupo.Text = grupoPermiso.Nombre;

            var permisos = permisoService.ListarPermisosConEstadoParaGrupo(IdGrupoPermiso);
            dgvPermisos.Rows.Clear();
            foreach (var permiso in permisos)
            {
                dgvPermisos.Rows.Add(permiso.Asignado, permiso.Nombre);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtNombreGrupo.Text.Trim();
            permisoService.EditarGrupoPermiso(IdGrupoPermiso, nuevoNombre);

            foreach (DataGridViewRow row in dgvPermisos.Rows)
            {
                if (row.Cells["colAsignado"].Value != null && row.Cells["colNombrePermiso"].Value != null)
                {
                    bool asignado = Convert.ToBoolean(row.Cells["colAsignado"].Value);
                    string nombrePermiso = row.Cells["colNombrePermiso"].Value.ToString();

                    var permiso = permisoService.ObtenerPermisoPorNombre(nombrePermiso);

                    if (asignado)
                    {
                        permisoService.AsignarPermisoAGrupo(IdGrupoPermiso, permiso.IdPermiso);
                    }
                    else
                    {
                        permisoService.RevocarPermisoDeGrupo(IdGrupoPermiso, permiso.IdPermiso);
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
