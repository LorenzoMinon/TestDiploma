using CapaNegocio;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion
{
    public partial class frmReporteVentas : Form
    {
        private CN_Reporte reporteNegocio = new CN_Reporte();

        public frmReporteVentas()
        {
            InitializeComponent();
        }

        //private void frmReporteVentas_Load(object sender, EventArgs e)
        //{
        //    CargarReporteVentas();
        //}

        //private void CargarReporteVentas()
        //{
        //    var reportes = reporteNegocio.ObtenerReporteVentasPorProducto();
        //    dgvReporteVentas.DataSource = reportes.Select(r => new
        //    {
        //        r.Producto,
        //        r.CantidadVendida,
        //        r.TotalVendido
        //    }).ToList();

        //    // Configurar el gráfico
        //    chartVentas.Series.Clear();
        //    Series series = new Series("Ventas")
        //    {
        //        ChartType = SeriesChartType.Column,
        //        XValueType = ChartValueType.String,
        //        YValueType = ChartValueType.Double
        //    };

        //    chartVentas.Series.Add(series);

        //    foreach (var reporte in reportes)
        //    {
        //        series.Points.AddXY(reporte.Producto, reporte.TotalVendido);
        //    }
        //}
    }
}
