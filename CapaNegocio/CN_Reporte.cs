using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

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
    }
}
