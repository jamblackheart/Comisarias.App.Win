using DPFP;
using DPFP.Capture;
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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Comisarias.App.Escritorio.Forms
{
    public partial class FrmConsultaHistoriaUsuario : Form
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

        public FrmConsultaHistoriaUsuario()
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
