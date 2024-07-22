using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private CD_Compra objcd_Compra = new CD_Compra();
        private CN_Auditoria auditoriaNegocio = new CN_Auditoria();

        public CN_Compra()
        {
            objcd_Compra.OnCompraAudit += Objcd_Compra_OnCompraAudit;
        }

        private void Objcd_Compra_OnCompraAudit(object sender, CD_Compra.AuditoriaEventArgs e)
        {
            auditoriaNegocio.RegistrarAuditoria(e.Tabla, e.Operacion, e.UsuarioID, e.ValorAnterior, e.ValorNuevo);
        }

        public int ObtenerCorrelativo()
        {
            return objcd_Compra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            return objcd_Compra.Registrar(obj, DetalleCompra, out Mensaje);
        }

        public Compra ObtenerCompra(string numero)
        {
            return objcd_Compra.ObtenerCompra(numero);
        }

        public List<Detalle_Compra> ObtenerDetalleCompra(int idcompra)
        {
            return objcd_Compra.ObtenerDetalleCompra(idcompra);
        }

        public List<Compra> ListarOrdenesDeCompra()
        {
            return objcd_Compra.ListarOrdenesDeCompra();
        }

        public Compra ObtenerCompraPorId(int idCompra)
        {
            return objcd_Compra.ObtenerCompraPorId(idCompra);
        }

        public bool ActualizarOrdenCompra(int idCompra, string estado, List<Detalle_Compra> detalles)
        {
            return objcd_Compra.ActualizarOrdenCompra(idCompra, estado, detalles);
        }

        public bool ActualizarCantidadRecibida(int idDetalleCompra, int cantidadRecibida, bool actualizarStock)
        {
            return objcd_Compra.ActualizarCantidadRecibida(idDetalleCompra, cantidadRecibida, actualizarStock);
        }

        public bool ActualizarEstadoOrdenCompra(int idOrden, string estado)
        {
            return objcd_Compra.ActualizarEstadoOrdenCompra(idOrden, estado);
        }
    }
}
