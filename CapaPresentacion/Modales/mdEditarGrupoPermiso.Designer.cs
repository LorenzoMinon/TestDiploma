namespace CapaPresentacion.Modales
{
    partial class mdEditarGrupoPermiso
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAsignado;
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
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.colAsignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNombrePermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAsignado,
            this.colNombrePermiso});
            this.dgvPermisos.Location = new System.Drawing.Point(12, 42);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(360, 150);
            this.dgvPermisos.TabIndex = 0;
            // 
            // colAsignado
            // 
            this.colAsignado.HeaderText = "Asignado";
            this.colAsignado.Name = "colAsignado";
            this.colAsignado.Width = 50;
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
            this.btnGuardar.Location = new System.Drawing.Point(297, 198);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(110, 12);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(262, 20);
            this.txtNombreGrupo.TabIndex = 2;
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Location = new System.Drawing.Point(12, 15);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(92, 13);
            this.lblNombreGrupo.TabIndex = 3;
            this.lblNombreGrupo.Text = "Nombre del Grupo";
            // 
            // mdEditarGrupoPermiso
            // 
            this.ClientSize = new System.Drawing.Size(384, 233);
            this.Controls.Add(this.lblNombreGrupo);
            this.Controls.Add(this.txtNombreGrupo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvPermisos);
            this.Name = "mdEditarGrupoPermiso";
            this.Text = "Editar Grupo de Permisos";
            this.Load += new System.EventHandler(this.mdEditarGrupoPermiso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
