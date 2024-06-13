namespace CapaPresentacion.Modales
{
    partial class mdAsignarPermisos
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
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Asignado});
            this.dgvPermisos.Location = new System.Drawing.Point(12, 12);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(360, 200);
            this.dgvPermisos.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(297, 218);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del Permiso";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Asignado
            // 
            this.Asignado.HeaderText = "Asignado";
            this.Asignado.Name = "Asignado";
            // 
            // mdAsignarPermisos
            // 
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvPermisos);
            this.Name = "mdAsignarPermisos";
            this.Text = "Asignar Permisos";
            this.Load += new System.EventHandler(this.mdAsignarPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asignado;
    }
}
