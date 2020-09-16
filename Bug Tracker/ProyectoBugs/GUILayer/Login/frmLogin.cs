﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTacker.BusinessLayer;

namespace BugTacker.GUILayer
{
    public partial class frmLogin : Form
    {
        private readonly UsuarioService usuarioService;

        public string UsuarioLogueado { get; internal set; }
        public frmLogin()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validamos que se haya ingresado un usuario.
            if ((txtUsuario.Text == ""))
            {
                mensajeError("Se debe ingresar un usuario.");
                txtUsuario.Focus();
                return;
                
            }

            //Validamos que se haya ingresado una password
            if ((txtPassword.Text == ""))
            {
                mensajeError("Se debe ingresar una contraseña.");
                txtUsuario.Focus();
                return;
               
            }


            var usr = usuarioService.ValidarUsuario(txtUsuario.Text, txtPassword.Text);
            //Controlamos que las creadenciales sean las correctas. 
            if (usr == null)
            {
                txtPassword.Focus();
                //Mostramos un mensaje indicando que el usuario/password es invalido.
                mensajeError("Debe ingresar usuario y/o contraseña válidos");
                this.txtPassword.Text = string.Empty;
    
            }
            else
            {
                this.Close();
            }

        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar_Click(this, new EventArgs());
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar_Click(this, new EventArgs());
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void mensajeError(string msj)
        {
            lblMensajeError.Text = "         " + msj;
            lblMensajeError.Visible = true;
        }
    }
}

