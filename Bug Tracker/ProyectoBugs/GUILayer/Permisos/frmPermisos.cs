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


namespace ProyectoBugs.GUILayer.Formularios
{
    public partial class frmPermisos : Form
    {
        FormularioService formularioservice = new FormularioService();
        PerfilService perfilService = new PerfilService();

        public frmPermisos()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void frmFormularios_Load(object sender, EventArgs e)
        {

            cmbPerfiles.DataSource = perfilService.recuperarTodos();

            cmbPerfiles.DisplayMember = "nombre";
            cmbPerfiles.ValueMember = "IdPerfil";
            cmbPerfiles.SelectedItem = null;
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
            dgvFormularios.Columns[0].DataPropertyName = "id_formulario";
            dgvFormularios.Columns[1].Name = "Nombre Formulario";
            dgvFormularios.Columns[1].DataPropertyName = "nombre";
            dgvFormularios.Columns[2].Name = "Borrado";
            dgvFormularios.Columns[2].DataPropertyName = "borrado";

            //Ocultamos columnas innecesarias.
            dgvFormularios.Columns[0].Visible = false;
            dgvFormularios.Columns[2].Visible = false;

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvFormularios.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvFormularios.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);


        }

        private void cmbPerfiles_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvFormularios.DataSource = formularioservice.obtenerFormularios(Convert.ToInt32(cmbPerfiles.SelectedValue));

        }

        private void cmbPerfiles_DropDown(object sender, EventArgs e)
        {
        }
    }
}
