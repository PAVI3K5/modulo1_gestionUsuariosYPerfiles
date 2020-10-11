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
            this.cmbPerfiles = new System.Windows.Forms.ComboBox();
            this.dgvFormularios = new System.Windows.Forms.DataGridView();
            this.lblPerfil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormularios)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPerfiles
            // 
            this.cmbPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbPerfiles.FormattingEnabled = true;
            this.cmbPerfiles.Location = new System.Drawing.Point(66, 19);
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.Size = new System.Drawing.Size(243, 28);
            this.cmbPerfiles.TabIndex = 1;
            this.cmbPerfiles.DropDown += new System.EventHandler(this.cmbPerfiles_DropDown);
            this.cmbPerfiles.SelectionChangeCommitted += new System.EventHandler(this.cmbPerfiles_SelectionChangeCommitted);
            // 
            // dgvFormularios
            // 
            this.dgvFormularios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormularios.Location = new System.Drawing.Point(16, 69);
            this.dgvFormularios.Name = "dgvFormularios";
            this.dgvFormularios.Size = new System.Drawing.Size(293, 150);
            this.dgvFormularios.TabIndex = 1;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPerfil.Location = new System.Drawing.Point(12, 19);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(48, 20);
            this.lblPerfil.TabIndex = 5;
            this.lblPerfil.Text = "Perfil:";
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 271);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.dgvFormularios);
            this.Controls.Add(this.cmbPerfiles);
            this.Name = "frmPermisos";
            this.Load += new System.EventHandler(this.frmFormularios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormularios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPerfiles;
        private System.Windows.Forms.DataGridView dgvFormularios;
        private System.Windows.Forms.Label lblPerfil;
    }
}