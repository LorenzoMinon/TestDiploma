namespace CapaPresentacion
{
    partial class frmOrdenesDeCompra
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
            this.dgvOrdenesDeCompra = new System.Windows.Forms.DataGridView();
            this.IdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesDeCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrdenesDeCompra
            // 
            this.dgvOrdenesDeCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenesDeCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCompra,
            this.Proveedor,
            this.Fecha,
            this.Estado,
            this.Seleccionar});
            this.dgvOrdenesDeCompra.Location = new System.Drawing.Point(12, 12);
            this.dgvOrdenesDeCompra.Name = "dgvOrdenesDeCompra";
            this.dgvOrdenesDeCompra.Size = new System.Drawing.Size(776, 426);
            this.dgvOrdenesDeCompra.TabIndex = 0;
            this.dgvOrdenesDeCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenesDeCompra_CellContentClick);
            // 
            // IdCompra
            // 
            this.IdCompra.HeaderText = "ID Compra";
            this.IdCompra.Name = "IdCompra";
            this.IdCompra.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // frmOrdenesDeCompra
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOrdenesDeCompra);
            this.Name = "frmOrdenesDeCompra";
            this.Text = "Órdenes de Compra";
            this.Load += new System.EventHandler(this.frmOrdenesDeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesDeCompra)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvOrdenesDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}
