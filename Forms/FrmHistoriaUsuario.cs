using Comisarias.App.Escritorio.Models;
using System;
using System.Windows.Forms;


namespace Comisarias.App.Escritorio.Forms
{
    public partial class FrmHistoriaUsuario : Form
    {
        private bool usuarioExiste = false;

        Usuario usuario = new Usuario();

        private void ReiniciarPagina()
        {
            btnConsultarBarequero.Enabled = true;
            usuario = new Usuario();
            usuarioExiste = false;
            txtCedulaConsultar.Text = "";
        }

        public FrmHistoriaUsuario()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

        }

        private void FrmValidarBarequero_Load(object sender, EventArgs e)
        {
            usuario = new Usuario();
        }


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarPagina();
        }


    }
}
