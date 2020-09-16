namespace ProyectoBugs.GUILayer
{
    partial class frmCampoPerfil
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePerfil = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.lvlCambioNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre perfil: ";
            // 
            // txtNombrePerfil
            // 
            this.txtNombrePerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNombrePerfil.Location = new System.Drawing.Point(111, 22);
            this.txtNombrePerfil.Name = "txtNombrePerfil";
            this.txtNombrePerfil.Size = new System.Drawing.Size(206, 21);
            this.txtNombrePerfil.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnConfirmar.Location = new System.Drawing.Point(111, 121);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(85, 23);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(232, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNuevoNombre.Location = new System.Drawing.Point(111, 68);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(206, 21);
            this.txtNuevoNombre.TabIndex = 5;
            this.txtNuevoNombre.Visible = false;
            // 
            // lvlCambioNombre
            // 
            this.lvlCambioNombre.AutoSize = true;
            this.lvlCambioNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lvlCambioNombre.Location = new System.Drawing.Point(12, 71);
            this.lvlCambioNombre.Name = "lvlCambioNombre";
            this.lvlCambioNombre.Size = new System.Drawing.Size(91, 15);
            this.lvlCambioNombre.TabIndex = 4;
            this.lvlCambioNombre.Text = "Nuevo nombre:";
            this.lvlCambioNombre.Visible = false;
            // 
            // frmCampoPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 156);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.lvlCambioNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtNombrePerfil);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCampoPerfil";
            this.Load += new System.EventHandler(this.frmCampoPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePerfil;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Label lvlCambioNombre;
    }
}