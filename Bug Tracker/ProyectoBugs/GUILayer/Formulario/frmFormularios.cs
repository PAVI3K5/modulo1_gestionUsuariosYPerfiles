using BugTacker.Entities;
using ProyectoBugs.BusinessLayer;
using ProyectoBugs.GUILayer.Princ;
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
    public partial class frmFormularios : Form
    {
        FormularioService oFormularioService = new FormularioService();

        public frmFormularios()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void frmFormularios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            Cargartema();
        }

        public void CargarGrilla()
        {
            if (cbxMostrarBorrados.Checked)
            {
                dgvFormularios.DataSource = oFormularioService.recuperarTodosConBorrados();
                CambiarColorFilasBorradoas(dgvFormularios);
            }
            else
                dgvFormularios.DataSource = oFormularioService.recuperarTodos();
        }
        public void FiltrarGrilla()
        {
            if (cbxMostrarBorrados.Checked)
            {
                dgvFormularios.DataSource = oFormularioService.buscarFormularioConBorrados(txtBuscar.Text);
                CambiarColorFilasBorradoas(dgvFormularios);
            }
            else
                dgvFormularios.DataSource = oFormularioService.buscarFormulario(txtBuscar.Text);
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvFormularios.ColumnCount = 3;
            dgvFormularios.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvFormularios.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvFormularios.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            //Alternamos color filas
            dgvFormularios.RowsDefaultCellStyle.BackColor = Color.White;
            dgvFormularios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Definimos el ancho de la columna.
            dgvFormularios.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Definimos las columnas.
            dgvFormularios.Columns[0].Name = "ID";
            dgvFormularios.Columns[0].DataPropertyName = "IdFormulario";
            dgvFormularios.Columns[1].Name = "Nombre Formulario";
            dgvFormularios.Columns[1].DataPropertyName = "Nombre";
            dgvFormularios.Columns[1].ReadOnly = true;
            dgvFormularios.Columns[2].Name = "Borrado";
            dgvFormularios.Columns[2].DataPropertyName = "Borrado";

            //Ocultamos columnas innecesarias.
            dgvFormularios.Columns[0].Visible = false;
            dgvFormularios.Columns[2].Visible = false;

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvFormularios.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvFormularios.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCampoFormulario campoFormulario = new frmCampoFormulario();
            campoFormulario.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmCampoFormulario campoFormulario = new frmCampoFormulario();

            Formulario form = (Formulario)dgvFormularios.CurrentRow.DataBoundItem;
            campoFormulario.InicializarFormulario(frmCampoFormulario.FormMode.actualizar, form);
            campoFormulario.ShowDialog();
            CargarGrilla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            frmCampoFormulario campoFormulario = new frmCampoFormulario();

            Formulario form = (Formulario)dgvFormularios.CurrentRow.DataBoundItem;
            campoFormulario.InicializarFormulario(frmCampoFormulario.FormMode.eliminar, form);
            campoFormulario.ShowDialog();
            CargarGrilla();
        }

        private void Cargartema()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ColorTemas.ColorPrimario;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ColorTemas.ColorSecundario;
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
                CargarGrilla();
            else
                FiltrarGrilla();
        }

        private void cbxMostrarBorrados_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")            
                CargarGrilla();            
            else           
                FiltrarGrilla();
        }

        private void CambiarColorFilasBorradoas(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
                if (Convert.ToBoolean(row.Cells[2].Value) == true)
                    row.DefaultCellStyle.BackColor = Color.Red;
        }

    }
}
