namespace CapaPresentacion
{
    partial class frmDetalleCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRecibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDetalleCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumentoProveedor = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();

            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNumeroDocumentoProveedor = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();

            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnConfirmarRecepcion = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.Producto,
                this.PrecioCompra,
                this.Cantidad,
                this.CantidadRecibida,
                this.SubTotal,
                this.IdProducto,
                this.IdDetalleCompra // Añadir esta columna al DataGridView
            });
            this.dgvDetalleCompra.Location = new System.Drawing.Point(12, 12);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.Size = new System.Drawing.Size(760, 200);
            this.dgvDetalleCompra.TabIndex = 0;

            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";

            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";

            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";

            // 
            // CantidadRecibida
            // 
            this.CantidadRecibida.HeaderText = "Cantidad Recibida";
            this.CantidadRecibida.Name = "CantidadRecibida";

            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";

            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Id Producto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = false;

            // 
            // IdDetalleCompra
            // 
            this.IdDetalleCompra.HeaderText = "Id Detalle Compra";
            this.IdDetalleCompra.Name = "IdDetalleCompra";
            this.IdDetalleCompra.Visible = false;

            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Location = new System.Drawing.Point(12, 240);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.ReadOnly = true;
            this.txtTipoDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtTipoDocumento.TabIndex = 1;

            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(130, 240);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.ReadOnly = true;
            this.txtNumeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDocumento.TabIndex = 2;

            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(250, 240);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 3;

            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(370, 240);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 4;

            // 
            // txtNumeroDocumentoProveedor
            // 
            this.txtNumeroDocumentoProveedor.Location = new System.Drawing.Point(490, 240);
            this.txtNumeroDocumentoProveedor.Name = "txtNumeroDocumentoProveedor";
            this.txtNumeroDocumentoProveedor.ReadOnly = true;
            this.txtNumeroDocumentoProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDocumentoProveedor.TabIndex = 5;

            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(610, 240);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(100, 20);
            this.txtRazonSocial.TabIndex = 6;

            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(730, 240);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtMontoTotal.TabIndex = 7;

            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(12, 220);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(91, 13);
            this.lblTipoDocumento.TabIndex = 8;
            this.lblTipoDocumento.Text = "Tipo Documento:";

            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(130, 220);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(99, 13);
            this.lblNumeroDocumento.TabIndex = 9;
            this.lblNumeroDocumento.Text = "Número Documento:";

            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(250, 220);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha:";

            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(370, 220);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario:";

            // 
            // lblNumeroDocumentoProveedor
            // 
            this.lblNumeroDocumentoProveedor.AutoSize = true;
            this.lblNumeroDocumentoProveedor.Location = new System.Drawing.Point(490, 220);
            this.lblNumeroDocumentoProveedor.Name = "lblNumeroDocumentoProveedor";
            this.lblNumeroDocumentoProveedor.Size = new System.Drawing.Size(141, 13);
            this.lblNumeroDocumentoProveedor.TabIndex = 12;
            this.lblNumeroDocumentoProveedor.Text = "Número Documento Proveedor:";

            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(610, 220);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 13;
            this.lblRazonSocial.Text = "Razón Social:";

            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(730, 220);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(65, 13);
            this.lblMontoTotal.TabIndex = 14;
            this.lblMontoTotal.Text = "Monto Total:";

            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 270);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado:";

            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
                "Pendiente",
                "Parcialmente Completado",
                "Completado"
            });
            this.cboEstado.Location = new System.Drawing.Point(12, 290);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 16;

            // 
            // btnConfirmarRecepcion
            // 
            this.btnConfirmarRecepcion.Location = new System.Drawing.Point(150, 290);
            this.btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            this.btnConfirmarRecepcion.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarRecepcion.TabIndex = 17;
            this.btnConfirmarRecepcion.Text = "Confirmar";
            this.btnConfirmarRecepcion.UseVisualStyleBackColor = true;
            this.btnConfirmarRecepcion.Click += new System.EventHandler(this.btnConfirmarRecepcion_Click);

            // 
            // frmDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnConfirmarRecepcion);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblNumeroDocumentoProveedor);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtNumeroDocumentoProveedor);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.txtTipoDocumento);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Name = "frmDetalleCompra";
            this.Text = "Detalle Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRecibida;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalleCompra;

        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNumeroDocumentoProveedor;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtMontoTotal;

        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNumeroDocumentoProveedor;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblEstado;

        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnConfirmarRecepcion;
    }
}
