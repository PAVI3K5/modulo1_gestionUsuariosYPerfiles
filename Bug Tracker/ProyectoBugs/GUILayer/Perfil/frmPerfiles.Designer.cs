namespace ProyectoBugs.GUILayer
{
    partial class frmPerfiles
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
            this.dgvPerfiles = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPerfiles
            // 
            this.dgvPerfiles.AllowUserToAddRows = false;
            this.dgvPerfiles.AllowUserToDeleteRows = false;
            this.dgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfiles.Location = new System.Drawing.Point(12, 31);
            this.dgvPerfiles.Name = "dgvPerfiles";
            this.dgvPerfiles.ReadOnly = true;
            this.dgvPerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerfiles.Size = new System.Drawing.Size(345, 131);
            this.dgvPerfiles.TabIndex = 0;
            this.dgvPerfiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerfiles_CellContentClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNuevo.Location = new System.Drawing.Point(0, 161);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(64, 24);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditar.Location = new System.Drawing.Point(80, 161);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 24);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnEliminar.Location = new System.Drawing.Point(160, 161);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(64, 24);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnVolver.Location = new System.Drawing.Point(275, 161);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(64, 24);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.BtnEliminar);
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 191);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfiles";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 216);
            this.Controls.Add(this.dgvPerfiles);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(385, 255);
            this.MinimumSize = new System.Drawing.Size(385, 255);
            this.Name = "frmPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Perfiles";
            this.Load += new System.EventHandler(this.frmPerfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerfiles;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}