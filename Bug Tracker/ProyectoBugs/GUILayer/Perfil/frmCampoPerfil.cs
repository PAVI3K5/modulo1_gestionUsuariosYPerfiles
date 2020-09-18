using BugTacker.Entities;
using ProyectoBugs.BusinessLayer;
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
        private PerfilService oPerfilService;

        public frmCampoPerfil()
        {
            InitializeComponent();

            oPerfilService = new PerfilService();
            
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
                        txtNombrePerfil.Location = new Point(111,56) ;
                        lvlNombre.Location = new Point(12,56);

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
            var oPerfil = new Perfil();
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        
                        oPerfil.Nombre = txtNombrePerfil.Text;

                        if (!String.IsNullOrEmpty(txtNombrePerfil.Text))
                        {
                            if (oPerfilService.CrearPerfil(oPerfil))
                            {
                                MessageBox.Show("Perfil insertado!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else {
                            MessageBox.Show("El Nombre de Perfil no debe estar vacío!");
                        }
                        break;
                    }

                case FormMode.actualizar:
                    {
                        break;
                    }

                case FormMode.eliminar:
                    {

                        oPerfil = oPerfilSelected;
                        if (MessageBox.Show("Seguro que desea eliminar el perfil seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            oPerfilService.borrarPerfil(oPerfil);
                            MessageBox.Show("Perfil eliminado!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar borrar el perfil!", "Error");
                        }
                    }
                        break;
                    }
            }
        }

        
    }


