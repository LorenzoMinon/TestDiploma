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
    public partial class frmReporteCompras : Form
    {
        private CN_Reporte reporteNegocio = new CN_Reporte();

        public frmReporteCompras()
        {
            InitializeComponent();
        }

        private void frmReporteCompras_Load(object sender, EventArgs e)
        {
            CargarComprasPorProveedor();
            CargarCantidadCompradaPorProducto();
            CargarGananciaPotencialPorProducto();
        }

        private void CargarComprasPorProveedor()
        {
            var reportes = reporteNegocio.ObtenerReporteComprasPorProveedor();
            dgvComprasPorProveedor.DataSource = reportes.Select(r => new
            {
                r.Proveedor,
                r.TotalComprado
            }).ToList();

            // Configurar el gráfico
            chartComprasPorProveedor.Series.Clear();
            Series series = new Series("Compras")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double
            };

            chartComprasPorProveedor.Series.Add(series);

            foreach (var reporte in reportes)
            {
                series.Points.AddXY(reporte.Proveedor, reporte.TotalComprado);
            }
        }
        private void CargarCantidadCompradaPorProducto()
        {
            var reportes = reporteNegocio.ObtenerReporteCantidadCompradaPorProducto();
            dgvCantidadCompradaPorProducto.DataSource = reportes.Select(r => new
            {
                r.Producto,
                r.CantidadComprada
            }).ToList();

            // Calcular el total de cantidades compradas
            double total = reportes.Sum(r => r.CantidadComprada);
            double umbral = total * 0.07; // 7% del total

            // Configurar el gráfico
            chartCantidadCompradaPorProducto.Series.Clear();
            Series series = new Series("Cantidad Comprada")
            {
                ChartType = SeriesChartType.Pie,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double
            };

            chartCantidadCompradaPorProducto.Series.Add(series);

            foreach (var reporte in reportes)
            {
                int pointIndex = series.Points.AddXY(reporte.Producto, reporte.CantidadComprada);

                // Determinar si el valor supera el umbral del 7%
                if (reporte.CantidadComprada > umbral)
                {
                    series.Points[pointIndex].Label = $"{reporte.Producto}: {reporte.CantidadComprada}";
                }
                else
                {
                    // Establecer la etiqueta como transparente para que no se muestre en el gráfico
                    series.Points[pointIndex].Label = $"{reporte.Producto}: {reporte.CantidadComprada}";
                    series.Points[pointIndex].LabelForeColor = System.Drawing.Color.Transparent;
                }
            }

            // Actualizar el gráfico para reflejar cambios
            chartCantidadCompradaPorProducto.Invalidate();
        }



        private void CargarGananciaPotencialPorProducto()
        {
            var reportes = reporteNegocio.ObtenerReporteGananciaPotencialPorProducto();
            dgvGananciaPotencialPorProducto.DataSource = reportes.Select(r => new
            {
                r.Producto,
                r.GananciaPotencial
            }).ToList();

            // Configurar el gráfico
            chartGananciaPotencialPorProducto.Series.Clear();
            Series series = new Series("Ganancia Potencial")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double
            };

            chartGananciaPotencialPorProducto.Series.Add(series);

            foreach (var reporte in reportes)
            {
                series.Points.AddXY(reporte.Producto, reporte.GananciaPotencial);
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
                        var dtComprasPorProveedor = ConvertToDataTable((dgvComprasPorProveedor.DataSource as IEnumerable<dynamic>).ToList());
                        var dtCantidadCompradaPorProducto = ConvertToDataTable((dgvCantidadCompradaPorProducto.DataSource as IEnumerable<dynamic>).ToList());
                        var dtGananciaPotencialPorProducto = ConvertToDataTable((dgvGananciaPotencialPorProducto.DataSource as IEnumerable<dynamic>).ToList());

                        workbook.Worksheets.Add(dtComprasPorProveedor, "Compras Por Proveedor");
                        workbook.Worksheets.Add(dtCantidadCompradaPorProducto, "Cantidad Comprada Por Producto");
                        workbook.Worksheets.Add(dtGananciaPotencialPorProducto, "Ganancia Potencial Por Producto");

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

        private void chartCantidadCompradaPorProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
