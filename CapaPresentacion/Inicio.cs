using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null)
                usuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            else
                usuarioActual = objusuario;

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
            lblusuario.Text = usuarioActual.NombreCompleto;
        }

        private void AplicarPermisos()
        {
            var permisoService = new CN_Permiso();
            List<PermisoSimple> listaPermisos = permisoService.ListarPermisosConEstado(usuarioActual.IdUsuario);
            List<GrupoPermiso> listaGruposPermisos = permisoService.ListarGruposPermisosConEstado(usuarioActual.IdUsuario);

            // Lista para almacenar todos los permisos
            List<IPermiso> permisosCompletos = new List<IPermiso>();

            // Agregar permisos individuales
            permisosCompletos.AddRange(listaPermisos.Where(p => p.Asignado));

            // Agregar permisos de los grupos
            foreach (var grupo in listaGruposPermisos.Where(g => g.Asignado))
            {
                var permisosGrupo = permisoService.ListarPermisosConEstadoParaGrupo(grupo.Id);
                permisosCompletos.AddRange(permisosGrupo.Where(p => p.Asignado));
            }

            // Recorrer todos los menús y submenús
            RecorrerMenuItems(menu.Items, permisosCompletos);
        }

        private void RecorrerMenuItems(ToolStripItemCollection menuItems, List<IPermiso> permisosCompletos)
        {
            foreach (ToolStripMenuItem menuItem in menuItems)
            {
                bool tienePermiso = permisosCompletos.Any(p => p.Nombre == menuItem.Name);

                menuItem.Visible = tienePermiso;

                // Recursivamente recorrer submenús
                if (menuItem.DropDownItems.Count > 0)
                {
                    RecorrerMenuItems(menuItem.DropDownItems, permisosCompletos);
                }
            }
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmCategoria());
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmProducto());
        }

        private void submenuregistrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentas(usuarioActual));
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmDetalleVenta());
        }

        private void submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCompras(usuarioActual));
        }


        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }

        private void submenunegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmNegocio());
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new frmReporteCompras());
        }

        private void reporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new frmReporteVentas());
        }

        private void submenupermisossimples_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menupermisos, new frmPermisosSimples());
        }

        private void submenugruposdepermisos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menupermisos, new frmGruposPermisos());
        }

        private void menuordencompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmOrdenesDeCompra(usuarioActual));
        }
    }
}
