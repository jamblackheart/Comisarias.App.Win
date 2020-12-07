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
    public partial class FrmRegistrarOrientacion : Form
    {
       
        private string[] meses = { "Enero", "Febrero" , "Marzo", "Abril" ,
            "Mayo" , "Junio" , "Julio" , "Agosto" , "Septiembre" ,
            "Octubre" , "Noviembre" , "Diciembre"};
        Usuario usuario = new Usuario();

        Usuario_Controller controlador_usuario = new Usuario_Controller();

        Visita_Controller controlador_visita = new Visita_Controller();
        Agresion_Controller controlador_agresion = new Agresion_Controller();
        Orientacion_Controller controlador_orientacion = new Orientacion_Controller();
        Entrevista_Controller controlador_entrevista = new Entrevista_Controller();
        InicioProceso_Controller controlador_inicioProceso = new InicioProceso_Controller();


        Orientacion objRegistro = new Orientacion();

        public FrmRegistrarOrientacion()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

        }


        private void ReiniciarPagina()
        {
            usuario = new Usuario();
            CargarHistoria();
            LlenarCamposUsuario();
            txtCedulaConsultar.Text = "";
            txtCedulaConsultar.Enabled = true;
            btnConsultar.Enabled = true;
            btnConsultar.Visible = true;


            pnlRegistro.Visible = false;
            pnlRegistroNuevo.Visible = false;

            LimpiarRegistro();
        }


        private void LimpiarRegistro()
        {

        }



        private void CargarInfomacionEnControles()
        {
           
        }


        private void BloquearFormulario()
        {
            btnConsultar.Enabled = false;
            btnConsultar.Visible = false;
            txtCedulaConsultar.Enabled = false;
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            cmbGeneros.Enabled = false;
            cmbArea.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            txtDireccion.Enabled = false;
            txtCualDiscapacidad.Enabled = false;
            txtCualEtnia.Enabled = false;
            rbtDiscapacidadSi.Enabled = false;
            rbtDiscapacidadNo.Enabled = false;
            rbtEtniaSi.Enabled = false;
            rbtEtniaNo.Enabled = false;
            rbtVictimaConfictoSi.Enabled = false;
            rbtVictimaConfictoNo.Enabled = false;

            pnlRegistro.Visible = true;


        }

       

        private void FrmRegistrarAgresion_Load(object sender, EventArgs e)
        {
            usuario = new Usuario();
            lblFechaActual.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
        }


        private void CargarHistoria()
        {
            ObtenerVisitas();
            ObtenerAgresiones();
            ObtenerOrientaciones();
            ObtenerEntrevistas();
            ObtenerIniciosProceso();
        }

        private void ObtenerVisitas()
        {
            RespuestaGetDatos respuesta = controlador_visita.ObtenerPorIdUsuario(usuario.Id);

            if (respuesta.FueExitosa)
            {
                dgvVisitasAnteriores.DataSource = respuesta.Datos;

                foreach (DataGridViewColumn colum in dgvVisitasAnteriores.Columns)
                {
                    if (colum.Name == "Id" || colum.Name == "UsuarioId")
                        colum.Visible = false;

                    if (colum.Name == "Motivo de visita")
                        colum.Width = 220;
                }

            }
            else
            {
                dgvVisitasAnteriores.DataSource = null;
                lblMensaje.Text = respuesta.Mensaje;
            }
        }

        private void ObtenerAgresiones()
        {
            RespuestaGetDatos respuesta = controlador_agresion.ObtenerPorIdUsuario(usuario.Id);

            if (respuesta.FueExitosa)
            {
                dgvAgresiones.DataSource = respuesta.Datos;

                foreach (DataGridViewColumn colum in dgvAgresiones.Columns)
                {
                    if (colum.Name == "Id" || colum.Name == "UsuarioId")
                        colum.Visible = false;
                }
            }
            else
            {
                dgvAgresiones.DataSource = null;
                lblMensaje.Text = respuesta.Mensaje;
            }
        }

        private void ObtenerOrientaciones()
        {
            RespuestaGetDatos respuesta = controlador_orientacion.ObtenerPorIdUsuario(usuario.Id);

            if (respuesta.FueExitosa)
            {
                dgvOrientaciones.DataSource = respuesta.Datos;

                foreach (DataGridViewColumn colum in dgvOrientaciones.Columns)
                {
                    if (colum.Name == "Id" || colum.Name == "UsuarioId")
                        colum.Visible = false;


                    if (colum.Name == "Responsable" || colum.Name == "Tipo orientación")
                        colum.Width = 150;


                }

            }
            else
            {
                dgvOrientaciones.DataSource = null;
                lblMensaje.Text = respuesta.Mensaje;
            }
        }

        private void ObtenerEntrevistas()
        {
            RespuestaGetDatos respuesta = controlador_entrevista.ObtenerPorIdUsuario(usuario.Id);

            if (respuesta.FueExitosa)
            {
                dgvEntrevistas.DataSource = respuesta.Datos;

                foreach (DataGridViewColumn colum in dgvEntrevistas.Columns)
                {
                    if (colum.Name == "Id" || colum.Name == "UsuarioId")
                        colum.Visible = false;
                }

            }
            else
            {
                dgvEntrevistas.DataSource = null;
                lblMensaje.Text = respuesta.Mensaje;
            }
        }

        private void ObtenerIniciosProceso()
        {
            RespuestaGetDatos respuesta = controlador_inicioProceso.ObtenerPorIdUsuario(usuario.Id);

            if (respuesta.FueExitosa)
            {
                dgvIniciosProcesos.DataSource = respuesta.Datos;

                foreach (DataGridViewColumn colum in dgvIniciosProcesos.Columns)
                {
                    if (colum.Name == "Id" || colum.Name == "UsuarioId")
                        colum.Visible = false;
                }

            }
            else
            {
                dgvIniciosProcesos.DataSource = null;
                lblMensaje.Text = respuesta.Mensaje;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCedulaConsultar.Text.Length == 0)
            {
                lblMensaje.Text = "Debe indicar una cédula";
            }
            else
            {
                usuario = controlador_usuario.ObtenerUsuarioPorDocumento(txtCedulaConsultar.Text);
                if (usuario.Id != null && usuario.Id != 0)
                {
                    txtCedulaConsultar.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnConsultar.Visible = false;
                    pnlRegistro.Visible = true;
                    pnlRegistroNuevo.Visible = true;
                    LlenarCamposUsuario();
                    CargarHistoria();
                    BloquearFormulario();
                    LlenarCamposFecha();
                }
                else
                {
                    lblMensaje.Text = "No existe el usuario";
                }
            }
        }

        private void LlenarCamposUsuario()
        {

            txtNombres.Text = usuario.Nombres;
            txtApellidos.Text = usuario.Apellidos;
            cmbGeneros.SelectedText = usuario.Genero;
            cmbArea.SelectedText = usuario.Area;
            txtTelefono.Text = usuario.Telefono;
            txtEmail.Text = usuario.Correo;
            txtDireccion.Text = usuario.Direccion;
            lblFechaNacimiento.Text = usuario.FechaNacimiento.ToShortDateString();
            txtCualDiscapacidad.Text = usuario.CualDiscapacidad;
            txtCualEtnia.Text = usuario.CualEtnia;
            rbtDiscapacidadSi.Checked = usuario.Discapacidad;
            rbtDiscapacidadNo.Checked = !usuario.Discapacidad;
            rbtEtniaSi.Checked = usuario.PerteneceEtnia;
            rbtEtniaNo.Checked = !usuario.PerteneceEtnia;
            rbtVictimaConfictoSi.Checked = usuario.VictimaConflictoArmado;
            rbtVictimaConfictoNo.Checked = !usuario.VictimaConflictoArmado;

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


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Registrar();


            if (ValidarDatos())
            {

                if (usuario.Id > 0)
                {
                    Respuesta respuesta = controlador_orientacion.AgregarRegistro(objRegistro);
                    if (respuesta.FueExitosa)
                    {
                        MessageBox.Show("Registro exitoso");
                        CargarHistoria();
                        pnlRegistroNuevo.Enabled = false;

                    }
                }
                else
                {
                    lblMensaje.Text = "Problema con el usuario consultado no pudo agregarse la agresion";
                }


            }

        }




      
        

        private void Registrar()
        {
            objRegistro.UsuarioId = usuario.Id;
            objRegistro.Fecha = ObtenerFechaFormulario(cmbAnio.Text, cmbMes.Text, cmbDia.Text);
            objRegistro.Responsable = txtResponsable.Text;
            objRegistro.TipoOrientacion = txtTipoOrientacion.Text;

        }
      
        private bool ValidarDatos()
        {
            bool valido = true;
            string mensaje = "Todos los campos son requeridos, por favor valide: ";
            //if (txtCedulaConsultar.Text == "")
            //{
            //    valido = false;
            //    mensaje += " Documento,";
            //}
            //if (txtNombres.Text == "")
            //{
            //    valido = false;
            //    mensaje += " Nombres,";
            //}
            //if (txtApellidos.Text == "")
            //{
            //    valido = false;
            //    mensaje += " Apellidos,";
            //}
            //if (cmbGeneros.Text == "")
            //{
            //    valido = false;
            //    mensaje += " Genero,";
            //}
            //if (cmbArea.Text == "")
            //{
            //    valido = false;
            //    mensaje += " Área,";
            //}
            //if (txtTelefono.Text == "")
            //{
            //    valido = false;
            //    mensaje += " Teléfono,";
            //}
            //if (txtEmail.Text == "")
            //{
            //    valido = false;
            //    mensaje += " Email,";
            //}
            //if (txtDireccion.Text == "")
            //{
            //    valido = false;
            //    mensaje += " Dirección,";
            //}

            //if (rbtDiscapacidadSi.Checked == false && rbtDiscapacidadNo.Checked == false)
            //{
            //    valido = false;
            //    mensaje += " Discapacidad,";
            //}

            //if (rbtEtniaSi.Checked == false && rbtEtniaNo.Checked == false)
            //{
            //    valido = false;
            //    mensaje += " Etnia,";
            //}
            //if (rbtVictimaConfictoSi.Checked == false && rbtVictimaConfictoNo.Checked == false)
            //{
            //    valido = false;
            //    mensaje += " Victima conflicto armado,";
            //}
            //if (cmbAnio.Text == "" || cmbMes.Text == "" || cmbDia.Text == "")
            //{
            //    valido = false;
            //    mensaje += " Fecha de nacimiento,";
            //}

            //if (!valido)
            //{
            //    mensaje = mensaje.TrimEnd(',');
            //    lblMensaje.Text = mensaje;
            //}
            return valido;
        }


         private DateTime ObtenerFechaFormulario(string panio, string pmes, string pdia)
        {
            try
            {
                int anio = 0;
                Int32.TryParse(panio, out anio);

                int mes = 0;
                mes = Array.IndexOf(meses, pmes) + 1;

                int dia = 0;
                Int32.TryParse(pdia, out dia);

                return new DateTime(anio, mes, dia);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void CrearUsuario()
        {

        }

       
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ReiniciarPagina();
        }
    }
}
