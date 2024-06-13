using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPermisosSimples : Form
    {
        private CN_Permiso permisoService = new CN_Permiso();
        private int idUsuario;

        public frmPermisosSimples(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void frmPermisosSimples_Load(object sender, EventArgs e)
        {
            CargarPermisos();
        }

        private void CargarPermisos()
        {
            var permisos = permisoService.ListarPermisosConEstado(idUsuario);
            dgvPermisos.DataSource = permisos;
            dgvPermisos.Columns["IdPermiso"].Visible = false;
            dgvPermisos.Columns["Nombre"].ReadOnly = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPermisos.Rows)
            {
                if (row.Cells["Nombre"].Value != null && row.Cells["Asignado"].Value != null)
                {
                    string nombrePermiso = row.Cells["Nombre"].Value.ToString();
                    bool asignado = Convert.ToBoolean(row.Cells["Asignado"].Value);

                    var permiso = permisoService.ObtenerPermisoPorNombre(nombrePermiso);

                    if (asignado)
                    {
                        permisoService.AsignarPermisoAUsuario(idUsuario, permiso.IdPermiso);
                    }
                    else
                    {
                        permisoService.RevocarPermisoDeUsuario(idUsuario, permiso.IdPermiso);
                    }
                }
            }

            MessageBox.Show("Permisos actualizados correctamente.");
            this.Close();
        }
    }
}
