namespace ProyectoBugs.GUILayer.Princ
{
    partial class frmPrincipalMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPermisos = new System.Windows.Forms.Button();
            this.btnFormularios = new System.Windows.Forms.Button();
            this.btnPerfiles = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.lblUsuario);
            this.panelMenu.Controls.Add(this.btnPermisos);
            this.panelMenu.Controls.Add(this.btnFormularios);
            this.panelMenu.Controls.Add(this.btnPerfiles);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 573);
            this.panelMenu.TabIndex = 0;
            // 
            // btnPermisos
            // 
            this.btnPermisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPermisos.FlatAppearance.BorderSize = 0;
            this.btnPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermisos.Image = ((System.Drawing.Image)(resources.GetObject("btnPermisos.Image")));
            this.btnPermisos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermisos.Location = new System.Drawing.Point(0, 200);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPermisos.Size = new System.Drawing.Size(220, 60);
            this.btnPermisos.TabIndex = 3;
            this.btnPermisos.Text = "   Permisos";
            this.btnPermisos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPermisos.UseVisualStyleBackColor = true;
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnFormularios
            // 
            this.btnFormularios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormularios.FlatAppearance.BorderSize = 0;
            this.btnFormularios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormularios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormularios.Image = ((System.Drawing.Image)(resources.GetObject("btnFormularios.Image")));
            this.btnFormularios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormularios.Location = new System.Drawing.Point(0, 140);
            this.btnFormularios.Name = "btnFormularios";
            this.btnFormularios.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFormularios.Size = new System.Drawing.Size(220, 60);
            this.btnFormularios.TabIndex = 2;
            this.btnFormularios.Text = "   Formularios";
            this.btnFormularios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormularios.UseVisualStyleBackColor = true;
            this.btnFormularios.Click += new System.EventHandler(this.btnFormularios_Click);
            // 
            // btnPerfiles
            // 
            this.btnPerfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfiles.FlatAppearance.BorderSize = 0;
            this.btnPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfiles.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfiles.Image")));
            this.btnPerfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfiles.Location = new System.Drawing.Point(0, 80);
            this.btnPerfiles.Name = "btnPerfiles";
            this.btnPerfiles.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPerfiles.Size = new System.Drawing.Size(220, 60);
            this.btnPerfiles.TabIndex = 1;
            this.btnPerfiles.Text = "   Perfiles";
            this.btnPerfiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerfiles.UseVisualStyleBackColor = true;
            this.btnPerfiles.Click += new System.EventHandler(this.btnPerfiles_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.Image = ((System.Drawing.Image)(resources.GetObject("lblLogo.Image")));
            this.lblLogo.Location = new System.Drawing.Point(43, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(121, 51);
            this.lblLogo.TabIndex = 0;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnMaximizar);
            this.panelTitulo.Controls.Add(this.btnSalir);
            this.panelTitulo.Controls.Add(this.btnBack);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(713, 80);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(614, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.Text = "○";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Location = new System.Drawing.Point(648, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(28, 28);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.Text = "○";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(682, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(28, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "○";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 80);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitulo.Location = new System.Drawing.Point(293, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(149, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BUG TRACKER";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(220, 80);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(713, 493);
            this.panelPrincipal.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(0, 553);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(220, 20);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 573);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmPrincipalMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPrincipalMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPerfiles;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnPermisos;
        private System.Windows.Forms.Button btnFormularios;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Label lblUsuario;
    }
}