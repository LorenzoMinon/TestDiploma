namespace CapaPresentacion
{
    partial class frmReporteCompras
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvComprasPorProveedor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartComprasPorProveedor;
        private System.Windows.Forms.DataGridView dgvCantidadCompradaPorProducto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCantidadCompradaPorProducto;
        private System.Windows.Forms.DataGridView dgvGananciaPotencialPorProducto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGananciaPotencialPorProducto;
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dgvComprasPorProveedor = new System.Windows.Forms.DataGridView();
            this.chartComprasPorProveedor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvCantidadCompradaPorProducto = new System.Windows.Forms.DataGridView();
            this.chartCantidadCompradaPorProducto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvGananciaPotencialPorProducto = new System.Windows.Forms.DataGridView();
            this.chartGananciaPotencialPorProducto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasPorProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartComprasPorProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidadCompradaPorProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCantidadCompradaPorProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGananciaPotencialPorProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGananciaPotencialPorProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComprasPorProveedor
            // 
            this.dgvComprasPorProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasPorProveedor.Location = new System.Drawing.Point(11, 12);
            this.dgvComprasPorProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvComprasPorProveedor.Name = "dgvComprasPorProveedor";
            this.dgvComprasPorProveedor.RowTemplate.Height = 24;
            this.dgvComprasPorProveedor.Size = new System.Drawing.Size(582, 122);
            this.dgvComprasPorProveedor.TabIndex = 0;
            // 
            // chartComprasPorProveedor
            // 
            chartArea1.Name = "ChartArea1";
            this.chartComprasPorProveedor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartComprasPorProveedor.Legends.Add(legend1);
            this.chartComprasPorProveedor.Location = new System.Drawing.Point(11, 138);
            this.chartComprasPorProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.chartComprasPorProveedor.Name = "chartComprasPorProveedor";
            this.chartComprasPorProveedor.Size = new System.Drawing.Size(582, 206);
            this.chartComprasPorProveedor.TabIndex = 1;
            this.chartComprasPorProveedor.Text = "chart1";
            // 
            // dgvCantidadCompradaPorProducto
            // 
            this.dgvCantidadCompradaPorProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCantidadCompradaPorProducto.Location = new System.Drawing.Point(650, 12);
            this.dgvCantidadCompradaPorProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCantidadCompradaPorProducto.Name = "dgvCantidadCompradaPorProducto";
            this.dgvCantidadCompradaPorProducto.RowTemplate.Height = 24;
            this.dgvCantidadCompradaPorProducto.Size = new System.Drawing.Size(582, 122);
            this.dgvCantidadCompradaPorProducto.TabIndex = 2;
            // 
            // chartCantidadCompradaPorProducto
            // 
            chartArea2.Name = "ChartArea2";
            this.chartCantidadCompradaPorProducto.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend2";
            this.chartCantidadCompradaPorProducto.Legends.Add(legend2);
            this.chartCantidadCompradaPorProducto.Location = new System.Drawing.Point(650, 139);
            this.chartCantidadCompradaPorProducto.Margin = new System.Windows.Forms.Padding(2);
            this.chartCantidadCompradaPorProducto.Name = "chartCantidadCompradaPorProducto";
            this.chartCantidadCompradaPorProducto.Size = new System.Drawing.Size(582, 205);
            this.chartCantidadCompradaPorProducto.TabIndex = 3;
            this.chartCantidadCompradaPorProducto.Text = "chart2";
            // 
            // dgvGananciaPotencialPorProducto
            // 
            this.dgvGananciaPotencialPorProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGananciaPotencialPorProducto.Location = new System.Drawing.Point(11, 348);
            this.dgvGananciaPotencialPorProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGananciaPotencialPorProducto.Name = "dgvGananciaPotencialPorProducto";
            this.dgvGananciaPotencialPorProducto.RowTemplate.Height = 24;
            this.dgvGananciaPotencialPorProducto.Size = new System.Drawing.Size(582, 211);
            this.dgvGananciaPotencialPorProducto.TabIndex = 4;
            // 
            // chartGananciaPotencialPorProducto
            // 
            chartArea3.Name = "ChartArea3";
            this.chartGananciaPotencialPorProducto.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend3";
            this.chartGananciaPotencialPorProducto.Legends.Add(legend3);
            this.chartGananciaPotencialPorProducto.Location = new System.Drawing.Point(650, 348);
            this.chartGananciaPotencialPorProducto.Margin = new System.Windows.Forms.Padding(2);
            this.chartGananciaPotencialPorProducto.Name = "chartGananciaPotencialPorProducto";
            this.chartGananciaPotencialPorProducto.Size = new System.Drawing.Size(582, 211);
            this.chartGananciaPotencialPorProducto.TabIndex = 5;
            this.chartGananciaPotencialPorProducto.Text = "chart3";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(1236, 367);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(112, 24);
            this.btnExportarExcel.TabIndex = 6;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // frmReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 615);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.chartGananciaPotencialPorProducto);
            this.Controls.Add(this.dgvGananciaPotencialPorProducto);
            this.Controls.Add(this.chartCantidadCompradaPorProducto);
            this.Controls.Add(this.dgvCantidadCompradaPorProducto);
            this.Controls.Add(this.chartComprasPorProveedor);
            this.Controls.Add(this.dgvComprasPorProveedor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReporteCompras";
            this.Text = "Reporte de Compras";
            this.Load += new System.EventHandler(this.frmReporteCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasPorProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartComprasPorProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidadCompradaPorProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCantidadCompradaPorProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGananciaPotencialPorProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGananciaPotencialPorProducto)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
