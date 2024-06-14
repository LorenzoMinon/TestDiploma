using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPermisosSimples : Form
    {
        private CN_Usuario usuarioService = new CN_Usuario();
        private CN_Permiso permisoService = new CN_Permiso();
        private int idUsuarioSeleccionado;

        public frmPermisosSimples()
        {
            InitializeComponent();
        }

        private void frmPermisosSimples_Load(object sender, EventArgs e)
        {
            var usuarios = usuarioService.Listar();
            cbUsuarios.DataSource = usuarios;
            cbUsuarios.DisplayMember = "NombreCompleto";
            cbUsuarios.ValueMember = "IdUsuario";
        }

        private void cbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUsuarios.SelectedValue is int idUsuario)
            {
                idUsuarioSeleccionado = idUsuario;
                CargarPermisos();
            }
        }

        private void CargarPermisos()
        {
            var permisosSimples = permisoService.ListarPermisosConEstado(idUsuarioSeleccionado);
            var gruposPermisos = permisoService.ListarGruposPermisosConEstado(idUsuarioSeleccionado);

            dgvPermisos.Rows.Clear();

            foreach (var permiso in permisosSimples)
            {
                dgvPermisos.Rows.Add(permiso.Asignado, "Permiso", permiso.Nombre);
            }

            foreach (var grupo in gruposPermisos)
            {
                dgvPermisos.Rows.Add(grupo.Asignado, "Grupo", grupo.Nombre);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPermisos.Rows)
            {
                if (row.Cells["colAsignado"].Value != null && row.Cells["colNombrePermiso"].Value != null)
                {
                    bool asignado = Convert.ToBoolean(row.Cells["colAsignado"].Value);
                    string tipoPermiso = row.Cells["colTipoPermiso"].Value.ToString();
                    string nombrePermiso = row.Cells["colNombrePermiso"].Value.ToString();

                    if (tipoPermiso == "Permiso")
                    {
                        var permiso = permisoService.ObtenerPermisoPorNombre(nombrePermiso);

                        if (asignado)
                        {
                            permisoService.AsignarPermisoAUsuario(idUsuarioSeleccionado, permiso.IdPermiso);
                        }
                        else
                        {
                            permisoService.RevocarPermisoDeUsuario(idUsuarioSeleccionado, permiso.IdPermiso);
                        }
                    }
                    else if (tipoPermiso == "Grupo")
                    {
                        var grupoPermiso = permisoService.ObtenerGrupoPermisoPorNombre(nombrePermiso);

                        if (asignado)
                        {
                            permisoService.AsignarGrupoPermisoAUsuario(idUsuarioSeleccionado, grupoPermiso.IdGrupoPermiso);
                        }
                        else
                        {
                            permisoService.RevocarGrupoPermisoDeUsuario(idUsuarioSeleccionado, grupoPermiso.IdGrupoPermiso);
                        }
                    }
                }
            }

            MessageBox.Show("Permisos actualizados correctamente.");
        }
    }
}
