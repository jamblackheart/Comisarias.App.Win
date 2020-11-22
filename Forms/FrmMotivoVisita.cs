using DPFP;
using DPFP.Capture;
using Comisarias.App.Escritorio.Models;
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
    public partial class FrmMotivoVisita : Form
    {
        private bool usuarioExiste = false;

        Usuario usuario = new Usuario();

        private void ReiniciarPagina()
        {
            btnInsertar.Enabled = true;
            usuario = new Usuario();
            usuarioExiste = false;
            txtNombre.Text = "";
        }

        public FrmMotivoVisita()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

        }

        private void FrmMotivoVisita_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbComisariaDataSet1.MotivoVisita' table. You can move, or remove it, as needed.
            this.motivoVisitaTableAdapter.Fill(this.dbComisariaDataSet1.MotivoVisita);
            usuario = new Usuario();
        }


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarPagina();
        }


    }
}
