using Comisarias.App.Escritorio.Controllers;
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
    public partial class FrmAgresion : Form
    {
        private bool usuarioExiste = false;

        MedidasProteccion_Controller ControladorMedidasProteccion = new MedidasProteccion_Controller();
        RelacionAgresor_Controller ControladorRelacionAgresor = new RelacionAgresor_Controller();
        Agresion_Controller ControladorAgresion = new Agresion_Controller();

        Usuario usuario = new Usuario();

        private void ReiniciarPagina()
        {
            btnConsultarBarequero.Enabled = true;
            usuario = new Usuario();
            usuarioExiste = false;
            txtCedulaConsultar.Text = "";
        }

        public FrmAgresion()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

        }

        private void FrmValidarBarequero_Load(object sender, EventArgs e)
        {
            usuario = new Usuario();

            LlenarCamposFecha();
            CargarInfomacionEnControles();
        }


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarPagina();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LlenarCamposFecha()
        {
            for (int i = 1; i <= 31; i++)
            {
                comboBoxDia.Items.Add(i);
            }

            for (int i = 2000; i <= 2050; i++)
            {
                comboBoxAnyo.Items.Add(i);
            }

        }

        private void CargarInfomacionEnControles()
        {
            RespuestaGetDatos respuestaRelacionAgresor = ControladorRelacionAgresor.ObtenerTodos();

            if (respuestaRelacionAgresor.FueExitosa)
            {
                comboBoxRelacionAgresor.DataSource = respuestaRelacionAgresor.Datos;
                comboBoxRelacionAgresor.DisplayMember = "Nombre";
                comboBoxRelacionAgresor.ValueMember = "Id";

            }
            else
            {
                comboBoxRelacionAgresor.DataSource = null;
                lblMensaje.Text = respuestaRelacionAgresor.Mensaje;
            }

            RespuestaGetDatos respuestaMedidasProteccion = ControladorMedidasProteccion.ObtenerTodos();

            if (respuestaMedidasProteccion.FueExitosa)
            {
                comboBoxMedidasProteccion.DataSource = respuestaMedidasProteccion.Datos;
                comboBoxMedidasProteccion.DisplayMember = "Nombre";
                comboBoxMedidasProteccion.ValueMember = "Id";

            }
            else
            {
                comboBoxMedidasProteccion.DataSource = null;
                lblMensaje.Text = respuestaMedidasProteccion.Mensaje;
            }
        }

        private void btnGuardarVisita_Click(object sender, EventArgs e)
        {
            Agresion objAgresion = new Agresion();


            //objAgresion.UsuarioId = 1;
            //string fecha = comboBoxDia.SelectedValue.ToString() + "/" + comboBoxMes.SelectedValue.ToString() + "/" + comboBoxAnyo.SelectedValue.ToString();
            //objAgresion.Fecha = Convert.ToDateTime(fecha);
            //objAgresion.NombreAgresor = textBoxNombreAgresor.Text;
            //objAgresion.DocumentoAgresor = textBoxDocAgresor.Text;
            //objAgresion.RelacionAgresorId = Convert.ToInt32(comboBoxRelacionAgresor.SelectedValue);
            //objAgresion.OtraRelacionAgresor = textBoxCualRelacion.Text;
            //objAgresion.DireccionDomicilioAgresor = textBoxDirAgresor.Text;
            //objAgresion.Radicado = textBoxRadicado.Text;
            //objAgresion.CuentaMedidasProteccion = Convert.ToBoolean(comboBoxMedidasProteccion.SelectedValue);
            //objAgresion.MedidaProteccionId = Convert.ToInt32(comboBoxMedidasProteccion.SelectedValue);
            //objAgresion.CualOtraMedidaProteccion = textBoxCualProteccion.Text.ToString();

            objAgresion.UsuarioId = 1;
            objAgresion.Fecha = Convert.ToDateTime("12/12/2020");
            objAgresion.NombreAgresor = "Agresor Name";
            objAgresion.DocumentoAgresor = "555";
            objAgresion.RelacionAgresorId = 1;
            objAgresion.OtraRelacionAgresor = "";
            objAgresion.DireccionDomicilioAgresor = "Cra 45 CL 22";
            objAgresion.Radicado = "RD-25";
            objAgresion.CuentaMedidasProteccion = false;
            objAgresion.MedidaProteccionId = 1;
            objAgresion.CualOtraMedidaProteccion = "";

            ControladorAgresion.AgregarRegistro(objAgresion);
        }

        private void btnConsultarBarequero_Click(object sender, EventArgs e)
        {

        }
    }
}
