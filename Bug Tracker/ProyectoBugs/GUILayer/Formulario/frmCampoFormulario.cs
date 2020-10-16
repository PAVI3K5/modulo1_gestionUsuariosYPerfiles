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
    public partial class frmCampoFormulario : Form
    {
        private FormMode formMode = FormMode.nuevo;
        
        private Formulario oFormularioSelected;
        private FormularioService oFormularioService;

        public frmCampoFormulario()
        {
            InitializeComponent();

            oFormularioService = new FormularioService();
            
        }

        public enum FormMode
        {
            nuevo,
            actualizar,
            eliminar = 99
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmCampoFormulario_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Nuevo Formulario";
                        txtNombreFormulario.Location = new Point(111,56) ;
                        lvlNombre.Location = new Point(12,56);

                        break;
                    }

                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar Formulario";
                        MostrarDatos();
                        txtNombreFormulario.Enabled = false;
                        lvlCambioNombre.Visible = true;
                        txtNuevoNombre.Visible = true;
                        break;
                    }

                case FormMode.eliminar:
                    {
                        this.Text = "Eliminar Formulario";
                        MostrarDatos();
                        txtNombreFormulario.Enabled = false;
                        break;
                    }
            }
        }

        public void InicializarFormulario(FormMode op, Formulario formularioSelected)
        {
            formMode = op;
            oFormularioSelected = formularioSelected;
        }

        private void MostrarDatos()
        {
            if (oFormularioSelected != null)
            {
                txtNombreFormulario.Text = oFormularioSelected.Nombre;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var oFormulario = new Formulario();
            switch (formMode)
            {
                case FormMode.nuevo:
                    {

                        oFormulario.Nombre = txtNombreFormulario.Text;

                        if (!String.IsNullOrEmpty(txtNombreFormulario.Text))
                        {
                            
                            if (oFormularioService.CrearFormulario(oFormulario) == true)
                            {
                                MessageBox.Show("Formulario insertado!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("El Formulario ya existe!");
                                this.Close();

                            }
                        }


                        else
                        {
                            MessageBox.Show("El Nombre de formulario no debe estar vacío!");
                        }

                        break;
                    }
                        
                    

                case FormMode.actualizar:
                    {

                        oFormulario.Nombre = txtNuevoNombre.Text;
                        oFormulario.IdFormulario = oFormularioSelected.IdFormulario;

                        

                        if (txtNuevoNombre.Text !="")
                        {
                            if (MessageBox.Show("Seguro que desea modificar el" +
                                "formulario seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                oFormularioService.actualizarFormulario(oFormulario);
                                MessageBox.Show("Formulario modificado!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();


                            }
                            else {
                                MessageBox.Show("El nombre de formulario no debe estar vacío!");


                        }
                        }

                        break;
                    }

                case FormMode.eliminar:
                    {

                        oFormulario = oFormularioSelected;
                        if (MessageBox.Show("Seguro que desea eliminar el formulario seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            oFormularioService.borrarFormulario(oFormulario);
                            MessageBox.Show("Formulario eliminado!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar borrar el formulario!", "Error");
                        }
                    }
                        break;
                    }
            }

    }

        
    }


