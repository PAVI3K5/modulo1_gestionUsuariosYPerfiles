﻿using BugTacker.Entities;
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
    public partial class frmPerfiles : Form
    {
        PerfilService oPerfilService = new PerfilService();

        public frmPerfiles()
        {
            InitializeComponent();
            InitializeDataGridView();
        }


        private void frmPerfiles_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            Cargartema();
        }

        public void CargarGrilla()
        {
            if (cbxMostrarBorrados.Checked)
            {
                dgvPerfiles.DataSource = oPerfilService.recuperarTodosConBorrados();
                CambiarColorFilasBorradoas(dgvPerfiles);
            }
            else
                dgvPerfiles.DataSource = oPerfilService.recuperarTodos();
        }
        public void FiltrarGrilla()
        {
            if (cbxMostrarBorrados.Checked)
            {
                dgvPerfiles.DataSource = oPerfilService.buscarPerfilConBorrados(txtBuscar.Text);
                CambiarColorFilasBorradoas(dgvPerfiles);
            }
            else
                dgvPerfiles.DataSource = oPerfilService.buscarPerfil(txtBuscar.Text);
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvPerfiles.ColumnCount = 3;
            dgvPerfiles.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvPerfiles.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvPerfiles.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            //Alternamos color filas
            dgvPerfiles.RowsDefaultCellStyle.BackColor = Color.White;
            dgvPerfiles.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Definimos el ancho de la columna.
            dgvPerfiles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Definimos las columnas.
            dgvPerfiles.Columns[0].Name = "ID";
            dgvPerfiles.Columns[0].DataPropertyName = "IdPerfil";
            dgvPerfiles.Columns[1].Name = "Nombre Perfil";
            dgvPerfiles.Columns[1].DataPropertyName = "Nombre";
            dgvPerfiles.Columns[1].ReadOnly = true;
            dgvPerfiles.Columns[2].Name = "Borrado";
            dgvPerfiles.Columns[2].DataPropertyName = "Borrado";

            //Ocultamos columnas innecesarias.
            dgvPerfiles.Columns[0].Visible = false;
            dgvPerfiles.Columns[2].Visible = false;

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvPerfiles.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvPerfiles.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCampoPerfil campoPerfil = new frmCampoPerfil();
            campoPerfil.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmCampoPerfil campoPerfil = new frmCampoPerfil();

            var perfil = (Perfil)dgvPerfiles.CurrentRow.DataBoundItem;
            campoPerfil.InicializarFormulario(frmCampoPerfil.FormMode.actualizar, perfil);
            campoPerfil.ShowDialog();
            CargarGrilla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            frmCampoPerfil campoPerfil = new frmCampoPerfil();

            var perfil = (Perfil)dgvPerfiles.CurrentRow.DataBoundItem;
            campoPerfil.InicializarFormulario(frmCampoPerfil.FormMode.eliminar, perfil);
            campoPerfil.ShowDialog();
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
