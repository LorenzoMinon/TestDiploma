﻿using CapaEntidad;
using CapaNegocio;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using FontAwesome.Sharp;
using System.Drawing;

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
            var permisosCompletos = permisoService.ListarPermisosCompletos(usuarioActual.IdUsuario);

            MessageBox.Show("Total permisos asignados: " + permisosCompletos.Count);

            // Recorrer todos los menús y submenús
            RecorrerMenuItems(menu.Items, permisosCompletos);
        }


        private void RecorrerMenuItems(ToolStripItemCollection menuItems, List<Component> permisosCompletos)
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
                MenuActivo.BackColor = Color.FromArgb(234, 228, 0);
            }
            menu.BackColor = Color.Silver; //
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.FromArgb(61, 63, 76);

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
            AbrirFormulario((IconMenuItem)sender, new frmReporteCompras());
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

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuauditoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuauditoria, new frmReporteAuditoria());
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            CN_Usuario usuarioNegocio = new CN_Usuario();
            usuarioNegocio.CerrarSesion(usuarioActual.IdUsuario);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }
    }
}
