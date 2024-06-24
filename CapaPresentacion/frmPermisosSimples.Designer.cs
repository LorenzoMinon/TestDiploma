namespace CapaPresentacion
{
    partial class frmPermisosSimples
    {
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.DataGridView dgvGruposPermisos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAsignadoPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombrePermiso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAsignadoGrupoPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreGrupoPermiso;

        private void InitializeComponent()
        {
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.colAsignadoPermiso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNombrePermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGruposPermisos = new System.Windows.Forms.DataGridView();
            this.colAsignadoGrupoPermiso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNombreGrupoPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cbUsuarios.Size = new System.Drawing.Size(360, 24);
            this.cbUsuarios.TabIndex = 0;
            this.cbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cbUsuarios_SelectedIndexChanged);

            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.AllowUserToDeleteRows = false;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAsignadoPermiso,
            this.colNombrePermiso});
            this.dgvPermisos.Location = new System.Drawing.Point(12, 42);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.RowTemplate.Height = 24;
            this.dgvPermisos.Size = new System.Drawing.Size(360, 396);
            this.dgvPermisos.TabIndex = 1;
            this.dgvPermisos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisos_CellValueChanged);

            // 
            // colAsignadoPermiso
            // 
            this.colAsignadoPermiso.HeaderText = "Asignado";
            this.colAsignadoPermiso.Name = "colAsignadoPermiso";

            // 
            // colNombrePermiso
            // 
            this.colNombrePermiso.HeaderText = "Nombre";
            this.colNombrePermiso.Name = "colNombrePermiso";
            this.colNombrePermiso.ReadOnly = true;

            // 
            // dgvGruposPermisos
            // 
            this.dgvGruposPermisos.AllowUserToAddRows = false;
            this.dgvGruposPermisos.AllowUserToDeleteRows = false;
            this.dgvGruposPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGruposPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAsignadoGrupoPermiso,
            this.colNombreGrupoPermiso});
            this.dgvGruposPermisos.Location = new System.Drawing.Point(400, 42);
            this.dgvGruposPermisos.Name = "dgvGruposPermisos";
            this.dgvGruposPermisos.RowTemplate.Height = 24;
            this.dgvGruposPermisos.Size = new System.Drawing.Size(360, 396);
            this.dgvGruposPermisos.TabIndex = 2;
            this.dgvGruposPermisos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGruposPermisos_CellValueChanged);

            // 
            // colAsignadoGrupoPermiso
            // 
            this.colAsignadoGrupoPermiso.HeaderText = "Asignado";
            this.colAsignadoGrupoPermiso.Name = "colAsignadoGrupoPermiso";

            // 
            // colNombreGrupoPermiso
            // 
            this.colNombreGrupoPermiso.HeaderText = "Nombre";
            this.colNombreGrupoPermiso.Name = "colNombreGrupoPermiso";
            this.colNombreGrupoPermiso.ReadOnly = true;

            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(685, 444);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // 
            // frmPermisosSimples
            // 
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvGruposPermisos);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.cbUsuarios);
            this.Name = "frmPermisosSimples";
            this.Text = "Gestión de Permisos Simples";
            this.Load += new System.EventHandler(this.frmPermisosSimples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGruposPermisos)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
