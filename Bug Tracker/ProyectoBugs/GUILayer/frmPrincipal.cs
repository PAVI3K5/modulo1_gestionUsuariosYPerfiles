﻿using BugTacker.BusinessLayer;
using BugTacker.Entities;
using BugTacker.GUILayer;
using ProyectoBugs.GUILayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTacker.GUILayer
{
    public partial class frmPrincipal : Form
    {
        string usuarioActual;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin formularioLogin = new frmLogin();
            formularioLogin.ShowDialog();
            usuarioActual = formularioLogin.UsuarioLogueado;
            this.Text = "Menu Principal " + usuarioActual;
            formularioLogin.Dispose();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void asistenciaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfiles frmDetalle = new frmPerfiles();
            frmDetalle.ShowDialog();

        }
    }
}
