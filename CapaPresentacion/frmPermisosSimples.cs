﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

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
                CargarGruposPermisos();
            }
        }

        private void CargarPermisos()
        {
            var permisosSimples = permisoService.ListarPermisosConEstado(idUsuarioSeleccionado);

            dgvPermisos.Rows.Clear();

            foreach (var permiso in permisosSimples)
            {
                dgvPermisos.Rows.Add(permiso.Nombre, permiso.Asignado);
            }
        }

        private void CargarGruposPermisos()
        {
            var gruposPermisos = permisoService.ListarGruposPermisosConEstado(idUsuarioSeleccionado);

            dgvGruposPermisos.Rows.Clear();

            foreach (var grupo in gruposPermisos)
            {
                dgvGruposPermisos.Rows.Add(grupo.Nombre, grupo.Asignado);
            }
        }

        private void dgvPermisos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvPermisos.Columns[e.ColumnIndex].Name == "colAsignadoPermiso")
            {
                bool asignado = Convert.ToBoolean(dgvPermisos.Rows[e.RowIndex].Cells["colAsignadoPermiso"].Value);
                string nombrePermiso = dgvPermisos.Rows[e.RowIndex].Cells["colNombrePermiso"].Value.ToString();

                var permiso = permisoService.ObtenerPermisoPorNombre(nombrePermiso);

                if (asignado)
                {
                    permisoService.AsignarPermisoAUsuario(idUsuarioSeleccionado, permiso.Id);
                }
                else
                {
                    permisoService.RevocarPermisoDeUsuario(idUsuarioSeleccionado, permiso.Id);
                }
            }
        }

        private void dgvGruposPermisos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvGruposPermisos.Columns[e.ColumnIndex].Name == "colAsignadoGrupoPermiso")
            {
                bool asignado = Convert.ToBoolean(dgvGruposPermisos.Rows[e.RowIndex].Cells["colAsignadoGrupoPermiso"].Value);
                string nombreGrupoPermiso = dgvGruposPermisos.Rows[e.RowIndex].Cells["colNombreGrupoPermiso"].Value.ToString();

                var grupoPermiso = permisoService.ObtenerGrupoPermisoPorNombre(nombreGrupoPermiso);

                if (asignado)
                {
                    permisoService.AsignarGrupoPermisoAUsuario(idUsuarioSeleccionado, grupoPermiso.Id);
                }
                else
                {
                    permisoService.RevocarGrupoPermisoDeUsuario(idUsuarioSeleccionado, grupoPermiso.Id);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPermisos.Rows)
            {
                if (row.Cells["colAsignadoPermiso"].Value != null && row.Cells["colNombrePermiso"].Value != null)
                {
                    bool asignado = Convert.ToBoolean(row.Cells["colAsignadoPermiso"].Value);
                    string nombrePermiso = row.Cells["colNombrePermiso"].Value.ToString();

                    var permiso = permisoService.ObtenerPermisoPorNombre(nombrePermiso);

                    if (asignado)
                    {
                        permisoService.AsignarPermisoAUsuario(idUsuarioSeleccionado, permiso.Id);
                    }
                    else
                    {
                        permisoService.RevocarPermisoDeUsuario(idUsuarioSeleccionado, permiso.Id);
                    }
                }
            }

            foreach (DataGridViewRow row in dgvGruposPermisos.Rows)
            {
                if (row.Cells["colAsignadoGrupoPermiso"].Value != null && row.Cells["colNombreGrupoPermiso"].Value != null)
                {
                    bool asignado = Convert.ToBoolean(row.Cells["colAsignadoGrupoPermiso"].Value);
                    string nombreGrupoPermiso = row.Cells["colNombreGrupoPermiso"].Value.ToString();

                    var grupoPermiso = permisoService.ObtenerGrupoPermisoPorNombre(nombreGrupoPermiso);

                    if (asignado)
                    {
                        permisoService.AsignarGrupoPermisoAUsuario(idUsuarioSeleccionado, grupoPermiso.Id);
                    }
                    else
                    {
                        permisoService.RevocarGrupoPermisoDeUsuario(idUsuarioSeleccionado, grupoPermiso.Id);
                    }
                }
            }

            MessageBox.Show("Permisos actualizados correctamente.");
        }
    }
}
