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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGruposPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(309, 72);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(244, 21);
            this.cbUsuarios.TabIndex = 0;
            this.cbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cbUsuarios_SelectedIndexChanged);
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombrePermiso,
            this.colAsignadoPermiso});
            this.dgvPermisos.Location = new System.Drawing.Point(44, 139);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(244, 376);
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
            this.dgvGruposPermisos.Location = new System.Drawing.Point(571, 139);
            this.dgvGruposPermisos.Name = "dgvGruposPermisos";
            this.dgvGruposPermisos.Size = new System.Drawing.Size(243, 376);
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
            this.btnGuardar.Location = new System.Drawing.Point(385, 472);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 43);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestión de permisos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(355, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(85, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Permisos simples";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(601, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grupos de permisos";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 24);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(860, 522);
            this.label10.TabIndex = 97;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // frmPermisosSimples
            // 
            this.ClientSize = new System.Drawing.Size(922, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvGruposPermisos);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.cbUsuarios);
            this.Controls.Add(this.label10);
            this.Name = "frmPermisosSimples";
            this.Load += new System.EventHandler(this.frmPermisosSimples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGruposPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
    }
}
