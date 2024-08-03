namespace CapaPresentacion
{
    partial class frmReporteAuditoria
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAuditorias;

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
            this.dgvAuditorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuditorias
            // 
            this.dgvAuditorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditorias.Location = new System.Drawing.Point(12, 12);
            this.dgvAuditorias.Name = "dgvAuditorias";
            this.dgvAuditorias.Size = new System.Drawing.Size(815, 418);
            this.dgvAuditorias.TabIndex = 0;
            this.dgvAuditorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditorias_CellClick);
            // 
            // frmReporteAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 465);
            this.Controls.Add(this.dgvAuditorias);
            this.Name = "frmReporteAuditoria";
            this.Text = "Reporte de Auditoría";
            this.Load += new System.EventHandler(this.frmReporteAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditorias)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
