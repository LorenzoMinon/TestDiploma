using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion.Modales
{
    public partial class mdAsignarPermisos : Form
    {
        private int idUsuario;
        private CN_Permiso permisoService = new CN_Permiso();

        public mdAsignarPermisos(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void mdAsignarPermisos_Load(object sender, EventArgs e)
        {
            var permisos = permisoService.ListarPermisosConEstado(idUsuario);

            dgvPermisos.DataSource = null;
            dgvPermisos.Rows.Clear();

            foreach (var permiso in permisos)
            {
                dgvPermisos.Rows.Add(permiso.Nombre, permiso.Asignado);
            }

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
