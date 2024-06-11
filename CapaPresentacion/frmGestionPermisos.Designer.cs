namespace CapaPresentacion
{
    partial class frmGestionPermisos
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
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtIdPermiso = new System.Windows.Forms.TextBox();
            this.txtIdGrupoPermiso = new System.Windows.Forms.TextBox();
            this.btnAsignarPermiso = new System.Windows.Forms.Button();
            this.btnAsignarGrupoPermiso = new System.Windows.Forms.Button();
            this.btnVerPermisos = new System.Windows.Forms.Button();
            this.btnVerGruposPermisos = new System.Windows.Forms.Button();
            this.lstPermisos = new System.Windows.Forms.ListBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblIdPermiso = new System.Windows.Forms.Label();
            this.lblIdGrupoPermiso = new System.Windows.Forms.Label();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.IdPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(103, 18);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(76, 20);
            this.txtDocumento.TabIndex = 0;
            // 
            // txtIdPermiso
            // 
            this.txtIdPermiso.Location = new System.Drawing.Point(103, 50);
            this.txtIdPermiso.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdPermiso.Name = "txtIdPermiso";
            this.txtIdPermiso.Size = new System.Drawing.Size(76, 20);
            this.txtIdPermiso.TabIndex = 1;
            // 
            // txtIdGrupoPermiso
            // 
            this.txtIdGrupoPermiso.Location = new System.Drawing.Point(103, 83);
            this.txtIdGrupoPermiso.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdGrupoPermiso.Name = "txtIdGrupoPermiso";
            this.txtIdGrupoPermiso.Size = new System.Drawing.Size(76, 20);
            this.txtIdGrupoPermiso.TabIndex = 2;
            // 
            // btnAsignarPermiso
            // 
            this.btnAsignarPermiso.Location = new System.Drawing.Point(197, 18);
            this.btnAsignarPermiso.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignarPermiso.Name = "btnAsignarPermiso";
            this.btnAsignarPermiso.Size = new System.Drawing.Size(101, 19);
            this.btnAsignarPermiso.TabIndex = 3;
            this.btnAsignarPermiso.Text = "Asignar Permiso";
            this.btnAsignarPermiso.UseVisualStyleBackColor = true;
            //this.btnAsignarPermiso.Click += new System.EventHandler(this.btnAsignarPermiso_Click);
            // 
            // btnAsignarGrupoPermiso
            // 
            this.btnAsignarGrupoPermiso.Location = new System.Drawing.Point(197, 50);
            this.btnAsignarGrupoPermiso.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignarGrupoPermiso.Name = "btnAsignarGrupoPermiso";
            this.btnAsignarGrupoPermiso.Size = new System.Drawing.Size(101, 19);
            this.btnAsignarGrupoPermiso.TabIndex = 4;
            this.btnAsignarGrupoPermiso.Text = "Asignar Grupo";
            this.btnAsignarGrupoPermiso.UseVisualStyleBackColor = true;
            //this.btnAsignarGrupoPermiso.Click += new System.EventHandler(this.btnAsignarGrupoPermiso_Click);
            // 
            // btnVerPermisos
            // 
            this.btnVerPermisos.Location = new System.Drawing.Point(197, 83);
            this.btnVerPermisos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerPermisos.Name = "btnVerPermisos";
            this.btnVerPermisos.Size = new System.Drawing.Size(101, 19);
            this.btnVerPermisos.TabIndex = 5;
            this.btnVerPermisos.Text = "Ver Permisos";
            this.btnVerPermisos.UseVisualStyleBackColor = true;
            this.btnVerPermisos.Click += new System.EventHandler(this.btnVerPermisos_Click);
            // 
            // btnVerGruposPermisos
            // 
            this.btnVerGruposPermisos.Location = new System.Drawing.Point(197, 115);
            this.btnVerGruposPermisos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerGruposPermisos.Name = "btnVerGruposPermisos";
            this.btnVerGruposPermisos.Size = new System.Drawing.Size(101, 19);
            this.btnVerGruposPermisos.TabIndex = 6;
            this.btnVerGruposPermisos.Text = "Ver Grupos";
            this.btnVerGruposPermisos.UseVisualStyleBackColor = true;
            //this.btnVerGruposPermisos.Click += new System.EventHandler(this.btnVerGruposPermisos_Click);
            // 
            // lstPermisos
            // 
            this.lstPermisos.FormattingEnabled = true;
            this.lstPermisos.Location = new System.Drawing.Point(18, 148);
            this.lstPermisos.Margin = new System.Windows.Forms.Padding(2);
            this.lstPermisos.Name = "lstPermisos";
            this.lstPermisos.Size = new System.Drawing.Size(282, 147);
            this.lstPermisos.TabIndex = 7;
            this.lstPermisos.SelectedIndexChanged += new System.EventHandler(this.lstPermisos_SelectedIndexChanged);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(16, 20);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 8;
            this.lblDocumento.Text = "Documento";
            // 
            // lblIdPermiso
            // 
            this.lblIdPermiso.AutoSize = true;
            this.lblIdPermiso.Location = new System.Drawing.Point(16, 53);
            this.lblIdPermiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPermiso.Name = "lblIdPermiso";
            this.lblIdPermiso.Size = new System.Drawing.Size(58, 13);
            this.lblIdPermiso.TabIndex = 9;
            this.lblIdPermiso.Text = "ID Permiso";
            // 
            // lblIdGrupoPermiso
            // 
            this.lblIdGrupoPermiso.AutoSize = true;
            this.lblIdGrupoPermiso.Location = new System.Drawing.Point(16, 85);
            this.lblIdGrupoPermiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdGrupoPermiso.Name = "lblIdGrupoPermiso";
            this.lblIdGrupoPermiso.Size = new System.Drawing.Size(90, 13);
            this.lblIdGrupoPermiso.TabIndex = 10;
            this.lblIdGrupoPermiso.Text = "ID Grupo Permiso";
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPermiso,
            this.Nombre});
            this.dgvPermisos.Location = new System.Drawing.Point(396, 181);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(240, 150);
            this.dgvPermisos.TabIndex = 11;
            // 
            // IdPermiso
            // 
            this.IdPermiso.HeaderText = "Permiso";
            this.IdPermiso.Name = "IdPermiso";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre de permiso";
            this.Nombre.Name = "Nombre";
            // 
            // frmGestionPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 501);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.lblIdGrupoPermiso);
            this.Controls.Add(this.lblIdPermiso);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lstPermisos);
            this.Controls.Add(this.btnVerGruposPermisos);
            this.Controls.Add(this.btnVerPermisos);
            this.Controls.Add(this.btnAsignarGrupoPermiso);
            this.Controls.Add(this.btnAsignarPermiso);
            this.Controls.Add(this.txtIdGrupoPermiso);
            this.Controls.Add(this.txtIdPermiso);
            this.Controls.Add(this.txtDocumento);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGestionPermisos";
            this.Text = "Gestión de Permisos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtIdPermiso;
        private System.Windows.Forms.TextBox txtIdGrupoPermiso;
        private System.Windows.Forms.Button btnAsignarPermiso;
        private System.Windows.Forms.Button btnAsignarGrupoPermiso;
        private System.Windows.Forms.Button btnVerPermisos;
        private System.Windows.Forms.Button btnVerGruposPermisos;
        private System.Windows.Forms.ListBox lstPermisos;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblIdPermiso;
        private System.Windows.Forms.Label lblIdGrupoPermiso;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}
