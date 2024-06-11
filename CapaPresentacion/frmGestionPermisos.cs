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

namespace CapaPresentacion
{
    public partial class frmGestionPermisos : Form
    {
        private CN_Permiso permisoService = new CN_Permiso();
        private CN_Usuario usuarioService = new CN_Usuario();

        public frmGestionPermisos()
        {
            InitializeComponent();
        }

        private int ObtenerIdUsuarioPorDocumento(string documento)
        {
            var usuario = usuarioService.ObtenerUsuarioPorDocumento(documento);
            return usuario != null ? usuario.IdUsuario : -1;
        }
        private void btnVerPermisos_Click(object sender, EventArgs e)
        {
            // Asegurarse de que el campo del documento no esté vacío.
            string documento = txtDocumento.Text.Trim();
            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor, ingrese un documento.");
                return; // Terminar la ejecución del método si no hay documento.
            }

            // Obtener los permisos asociados al documento.
            var permisos = permisoService.ObtenerPermisosPorDocumento(documento);

            // Limpiar el DataGridView antes de cargar nuevos datos.
            dgvPermisos.DataSource = null;

            if (permisos == null || permisos.Count == 0)
            {
                MessageBox.Show("No hay permisos para mostrar para el documento especificado.");
            }
            else
            {
                // Asignar la lista de permisos como fuente de datos del DataGridView.
                dgvPermisos.DataSource = permisos;

                // Configurar las columnas después de asignar el DataSource para asegurarse de que se tome la nueva fuente.
                dgvPermisos.Columns["IdPermiso"].DataPropertyName = "IdPermiso"; // Vincular las propiedades del modelo Permiso a las columnas
                dgvPermisos.Columns["Nombre"].DataPropertyName = "Nombre";
                dgvPermisos.Columns["IdPermiso"].Visible = true; // Mostrar u ocultar según la necesidad.
                dgvPermisos.Columns["Nombre"].HeaderText = "Nombre del Permiso";
            }
        }


        //private void btnAsignarPermiso_Click(object sender, EventArgs e)
        //{
        //    string documento = txtDocumento.Text;
        //    int idUsuario = ObtenerIdUsuarioPorDocumento(documento);
        //    if (idUsuario != -1)
        //    {
        //        int idPermiso = int.Parse(txtIdPermiso.Text);
        //        permisoService.AsignarPermisoAUsuario(idUsuario, idPermiso);
        //        MessageBox.Show("Permiso asignado correctamente.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Usuario no encontrado.");
        //    }
        //}

        //private void btnAsignarGrupoPermiso_Click(object sender, EventArgs e)
        //{
        //    string documento = txtDocumento.Text;
        //    int idUsuario = ObtenerIdUsuarioPorDocumento(documento);
        //    if (idUsuario != -1)
        //    {
        //        int idGrupoPermiso = int.Parse(txtIdGrupoPermiso.Text);
        //        permisoService.AsignarGrupoPermisoAUsuario(idUsuario, idGrupoPermiso);
        //        MessageBox.Show("Grupo de permiso asignado correctamente.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Usuario no encontrado.");
        //    }
        //}



        //private void btnVerGruposPermisos_Click(object sender, EventArgs e)
        //{
        //    int idGrupoPermiso = int.Parse(txtIdGrupoPermiso.Text);
        //    var permisos = permisoService.ObtenerPermisosPorGrupoID(idGrupoPermiso);
        //    lstPermisos.Items.Clear();
        //    foreach (var permiso in permisos)
        //    {
        //        lstPermisos.Items.Add(permiso.Nombre);
        //    }
        //}

        private void lstPermisos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
