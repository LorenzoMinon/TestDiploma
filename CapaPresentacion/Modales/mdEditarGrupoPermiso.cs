using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdEditarGrupoPermiso : Form
    {
        private CN_Permiso permisoService = new CN_Permiso();
        private int idGrupoPermiso;

        public mdEditarGrupoPermiso(int idGrupoPermiso)
        {
            InitializeComponent();
            this.idGrupoPermiso = idGrupoPermiso;
        }

        private void mdEditarGrupoPermiso_Load(object sender, EventArgs e)
        {
            var grupoPermiso = permisoService.ObtenerGrupoPermisoPorId(idGrupoPermiso);
            txtNombreGrupo.Text = grupoPermiso.Nombre;
            CargarPermisos(grupoPermiso.IdGrupoPermiso);
        }

        private void CargarPermisos(int idGrupoPermiso)
        {
            var permisos = permisoService.ListarPermisosConEstadoParaGrupo(idGrupoPermiso);
            dgvPermisos.DataSource = permisos;
            dgvPermisos.Columns["IdPermiso"].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreGrupo.Text))
            {
                MessageBox.Show("Ingrese un nombre para el grupo de permisos.");
                return;
            }

            permisoService.EditarGrupoPermiso(idGrupoPermiso, txtNombreGrupo.Text);

            foreach (DataGridViewRow row in dgvPermisos.Rows)
            {
                int idPermiso = Convert.ToInt32(row.Cells["IdPermiso"].Value);
                bool asignado = Convert.ToBoolean(row.Cells["Asignado"].Value);

                if (asignado)
                {
                    permisoService.AsignarPermisoAGrupo(idGrupoPermiso, idPermiso);
                }
                else
                {
                    permisoService.RevocarPermisoDeGrupo(idGrupoPermiso, idPermiso);
                }
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
