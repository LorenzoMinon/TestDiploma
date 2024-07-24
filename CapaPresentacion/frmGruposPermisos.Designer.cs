namespace CapaPresentacion
{
    partial class frmGruposPermisos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvGruposPermisos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdGrupoPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreGrupo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccionar;

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
            this.dgvGruposPermisos = new System.Windows.Forms.DataGridView();
            this.colIdGrupoPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGruposPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGruposPermisos
            // 
            this.dgvGruposPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGruposPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdGrupoPermiso,
            this.colNombreGrupo,
            this.colSeleccionar});
            this.dgvGruposPermisos.Location = new System.Drawing.Point(12, 12);
            this.dgvGruposPermisos.Name = "dgvGruposPermisos";
            this.dgvGruposPermisos.Size = new System.Drawing.Size(360, 342);
            this.dgvGruposPermisos.TabIndex = 0;
            // 
            // colIdGrupoPermiso
            // 
            this.colIdGrupoPermiso.HeaderText = "ID";
            this.colIdGrupoPermiso.Name = "colIdGrupoPermiso";
            this.colIdGrupoPermiso.Visible = false;
            // 
            // colNombreGrupo
            // 
            this.colNombreGrupo.HeaderText = "Nombre del Grupo";
            this.colNombreGrupo.Name = "colNombreGrupo";
            this.colNombreGrupo.ReadOnly = true;
            this.colNombreGrupo.Width = 200;
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.HeaderText = "Seleccionar";
            this.colSeleccionar.Name = "colSeleccionar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(63, 372);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(144, 372);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(225, 372);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmGruposPermisos
            // 
            this.ClientSize = new System.Drawing.Size(551, 506);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvGruposPermisos);
            this.Name = "frmGruposPermisos";
            this.Text = "Gestión de Grupos de Permisos";
            this.Load += new System.EventHandler(this.frmGruposPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGruposPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
