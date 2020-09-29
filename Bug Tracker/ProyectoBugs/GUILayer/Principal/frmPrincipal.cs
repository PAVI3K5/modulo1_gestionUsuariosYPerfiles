using BugTacker.GUILayer;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoBugs.GUILayer.Princ

{
    public partial class frmPrincipalMenu : Form
    {
        //Campos
        private Button botonActual;
        private Random random;
        private int tempIndex;
        private Form frmActivo;

        //Constructor
        public frmPrincipalMenu()
        {
            InitializeComponent();
            random = new Random();
            btnBack.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Esto lo vi en internet y lo implementamos para poder desplazar el form desde el panel de arriba
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Metodos
        private Color SeleccionarColorDelTema()
        {
            int index = random.Next(ColorTemas.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ColorTemas.ColorList.Count);

            }
            tempIndex = index;
            string color = ColorTemas.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivarBoton(object btnSender)
        {
            if(btnSender != null)
            {
                if(botonActual != (Button)btnSender)
                {
                    btnBack.Visible = true;
                    DesactivarBoton();
                    Color color = SeleccionarColorDelTema();
                    botonActual = (Button)btnSender;
                    botonActual.BackColor = color;
                    botonActual.ForeColor = Color.White;
                    botonActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitulo.BackColor = color;
                    panelLogo.BackColor = ColorTemas.CambiarBrilloColor(color, -0.5);
                    ColorTemas.ColorPrimario = color;
                    ColorTemas.ColorSecundario = ColorTemas.CambiarBrilloColor(color, -0.5);
                }
            }
        }

        private void DesactivarBoton()
        {
            foreach(Control botonAnterior in panelMenu.Controls)
            {
                if(botonAnterior.GetType() == typeof(Button))
                {
                    botonAnterior.BackColor = Color.FromArgb(51, 51, 76);
                    botonAnterior.ForeColor = Color.Gainsboro;
                    botonAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        //Abrimos formularios directamente sobre la pantalla principal, creando como Formularios mas chicos
        private void AbrirFormulariosEnPanelPrincipal(Form frmChico, object btnSender)
        {
            if(frmActivo != null)
            {
                frmActivo.Close();
            }
            ActivarBoton(btnSender);
            frmActivo = frmChico;
            frmChico.TopLevel = false;
            frmChico.FormBorderStyle = FormBorderStyle.None;
            frmChico.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(frmChico);
            this.panelPrincipal.Tag = frmChico;
            frmChico.BringToFront();
            frmChico.Show();
            lblTitulo.Text = frmChico.Text;
        }

        //Abrimos los formularios a traves de los botones del menu
        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelPrincipal(new frmPerfiles(), sender);

        }

        private void btnFormularios_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            if (frmActivo != null)
            {
                frmActivo.Close();
            }

        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            if (frmActivo != null)
            {
                frmActivo.Close();
            }
        }

        //Para volver a la pantalla principal
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (frmActivo != null)
            {
                frmActivo.Close();
            }
            Reset();
        }

        private void Reset() //Se setean todos los valores originales
        {
            DesactivarBoton();
            lblTitulo.Text = "BUGTRACKER";
            panelTitulo.BackColor = Color.FromArgb(120, 140, 171);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            botonActual = null;
            btnBack.Visible = false;
        }

        //Mover por la pantalla
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Creamos la accion de salir, minimizar y maximizar
        private void btnSalir_Click(object sender, EventArgs e)
        {
            var mensaje = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (mensaje == DialogResult.OK)
                this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void frmPrincipalMenu_Load(object sender, EventArgs e)
        {
            frmLogin formularioLogin = new frmLogin();
            formularioLogin.ShowDialog();
            string usuarioActual = formularioLogin.UsuarioLogueado;
            lblUsuario.Text = usuarioActual;
        }
    }
}
