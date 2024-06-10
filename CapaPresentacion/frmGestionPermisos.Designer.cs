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
            this.SuspendLayout();
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(137, 22);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 22);
            this.txtDocumento.TabIndex = 0;
            // 
            // txtIdPermiso
            // 
            this.txtIdPermiso.Location = new System.Drawing.Point(137, 62);
            this.txtIdPermiso.Name = "txtIdPermiso";
            this.txtIdPermiso.Size = new System.Drawing.Size(100, 22);
            this.txtIdPermiso.TabIndex = 1;
            // 
            // txtIdGrupoPermiso
            // 
            this.txtIdGrupoPermiso.Location = new System.Drawing.Point(137, 102);
            this.txtIdGrupoPermiso.Name = "txtIdGrupoPermiso";
            this.txtIdGrupoPermiso.Size = new System.Drawing.Size(100, 22);
            this.txtIdGrupoPermiso.TabIndex = 2;
            // 
            // btnAsignarPermiso
            // 
            this.btnAsignarPermiso.Location = new System.Drawing.Point(263, 22);
            this.btnAsignarPermiso.Name = "btnAsignarPermiso";
            this.btnAsignarPermiso.Size = new System.Drawing.Size(135, 23);
            this.btnAsignarPermiso.TabIndex = 3;
            this.btnAsignarPermiso.Text = "Asignar Permiso";
            this.btnAsignarPermiso.UseVisualStyleBackColor = true;
            this.btnAsignarPermiso.Click += new System.EventHandler(this.btnAsignarPermiso_Click);
            // 
            // btnAsignarGrupoPermiso
            // 
            this.btnAsignarGrupoPermiso.Location = new System.Drawing.Point(263, 62);
            this.btnAsignarGrupoPermiso.Name = "btnAsignarGrupoPermiso";
            this.btnAsignarGrupoPermiso.Size = new System.Drawing.Size(135, 23);
            this.btnAsignarGrupoPermiso.TabIndex = 4;
            this.btnAsignarGrupoPermiso.Text = "Asignar Grupo";
            this.btnAsignarGrupoPermiso.UseVisualStyleBackColor = true;
            this.btnAsignarGrupoPermiso.Click += new System.EventHandler(this.btnAsignarGrupoPermiso_Click);
            // 
            // btnVerPermisos
            // 
            this.btnVerPermisos.Location = new System.Drawing.Point(263, 102);
            this.btnVerPermisos.Name = "btnVerPermisos";
            this.btnVerPermisos.Size = new System.Drawing.Size(135, 23);
            this.btnVerPermisos.TabIndex = 5;
            this.btnVerPermisos.Text = "Ver Permisos";
            this.btnVerPermisos.UseVisualStyleBackColor = true;
            this.btnVerPermisos.Click += new System.EventHandler(this.btnVerPermisos_Click);
            // 
            // btnVerGruposPermisos
            // 
            this.btnVerGruposPermisos.Location = new System.Drawing.Point(263, 142);
            this.btnVerGruposPermisos.Name = "btnVerGruposPermisos";
            this.btnVerGruposPermisos.Size = new System.Drawing.Size(135, 23);
            this.btnVerGruposPermisos.TabIndex = 6;
            this.btnVerGruposPermisos.Text = "Ver Grupos";
            this.btnVerGruposPermisos.UseVisualStyleBackColor = true;
            this.btnVerGruposPermisos.Click += new System.EventHandler(this.btnVerGruposPermisos_Click);
            // 
            // lstPermisos
            // 
            this.lstPermisos.FormattingEnabled = true;
            this.lstPermisos.ItemHeight = 16;
            this.lstPermisos.Location = new System.Drawing.Point(24, 182);
            this.lstPermisos.Name = "lstPermisos";
            this.lstPermisos.Size = new System.Drawing.Size(374, 180);
            this.lstPermisos.TabIndex = 7;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(21, 25);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(78, 16);
            this.lblDocumento.TabIndex = 8;
            this.lblDocumento.Text = "Documento";
            // 
            // lblIdPermiso
            // 
            this.lblIdPermiso.AutoSize = true;
            this.lblIdPermiso.Location = new System.Drawing.Point(21, 65);
            this.lblIdPermiso.Name = "lblIdPermiso";
            this.lblIdPermiso.Size = new System.Drawing.Size(68, 16);
            this.lblIdPermiso.TabIndex = 9;
            this.lblIdPermiso.Text = "ID Permiso";
            // 
            // lblIdGrupoPermiso
            // 
            this.lblIdGrupoPermiso.AutoSize = true;
            this.lblIdGrupoPermiso.Location = new System.Drawing.Point(21, 105);
            this.lblIdGrupoPermiso.Name = "lblIdGrupoPermiso";
            this.lblIdGrupoPermiso.Size = new System.Drawing.Size(111, 16);
            this.lblIdGrupoPermiso.TabIndex = 10;
            this.lblIdGrupoPermiso.Text = "ID Grupo Permiso";
            // 
            // frmGestionPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 380);
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
            this.Name = "frmGestionPermisos";
            this.Text = "Gestión de Permisos";
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
    }
}
