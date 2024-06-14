namespace CapaPresentacion
{
    partial class frmPermisosSimples
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAsignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombrePermiso;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.colAsignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTipoPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombrePermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(12, 25);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(360, 21);
            this.cbUsuarios.TabIndex = 0;
            this.cbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cbUsuarios_SelectedIndexChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAsignado,
            this.colTipoPermiso,
            this.colNombrePermiso});
            this.dgvPermisos.Location = new System.Drawing.Point(12, 52);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(360, 150);
            this.dgvPermisos.TabIndex = 2;
            // 
            // colAsignado
            // 
            this.colAsignado.HeaderText = "Asignado";
            this.colAsignado.Name = "colAsignado";
            this.colAsignado.Width = 50;
            // 
            // colTipoPermiso
            // 
            this.colTipoPermiso.HeaderText = "Tipo";
            this.colTipoPermiso.Name = "colTipoPermiso";
            this.colTipoPermiso.ReadOnly = true;
            // 
            // colNombrePermiso
            // 
            this.colNombrePermiso.HeaderText = "Nombre";
            this.colNombrePermiso.Name = "colNombrePermiso";
            this.colNombrePermiso.ReadOnly = true;
            this.colNombrePermiso.Width = 200;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(297, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmPermisosSimples
            // 
            this.ClientSize = new System.Drawing.Size(384, 243);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cbUsuarios);
            this.Name = "frmPermisosSimples";
            this.Text = "Permisos Simples";
            this.Load += new System.EventHandler(this.frmPermisosSimples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
