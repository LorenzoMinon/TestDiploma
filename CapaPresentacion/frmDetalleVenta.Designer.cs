using System.Drawing;

namespace CapaPresentacion
{
    partial class frmDetalleVenta
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.TextBox txtFiltroCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Label lblFiltroCliente;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;

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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.txtFiltroCliente = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.lblFiltroCliente = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(12, 12);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(600, 200);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellDoubleClick);
            // 
            // txtFiltroCliente
            // 
            this.txtFiltroCliente.Location = new System.Drawing.Point(148, 266);
            this.txtFiltroCliente.Name = "txtFiltroCliente";
            this.txtFiltroCliente.Size = new System.Drawing.Size(200, 20);
            this.txtFiltroCliente.TabIndex = 1;
            this.txtFiltroCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltroCliente_KeyDown);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(148, 299);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 2;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(148, 329);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(378, 326);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 30);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.White;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCliente.Location = new System.Drawing.Point(661, 46);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(52, 15);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(840, 46);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 15);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(648, 62);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.RowTemplate.Height = 24;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(600, 150);
            this.dgvDetalleVenta.TabIndex = 7;
            // 
            // lblFiltroCliente
            // 
            this.lblFiltroCliente.AutoSize = true;
            this.lblFiltroCliente.BackColor = System.Drawing.Color.White;
            this.lblFiltroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFiltroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFiltroCliente.Location = new System.Drawing.Point(23, 269);
            this.lblFiltroCliente.Name = "lblFiltroCliente";
            this.lblFiltroCliente.Size = new System.Drawing.Size(105, 15);
            this.lblFiltroCliente.TabIndex = 8;
            this.lblFiltroCliente.Text = "Filtro por cliente:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.BackColor = System.Drawing.Color.White;
            this.lblFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaInicio.Location = new System.Drawing.Point(23, 299);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(83, 15);
            this.lblFechaInicio.TabIndex = 9;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.BackColor = System.Drawing.Color.White;
            this.lblFechaFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaFin.Location = new System.Drawing.Point(23, 329);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(69, 15);
            this.lblFechaFin.TabIndex = 10;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // frmDetalleVenta
            // 
            this.ClientSize = new System.Drawing.Size(1295, 616);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblFiltroCliente);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.txtFiltroCliente);
            this.Controls.Add(this.dgvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDetalleVenta";
            this.Text = "Detalle de Ventas";
            this.Load += new System.EventHandler(this.frmDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
