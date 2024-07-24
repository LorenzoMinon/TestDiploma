using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        private CD_Reporte objcd_Reporte = new CD_Reporte();

        public List<ReporteComprasPorProveedor> ObtenerReporteComprasPorProveedor()
        {
            return objcd_Reporte.ReporteComprasPorProveedor();
        }

        public List<ReporteCantidadCompradaPorProducto> ObtenerReporteCantidadCompradaPorProducto()
        {
            return objcd_Reporte.ReporteCantidadCompradaPorProducto();
        }

        public List<ReporteGananciaPotencialPorProducto> ObtenerReporteGananciaPotencialPorProducto()
        {
            return objcd_Reporte.ReporteGananciaPotencialPorProducto();
        }
        // Método para obtener el reporte de ventas por cliente
        public List<ReporteVentaPorCliente> ObtenerReporteVentasPorCliente()
        {
            return objcd_Reporte.ObtenerReporteVentasPorCliente();
        }

        // Método para obtener el reporte de productos más vendidos
        public List<ReporteProductoMasVendido> ObtenerReporteProductosMasVendidos()
        {
            return objcd_Reporte.ObtenerReporteProductosMasVendidos();
        }
    }
}
