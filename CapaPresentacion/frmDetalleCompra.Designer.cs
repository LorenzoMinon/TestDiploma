namespace CapaPresentacion
{
    partial class frmDetalleCompra
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNumeroDocumentoProveedor;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnConfirmarRecepcion;

        private void InitializeComponent()
        {
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.IdDetalleCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRecibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumentoProveedor = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnConfirmarRecepcion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDetalleCompra,
            this.Producto,
            this.IdProducto,
            this.PrecioCompra,
            this.Cantidad,
            this.CantidadRecibida,
            this.SubTotal});
            this.dgvDetalleCompra.Location = new System.Drawing.Point(12, 41);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.Size = new System.Drawing.Size(776, 150);
            this.dgvDetalleCompra.TabIndex = 0;
            // 
            // IdDetalleCompra
            // 
            this.IdDetalleCompra.HeaderText = "IdDetalleCompra";
            this.IdDetalleCompra.Name = "IdDetalleCompra";
            this.IdDetalleCompra.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = false;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "PrecioCompra";
            this.PrecioCompra.Name = "PrecioCompra";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // CantidadRecibida
            // 
            this.CantidadRecibida.HeaderText = "CantidadRecibida";
            this.CantidadRecibida.Name = "CantidadRecibida";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Location = new System.Drawing.Point(23, 217);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtTipoDocumento.TabIndex = 1;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(129, 217);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDocumento.TabIndex = 2;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(235, 217);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(341, 217);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtNumeroDocumentoProveedor
            // 
            this.txtNumeroDocumentoProveedor.Location = new System.Drawing.Point(447, 217);
            this.txtNumeroDocumentoProveedor.Name = "txtNumeroDocumentoProveedor";
            this.txtNumeroDocumentoProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDocumentoProveedor.TabIndex = 5;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(553, 217);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(100, 20);
            this.txtRazonSocial.TabIndex = 6;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(659, 217);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtMontoTotal.TabIndex = 7;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Parcialmente Completado",
            "Completado"});
            this.cboEstado.Location = new System.Drawing.Point(249, 265);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 8;
            // 
            // btnConfirmarRecepcion
            // 
            this.btnConfirmarRecepcion.Location = new System.Drawing.Point(386, 265);
            this.btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            this.btnConfirmarRecepcion.Size = new System.Drawing.Size(125, 23);
            this.btnConfirmarRecepcion.TabIndex = 9;
            this.btnConfirmarRecepcion.Text = "Confirmar Recepción";
            this.btnConfirmarRecepcion.UseVisualStyleBackColor = true;
            this.btnConfirmarRecepcion.Click += new System.EventHandler(this.btnConfirmarRecepcion_Click);
            // 
            // frmDetalleCompra
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmarRecepcion);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtNumeroDocumentoProveedor);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.txtTipoDocumento);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Name = "frmDetalleCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalleCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRecibida;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}
