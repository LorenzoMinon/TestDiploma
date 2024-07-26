namespace CapaPresentacion
{
    partial class frmReporteVentas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvVentasPorCliente;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentasPorCliente;
        private System.Windows.Forms.DataGridView dgvProductosMasVendidos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductosMasVendidos;
        private System.Windows.Forms.Button btnExportarExcel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dgvVentasPorCliente = new System.Windows.Forms.DataGridView();
            this.chartVentasPorCliente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvProductosMasVendidos = new System.Windows.Forms.DataGridView();
            this.chartProductosMasVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasPorCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentasPorCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosMasVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductosMasVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentasPorCliente
            // 
            this.dgvVentasPorCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasPorCliente.Location = new System.Drawing.Point(11, 12);
            this.dgvVentasPorCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVentasPorCliente.Name = "dgvVentasPorCliente";
            this.dgvVentasPorCliente.RowTemplate.Height = 24;
            this.dgvVentasPorCliente.Size = new System.Drawing.Size(622, 122);
            this.dgvVentasPorCliente.TabIndex = 0;
            // 
            // chartVentasPorCliente
            // 
            chartArea1.Name = "ChartArea1";
            this.chartVentasPorCliente.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVentasPorCliente.Legends.Add(legend1);
            this.chartVentasPorCliente.Location = new System.Drawing.Point(11, 138);
            this.chartVentasPorCliente.Margin = new System.Windows.Forms.Padding(2);
            this.chartVentasPorCliente.Name = "chartVentasPorCliente";
            this.chartVentasPorCliente.Size = new System.Drawing.Size(622, 362);
            this.chartVentasPorCliente.TabIndex = 1;
            this.chartVentasPorCliente.Text = "chart1";
            // 
            // dgvProductosMasVendidos
            // 
            this.dgvProductosMasVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosMasVendidos.Location = new System.Drawing.Point(683, 12);
            this.dgvProductosMasVendidos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductosMasVendidos.Name = "dgvProductosMasVendidos";
            this.dgvProductosMasVendidos.RowTemplate.Height = 24;
            this.dgvProductosMasVendidos.Size = new System.Drawing.Size(623, 123);
            this.dgvProductosMasVendidos.TabIndex = 2;
            // 
            // chartProductosMasVendidos
            // 
            chartArea2.Name = "ChartArea2";
            this.chartProductosMasVendidos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend2";
            this.chartProductosMasVendidos.Legends.Add(legend2);
            this.chartProductosMasVendidos.Location = new System.Drawing.Point(683, 139);
            this.chartProductosMasVendidos.Margin = new System.Windows.Forms.Padding(2);
            this.chartProductosMasVendidos.Name = "chartProductosMasVendidos";
            this.chartProductosMasVendidos.Size = new System.Drawing.Size(623, 361);
            this.chartProductosMasVendidos.TabIndex = 3;
            this.chartProductosMasVendidos.Text = "chart2";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(610, 538);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(112, 24);
            this.btnExportarExcel.TabIndex = 6;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 615);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.chartProductosMasVendidos);
            this.Controls.Add(this.dgvProductosMasVendidos);
            this.Controls.Add(this.chartVentasPorCliente);
            this.Controls.Add(this.dgvVentasPorCliente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReporteVentas";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasPorCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentasPorCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosMasVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductosMasVendidos)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
