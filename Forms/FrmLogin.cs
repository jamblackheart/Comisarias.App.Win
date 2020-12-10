using Comisarias.App.Escritorio.Controllers;
using Comisarias.App.Escritorio.Models;
using System;
using System.Windows.Forms;

namespace Comisarias.App.Escritorio
{
    public partial class FrmLogin : Form
    {
        //private RegisterDesktopViewModel Usuario = new RegisterDesktopViewModel();
        Login_Controller Login = new Login_Controller();


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

        public void IniciarSesion(string usuario, string clave)
        {
            RespuestaAuth respuestaLogin = Login.ValidarUsuario(usuario, clave);

            if (respuestaLogin.FueExitosa)
            {
                Program.usuarioGlobal = respuestaLogin.modelUserRole;

                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
            }
            else {
                lblMensaje.Text = respuestaLogin.Mensaje;
            }

            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtClave.Text == "")
            {
                lblMensaje.Text = "Debe indicar el usuario y la clave para continuar";
                            }
            else {
                
                    IniciarSesion(txtUsuario.Text, txtClave.Text);
                
            }            
        }
    }
}
