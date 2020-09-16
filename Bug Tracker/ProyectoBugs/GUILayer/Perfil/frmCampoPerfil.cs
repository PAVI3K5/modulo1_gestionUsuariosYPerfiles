using BugTacker.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBugs.GUILayer
{
    public partial class frmCampoPerfil : Form
    {
        private FormMode formMode = FormMode.nuevo;
        private Perfil oPerfilSelected;

        public frmCampoPerfil()
        {
            InitializeComponent();
        }

        public enum FormMode
        {
            nuevo,
            actualizar,
            eliminar = 99
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void frmCampoPerfil_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Nuevo Usuario";
                        break;
                    }

                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar Usuario";
                        MostrarDatos();
                        txtNombrePerfil.Enabled = false;
                        lvlCambioNombre.Visible = true;
                        txtNuevoNombre.Visible = true;
                        break;
                    }

                case FormMode.eliminar:
                    {
                        this.Text = "Eliminar Usuario";
                        MostrarDatos();
                        txtNombrePerfil.Enabled = false;
                        break;
                    }
            }
        }

        public void InicializarFormulario(FormMode op, Perfil perfilSelected)
        {
            formMode = op;
            oPerfilSelected = perfilSelected;
        }

        private void MostrarDatos()
        {
            if (oPerfilSelected != null)
            {
                txtNombrePerfil.Text = oPerfilSelected.Nombre;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {

                        break;
                    }

                case FormMode.actualizar:
                    {
                        break;
                    }

                case FormMode.eliminar:
                    {
                        break;
                    }
            }
        }
    }
}
