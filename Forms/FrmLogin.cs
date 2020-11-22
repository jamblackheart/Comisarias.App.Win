using DPFP;
using DPFP.Capture;
using Comisarias.App.Escritorio.Forms;
using Comisarias.App.Escritorio.Models;
using Comisarias.App.Escritorio.Services;
using Comisarias.App.Escritorio.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using static Comisarias.App.Escritorio.Models.AuthUser;

namespace Comisarias.App.Escritorio
{
    public partial class FrmLogin : Form
    {
        private RegisterDesktopViewModel Usuario = new RegisterDesktopViewModel();

        public FrmLogin()
        {
            InitializeComponent();
            txtUsuario.Text = "";
            txtClave.Text = "";
            lblMensaje.Text = "";
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        public void IniciarSesion()
        {
            Usuario.Nombres = "Jairo";
            Usuario.Apellidos = "Marin";
            Usuario.Documento = "8028050";
            Usuario.Rol = new List<string>();
            Usuario.Rol.Add("Rol1");
            Usuario.Rol.Add("Rol2");

            Program.usuarioGlobal = Usuario;

            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtClave.Text == "")
            {
                lblMensaje.Text = "Debe indicar el usuario y la clave para continuar";
                            }
            else {
                if (txtUsuario.Text == txtClave.Text)
                {
                    IniciarSesion();
                }
                else
                {
                    lblMensaje.Text = "Usuario o clave incorrecta";
                }
            }            
        }
    }
}
