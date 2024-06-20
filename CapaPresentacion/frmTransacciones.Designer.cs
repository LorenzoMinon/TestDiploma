// CapaPresentacion/frmTransacciones.Designer.cs
namespace CapaPresentacion
{
    partial class frmTransacciones
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dgvTransacciones = new System.Windows.Forms.DataGridView();
            this.IdTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransacciones
            // 
            this.dgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTransaccion,
            this.Fecha,
            this.Monto,
            this.CuentaDebe,
            this.CuentaHaber,
            this.Descripcion});
            this.dgvTransacciones.Location = new System.Drawing.Point(12, 12);
            this.dgvTransacciones.Name = "dgvTransacciones";
            this.dgvTransacciones.Size = new System.Drawing.Size(760, 337);
            this.dgvTransacciones.TabIndex = 0;
            // 
            // IdTransaccion
            // 
            this.IdTransaccion.HeaderText = "ID";
            this.IdTransaccion.Name = "IdTransaccion";
            this.IdTransaccion.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // CuentaDebe
            // 
            this.CuentaDebe.HeaderText = "Cuenta Debe";
            this.CuentaDebe.Name = "CuentaDebe";
            this.CuentaDebe.ReadOnly = true;
            // 
            // CuentaHaber
            // 
            this.CuentaHaber.HeaderText = "Cuenta Haber";
            this.CuentaHaber.Name = "CuentaHaber";
            this.CuentaHaber.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // frmTransacciones
            // 
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.dgvTransacciones);
            this.Name = "frmTransacciones";
            this.Text = "Transacciones";
            this.Load += new System.EventHandler(this.frmTransacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvTransacciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaHaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}
