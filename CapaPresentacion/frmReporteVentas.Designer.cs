using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion
{
    partial class frmReporteVentas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvReporteVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;

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
            this.dgvReporteVentas = new System.Windows.Forms.DataGridView();
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporteVentas
            // 
            this.dgvReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteVentas.Location = new System.Drawing.Point(12, 12);
            this.dgvReporteVentas.Name = "dgvReporteVentas";
            this.dgvReporteVentas.RowTemplate.Height = 24;
            this.dgvReporteVentas.Size = new System.Drawing.Size(776, 200);
            this.dgvReporteVentas.TabIndex = 0;
            // 
            // chartVentas
            // 
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            chartArea1.Name = "ChartArea1";
            this.chartVentas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVentas.Legends.Add(legend1);
            this.chartVentas.Location = new System.Drawing.Point(12, 218);
            this.chartVentas.Name = "chartVentas";
            this.chartVentas.Size = new System.Drawing.Size(776, 220);
            this.chartVentas.TabIndex = 1;
            this.chartVentas.Text = "chart1";
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartVentas);
            this.Controls.Add(this.dgvReporteVentas);
            this.Name = "frmReporteVentas";
            this.Text = "Reporte de Ventas por Producto";
            //this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
