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
    public partial class mdAgregarGrupoPermiso : Form
    {
        private CN_Permiso permisoService = new CN_Permiso();

        public mdAgregarGrupoPermiso()
        {
            InitializeComponent();
        }

        private void mdAgregarGrupoPermiso_Load(object sender, EventArgs e)
        {
            CargarPermisos();
        }

        private void CargarPermisos()
        {
            var permisos = permisoService.ListarPermisos();
            dgvPermisos.Rows.Clear(); // Asegúrate de que no haya filas duplicadas
            foreach (var permiso in permisos)
            {
                dgvPermisos.Rows.Add(false, permiso.Nombre);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreGrupo.Text))
            {
                MessageBox.Show("Ingrese un nombre para el grupo de permisos.");
                return;
            }

            int idGrupoPermiso = permisoService.AgregarGrupoPermiso(txtNombreGrupo.Text);

            foreach (DataGridViewRow row in dgvPermisos.Rows)
            {
                bool asignado = Convert.ToBoolean(row.Cells["colAsignado"].Value);
                if (asignado)
                {
                    string nombrePermiso = row.Cells["colNombre"].Value.ToString();
                    var permiso = permisoService.ObtenerPermisoPorNombre(nombrePermiso);
                    permisoService.AsignarPermisoAGrupo(idGrupoPermiso, permiso.Id);
                }
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
