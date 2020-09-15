﻿using System;
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
    }
}
