using CapaNegocio;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
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

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            CargarVentasPorCliente();
            CargarProductosMasVendidos();
        }

        private void CargarVentasPorCliente()
        {
            var reportes = reporteNegocio.ObtenerReporteVentasPorCliente();
            dgvVentasPorCliente.DataSource = reportes.Select(r => new
            {
                r.Cliente,
                r.TotalVendido
            }).ToList();

            chartVentasPorCliente.Series.Clear();
            Series series = new Series("Ventas")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double
            };

            chartVentasPorCliente.Series.Add(series);

            foreach (var reporte in reportes)
            {
                series.Points.AddXY(reporte.Cliente, reporte.TotalVendido);
            }
        }

        private void CargarProductosMasVendidos()
        {
            var reportes = reporteNegocio.ObtenerReporteProductosMasVendidos();
            dgvProductosMasVendidos.DataSource = reportes.Select(r => new
            {
                r.Producto,
                r.CantidadVendida
            }).ToList();

            chartProductosMasVendidos.Series.Clear();
            Series series = new Series("Productos")
            {
                ChartType = SeriesChartType.Pie,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double
            };

            chartProductosMasVendidos.Series.Add(series);

            foreach (var reporte in reportes)
            {
                series.Points.AddXY(reporte.Producto, reporte.CantidadVendida);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var dtVentasPorCliente = ConvertToDataTable((dgvVentasPorCliente.DataSource as IEnumerable<dynamic>).ToList());
                        var dtProductosMasVendidos = ConvertToDataTable((dgvProductosMasVendidos.DataSource as IEnumerable<dynamic>).ToList());

                        workbook.Worksheets.Add(dtVentasPorCliente, "Ventas Por Cliente");
                        workbook.Worksheets.Add(dtProductosMasVendidos, "Productos Más Vendidos");

                        workbook.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show("Exportación a Excel exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private DataTable ConvertToDataTable(List<dynamic> list)
        {
            var dt = new DataTable();
            if (list.Count > 0)
            {
                var firstRecord = list[0];
                foreach (var prop in firstRecord.GetType().GetProperties())
                {
                    dt.Columns.Add(prop.Name, prop.PropertyType);
                }

                foreach (var record in list)
                {
                    var row = dt.NewRow();
                    foreach (var prop in record.GetType().GetProperties())
                    {
                        row[prop.Name] = prop.GetValue(record, null);
                    }
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }
    }
}
