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
    public partial class frmPerfiles : Form
    {
        PerfilService oPerfilService = new PerfilService();

        private void cargarGrilla(DataGridView grilla, IList<Perfil> lista)
        {
            grilla.Rows.Clear();
            //for(int i = 0; i<lista.Count; i++)
            foreach (var perfil in lista)
            {
                grilla.Rows.Add(perfil.IdPerfil.ToString(),
                                perfil.Nombre.ToString());
            }
        }

        public frmPerfiles()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCampoPerfil campoPerfil = new frmCampoPerfil();
            campoPerfil.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmPerfiles_Load(object sender, EventArgs e)
        {
            cargarGrilla(dgvPerfiles, oPerfilService.recuperarTodos());
        }
    }
}
