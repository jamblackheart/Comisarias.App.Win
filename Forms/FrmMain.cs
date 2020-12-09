using Comisarias.App.Escritorio.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Comisarias.App.Escritorio
{
    public partial class FrmMain : Form
    {


        public FrmMain()
        {
            //this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            InitializeComponent();
            this.Text = "Sistema de gestión Comisarias: " +
                    Program.usuarioGlobal.Nombres + " " +
                    Program.usuarioGlobal.Apellidos +
                    " - " + Program.parametroSistema.Nombre +
                    " - DEPARTAMENTO: " + Program.parametroSistema.Departamento +
                    " - MUNICIPIO: " + Program.parametroSistema.Municipio;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            List<string> rol = Program.usuarioGlobal.Rol;


            if (rol.Contains("Parametros"))
            {
                parametrosToolStripMenuItem.Visible = true;
            }

            if (rol.Contains("RegistrarVisita"))
            {
                registrarVisitaToolStripMenuItem.Visible = true;
            }

            if (rol.Contains("Consultas"))
            {
                consultasToolStripMenuItem.Visible = true;
            }

            if (rol.Contains("Procedimientos"))
            {
                procedimientosToolStripMenuItem.Visible = true;
            }




        }

        private void cerrarTodasLasVentanas()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
                frm.Dispose();
            }
        }
        private void ConsultarBarequeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void relacionAgresorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmRelacionAgresor frmPantalla = new FrmRelacionAgresor();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void motivosDeVisitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmMotivoVisita frmPantalla = new FrmMotivoVisita();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void medidasProtecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmMedidasProteccion frmPantalla = new FrmMedidasProteccion();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmGeneros frmPantalla = new FrmGeneros();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void parametrosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmParametrosSistema frmPantalla = new FrmParametrosSistema();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void registrarVisitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmRegistrarVisita frmPantalla = new FrmRegistrarVisita();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void agresionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmRegistrarAgresion frmPantalla = new FrmRegistrarAgresion();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void orientaciónALaVictimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmRegistrarOrientacion frmPantalla = new FrmRegistrarOrientacion();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void entrevistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmRegistrarEntrevista frmPantalla = new FrmRegistrarEntrevista();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            cerrarTodasLasVentanas();
            FrmFuncionario frmPantalla = new FrmFuncionario();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void rolFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmRolFuncionario frmPantalla = new FrmRolFuncionario();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void historiaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmConsultaHistoriaUsuario frmPantalla = new FrmConsultaHistoriaUsuario();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void inicioDeProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmRegistrarInicioProceso frmPantalla = new FrmRegistrarInicioProceso();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void audienciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmRegistrarAudiencia frmPantalla = new FrmRegistrarAudiencia();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void actualizaciónCasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmRegistrarActualizacionIncumplimiento frmPantalla = new FrmRegistrarActualizacionIncumplimiento();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }
    }
}
