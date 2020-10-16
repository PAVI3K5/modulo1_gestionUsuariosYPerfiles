namespace ProyectoBugs.GUILayer
{
    partial class frmCampoFormulario
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
            this.lvlNombre = new System.Windows.Forms.Label();
            this.txtNombreFormulario = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.lvlCambioNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvlNombre
            // 
            this.lvlNombre.AutoSize = true;
            this.lvlNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lvlNombre.Location = new System.Drawing.Point(12, 28);
            this.lvlNombre.Name = "lvlNombre";
            this.lvlNombre.Size = new System.Drawing.Size(117, 15);
            this.lvlNombre.TabIndex = 0;
            this.lvlNombre.Text = "Nombre formulario: ";
            // 
            // txtNombreFormulario
            // 
            this.txtNombreFormulario.AccessibleDescription = "";
            this.txtNombreFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNombreFormulario.Location = new System.Drawing.Point(135, 25);
            this.txtNombreFormulario.MaxLength = 40;
            this.txtNombreFormulario.Name = "txtNombreFormulario";
            this.txtNombreFormulario.Size = new System.Drawing.Size(182, 21);
            this.txtNombreFormulario.TabIndex = 1;
            this.txtNombreFormulario.Tag = "";
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
            this.button1.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNuevoNombre.Location = new System.Drawing.Point(135, 68);
            this.txtNuevoNombre.MaxLength = 40;
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(182, 21);
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
            // frmCampoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 156);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.lvlCambioNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtNombreFormulario);
            this.Controls.Add(this.lvlNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(345, 195);
            this.MinimumSize = new System.Drawing.Size(345, 195);
            this.Name = "frmCampoFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmCampoFormulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlNombre;
        private System.Windows.Forms.TextBox txtNombreFormulario;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Label lvlCambioNombre;
    }
}