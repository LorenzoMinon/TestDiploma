namespace CapaPresentacion
{
    partial class frmPermisosSimples
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.colNombrePermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsignadoPermiso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvGruposPermisos = new System.Windows.Forms.DataGridView();
            this.colNombreGrupoPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsignadoGrupoPermiso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGruposPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(12, 12);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(260, 21);
            this.cbUsuarios.TabIndex = 0;
            this.cbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cbUsuarios_SelectedIndexChanged);
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombrePermiso,
            this.colAsignadoPermiso});
            this.dgvPermisos.Location = new System.Drawing.Point(12, 50);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(360, 150);
            this.dgvPermisos.TabIndex = 1;
            this.dgvPermisos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisos_CellValueChanged);
            // 
            // colNombrePermiso
            // 
            this.colNombrePermiso.HeaderText = "Nombre Permiso";
            this.colNombrePermiso.Name = "colNombrePermiso";
            // 
            // colAsignadoPermiso
            // 
            this.colAsignadoPermiso.HeaderText = "Asignado";
            this.colAsignadoPermiso.Name = "colAsignadoPermiso";
            // 
            // dgvGruposPermisos
            // 
            this.dgvGruposPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGruposPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreGrupoPermiso,
            this.colAsignadoGrupoPermiso});
            this.dgvGruposPermisos.Location = new System.Drawing.Point(12, 220);
            this.dgvGruposPermisos.Name = "dgvGruposPermisos";
            this.dgvGruposPermisos.Size = new System.Drawing.Size(360, 150);
            this.dgvGruposPermisos.TabIndex = 2;
            this.dgvGruposPermisos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGruposPermisos_CellValueChanged);
            // 
            // colNombreGrupoPermiso
            // 
            this.colNombreGrupoPermiso.HeaderText = "Nombre Grupo Permiso";
            this.colNombreGrupoPermiso.Name = "colNombreGrupoPermiso";
            // 
            // colAsignadoGrupoPermiso
            // 
            this.colAsignadoGrupoPermiso.HeaderText = "Asignado";
            this.colAsignadoGrupoPermiso.Name = "colAsignadoGrupoPermiso";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(297, 390);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmPermisosSimples
            // 
            this.ClientSize = new System.Drawing.Size(384, 431);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvGruposPermisos);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.cbUsuarios);
            this.Name = "frmPermisosSimples";
            this.Load += new System.EventHandler(this.frmPermisosSimples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGruposPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombrePermiso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAsignadoPermiso;
        private System.Windows.Forms.DataGridView dgvGruposPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreGrupoPermiso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAsignadoGrupoPermiso;
        private System.Windows.Forms.Button btnGuardar;
    }
}
