﻿using DPFP;
using DPFP.Capture;
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
            this.Text = "Sistema de gestión Comisarias: "+ Program.usuarioGlobal.Nombres + " " + Program.usuarioGlobal.Apellidos ;
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
                registrarVisitaToolStripMenuItem.Visible = true;
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
            FrmGenero frmPantalla = new FrmGenero();
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
            FrmAgresion frmPantalla = new FrmAgresion();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void orientaciónALaVictimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmOrientacion frmPantalla = new FrmOrientacion();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }

        private void entrevistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
            FrmEntrevista frmPantalla = new FrmEntrevista();
            frmPantalla.MdiParent = this;
            frmPantalla.Show();
        }
    }
}
