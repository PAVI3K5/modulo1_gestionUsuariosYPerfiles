namespace ProyectoBugs.GUILayer.Formularios
{
    partial class frmPermisos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermisos));
            this.cmbPerfiles = new System.Windows.Forms.ComboBox();
            this.dgvFormularios = new System.Windows.Forms.DataGridView();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPerfilesUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormularios)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfilesUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPerfiles
            // 
            this.cmbPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbPerfiles.FormattingEnabled = true;
            this.cmbPerfiles.Location = new System.Drawing.Point(137, 39);
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.Size = new System.Drawing.Size(243, 28);
            this.cmbPerfiles.TabIndex = 1;
            this.cmbPerfiles.SelectionChangeCommitted += new System.EventHandler(this.cmbPerfiles_SelectionChangeCommitted);
            // 
            // dgvFormularios
            // 
            this.dgvFormularios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormularios.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvFormularios.Location = new System.Drawing.Point(302, 100);
            this.dgvFormularios.Name = "dgvFormularios";
            this.dgvFormularios.Size = new System.Drawing.Size(290, 354);
            this.dgvFormularios.TabIndex = 1;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPerfil.Location = new System.Drawing.Point(72, 42);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(48, 20);
            this.lblPerfil.TabIndex = 5;
            this.lblPerfil.Text = "Perfil:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(592, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 354);
            this.panel2.TabIndex = 6;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(17, 165);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(72, 68);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditar.Location = new System.Drawing.Point(19, 185);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(70, 73);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(19, 271);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(70, 71);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPerfil);
            this.panel3.Controls.Add(this.cmbPerfiles);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(697, 100);
            this.panel3.TabIndex = 11;
            // 
            // dgvPerfilesUsuario
            // 
            this.dgvPerfilesUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfilesUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvPerfilesUsuario.Location = new System.Drawing.Point(12, 100);
            this.dgvPerfilesUsuario.Name = "dgvPerfilesUsuario";
            this.dgvPerfilesUsuario.Size = new System.Drawing.Size(290, 354);
            this.dgvPerfilesUsuario.TabIndex = 12;
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 454);
            this.Controls.Add(this.dgvPerfilesUsuario);
            this.Controls.Add(this.dgvFormularios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "frmPermisos";
            this.Load += new System.EventHandler(this.frmFormularios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormularios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfilesUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPerfiles;
        private System.Windows.Forms.DataGridView dgvFormularios;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvPerfilesUsuario;
    }
}