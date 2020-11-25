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
    public partial class FrmRegistrarVisita : Form
    {
        private bool usuarioExiste = false;
        private string[] meses = { "Enero", "Febrero" , "Marzo", "Abril" ,
            "Mayo" , "Junio" , "Julio" , "Agosto" , "Septiembre" ,
            "Octubre" , "Noviembre" , "Diciembre"};
        Usuario usuario = new Usuario();
        MotivosVisita_Controller controlador_motivosVisita = new MotivosVisita_Controller();
        Generos_Controller controlador_generos = new Generos_Controller();
        Usuario_Controller controlador_usuario = new Usuario_Controller();
        private void ReiniciarPagina()
        {
            btnConsultar.Enabled = true;
            btnConsultar.Visible = true;
            usuario = new Usuario();
            usuarioExiste = false;
            txtCedulaConsultar.Text = "";
            txtCedulaConsultar.Enabled = true;
            txtNombres.Text = "";
            txtApellidos.Text = "";
            cmbGeneros.SelectedIndex = -1;
            cmbArea.SelectedIndex = -1;
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            cmbDia.SelectedIndex = -1;
            cmbMes.SelectedIndex = -1;
            cmbAnio.SelectedIndex = -1;
            txtCualDiscapacidad.Text = "";
            txtCualEtnia.Text = "";
            rbtDiscapacidadSi.Checked = false;
            rbtDiscapacidadNo.Checked = false;
            rbtEtniaSi.Checked = false;
            rbtEtniaNo.Checked = false;
            rbtVictimaConfictoSi.Checked = false;
            rbtVictimaConfictoNo.Checked = false;
            cmbMotivoVisita.SelectedIndex = -1;
            pnlRegistro.Visible = false;
            dgvVisitasAnteriores.DataSource = null;
            pnlVisitasAnteriores.Visible = false;
            



        }

        public FrmRegistrarVisita()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

        }

        private void FrmValidarBarequero_Load(object sender, EventArgs e)
        {
            usuario = new Usuario();
            lblFechaActual.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
            LlenarCamposFecha();
            ObtenerMotivosVisita();
            ObtenerGeneros();
            ObtenerAreas();



        }


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarPagina();
        }

        private void LlenarCamposFecha()
        {
            for (int i = 1; i <= 31; i++)
            {
                cmbDia.Items.Add(i);
            }
            for (int i = System.DateTime.Now.Year; i >= System.DateTime.Now.Year - 100; i--)
            {
                cmbAnio.Items.Add(i);
            }
            foreach (string item in meses)
            {
                cmbMes.Items.Add(item);
            }

        }

        private void ObtenerMotivosVisita()
        {
            RespuestaGetDatos motivos = controlador_motivosVisita.ObtenerTodos();
            foreach (DataRow item in motivos.Datos.Rows)
            {
                cmbMotivoVisita.Items.Add(item["Nombre"]);
            }
        }



        private void ObtenerGeneros()
        {
            RespuestaGetDatos generos = controlador_generos.ObtenerTodos();
            foreach (DataRow item in generos.Datos.Rows)
            {
                cmbGeneros.Items.Add(item["Nombre"]);
            }
        }

        private void ObtenerAreas()
        {
            cmbArea.Items.Add("Urbana");
            cmbArea.Items.Add("Rural");
        }





        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (usuario.Id != 0) { 
            
            }
        }

        private void ActualizarUsuario() {
            usuario.Nombres = txtNombres.Text;
            usuario.Apellidos = txtApellidos.Text;
            usuario.Genero = cmbGeneros.SelectedText;
            usuario.Area = cmbArea.SelectedText;
            usuario.Telefono = txtTelefono.Text;
            usuario.Correo = txtEmail.Text;
            usuario.Direccion = txtDireccion.Text;
            usuario.FechaNacimiento = ObtenerFechaFormulario();
            usuario.CualDiscapacidad = txtCualDiscapacidad.Text;
            usuario.CualEtnia= txtCualEtnia.Text;
            usuario.Discapacidad = rbtDiscapacidadSi.Checked;            
            usuario.PerteneceEtnia = rbtEtniaSi.Checked;         
            usuario.VictimaConflictoArmado = rbtVictimaConfictoSi.Checked;
        }

        private DateTime ObtenerFechaFormulario() {
            return new DateTime((int)cmbAnio.SelectedItem, (int)cmbMes.SelectedItem, (int)cmbDia.SelectedItem);
        }

        private void CrearUsuario()
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCedulaConsultar.Text.Length == 0)
            {
                lblMensaje.Text = "Debe indicar una cédula";
            }
            else
            {
                pnlRegistro.Visible = true;
                txtCedulaConsultar.Enabled = false;
                btnConsultar.Enabled = false;
                btnConsultar.Visible = false;
                usuario = controlador_usuario.ObtenerUsuarioPorDocumento(txtCedulaConsultar.Text);
                if (usuario.Id != null && usuario.Id != 0)
                {
                    LlenarCamposUsuario();
                }

            }


        }

        private void LlenarCamposUsuario()
        {
            usuarioExiste = true;
            
            txtNombres.Text = usuario.Nombres;
            txtApellidos.Text = usuario.Apellidos;
            cmbGeneros.SelectedText = usuario.Genero;
            cmbArea.SelectedText = usuario.Area;
            txtTelefono.Text = usuario.Telefono;
            txtEmail.Text = usuario.Correo;
            txtDireccion.Text = usuario.Direccion;
            cmbDia.SelectedText = usuario.FechaNacimiento.Day.ToString();
            cmbMes.SelectedText = meses[usuario.FechaNacimiento.Month];
            cmbAnio.SelectedText = usuario.FechaNacimiento.Year.ToString();
            txtCualDiscapacidad.Text = usuario.CualDiscapacidad;
            txtCualEtnia.Text = usuario.CualEtnia;
            rbtDiscapacidadSi.Checked = usuario.Discapacidad;
            rbtDiscapacidadNo.Checked = !usuario.Discapacidad;
            rbtEtniaSi.Checked = usuario.PerteneceEtnia; 
            rbtEtniaNo.Checked = !usuario.PerteneceEtnia;
            rbtVictimaConfictoSi.Checked = usuario.VictimaConflictoArmado; 
            rbtVictimaConfictoNo.Checked = !usuario.VictimaConflictoArmado;
           
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ReiniciarPagina();
        }
    }
}
