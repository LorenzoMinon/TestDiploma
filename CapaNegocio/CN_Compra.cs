using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Compra
    {

        private CD_Compra objcd_compra = new CD_Compra();


        public int ObtenerCorrelativo()
        {
            return objcd_compra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            return objcd_compra.Registrar(obj, DetalleCompra, out Mensaje);
        }

        public Compra ObtenerCompra(string numero)
        {

            Compra oCompra = objcd_compra.ObtenerCompra(numero);

            if (oCompra.IdCompra != 0)
            {
                List<Detalle_Compra> oDetalleCompra = objcd_compra.ObtenerDetalleCompra(oCompra.IdCompra);

                oCompra.oDetalleCompra = oDetalleCompra;
            }
            return oCompra;
        }

        public List<Compra> ListarOrdenesDeCompra()
        {
            return objcd_compra.ListarOrdenesDeCompra();
        }

        public Compra ObtenerCompraPorId(int idCompra)
        {
            return objcd_compra.ObtenerCompraPorId(idCompra);
        }

        public bool ActualizarCantidadRecibida(int idDetalleCompra, int cantidadRecibida)
        {
            return objcd_compra.ActualizarCantidadRecibida(idDetalleCompra, cantidadRecibida);
        }

        // Método para actualizar el estado de la orden de compra
        public bool ActualizarEstadoOrdenCompra(int idOrden, string estado)
        {
            return objcd_compra.ActualizarEstadoOrdenCompra(idOrden, estado);
        }
    }
}
