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

        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;
            int idUsuario = ObtenerIdUsuarioPorDocumento(documento);
            if (idUsuario != -1)
            {
                int idPermiso = int.Parse(txtIdPermiso.Text);
                permisoService.AsignarPermisoAUsuario(idUsuario, idPermiso);
                MessageBox.Show("Permiso asignado correctamente.");
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void btnAsignarGrupoPermiso_Click(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;
            int idUsuario = ObtenerIdUsuarioPorDocumento(documento);
            if (idUsuario != -1)
            {
                int idGrupoPermiso = int.Parse(txtIdGrupoPermiso.Text);
                permisoService.AsignarGrupoPermisoAUsuario(idUsuario, idGrupoPermiso);
                MessageBox.Show("Grupo de permiso asignado correctamente.");
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void btnVerPermisos_Click(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;
            int dni = ObtenerIdUsuarioPorDocumento(documento);
            if (dni != -1)
            {
                var permisos = permisoService.ObtenerPermisosPorDocumento(dni);
                lstPermisos.Items.Clear();
                foreach (var permiso in permisos)
                {
                    lstPermisos.Items.Add(permiso.Nombre);
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void btnVerGruposPermisos_Click(object sender, EventArgs e)
        {
            int idGrupoPermiso = int.Parse(txtIdGrupoPermiso.Text);
            var permisos = permisoService.ObtenerPermisosPorGrupoID(idGrupoPermiso);
            lstPermisos.Items.Clear();
            foreach (var permiso in permisos)
            {
                lstPermisos.Items.Add(permiso.Nombre);
            }
        }
    }
}
