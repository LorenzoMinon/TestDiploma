namespace CapaPresentacion
{
    partial class frmPermisosSimples
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePermiso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AsignadoPermiso;

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
            this.NombrePermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsignadoPermiso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePermiso,
            this.AsignadoPermiso});
            this.dgvPermisos.Location = new System.Drawing.Point(12, 12);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(360, 200);
            this.dgvPermisos.TabIndex = 0;
            // 
            // NombrePermiso
            // 
            this.NombrePermiso.HeaderText = "Nombre del Permiso";
            this.NombrePermiso.Name = "NombrePermiso";
            this.NombrePermiso.ReadOnly = true;
            this.NombrePermiso.Width = 200;
            // 
            // AsignadoPermiso
            // 
            this.AsignadoPermiso.HeaderText = "Asignado";
            this.AsignadoPermiso.Name = "AsignadoPermiso";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(297, 218);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmPermisosSimples
            // 
            this.ClientSize = new System.Drawing.Size(965, 446);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvPermisos);
            this.Name = "frmPermisosSimples";
            this.Text = "Gestión de Permisos Simples";
            this.Load += new System.EventHandler(this.frmPermisosSimples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
