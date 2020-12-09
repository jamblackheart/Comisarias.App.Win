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
    public partial class FrmRegistrarActualizacionMedidasProteccion : Form
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

        Audiencia_Controller controlador_audiencia = new Audiencia_Controller();
        Actualizacion_Controller controlador_actualizacion = new Actualizacion_Controller();


        Actualizacion objRegistro = new Actualizacion();
       

        public FrmRegistrarActualizacionMedidasProteccion()
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
            ObtenerAudiencias();
            ObtenerActualizacionesProceso();
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
            RespuestaGetDatos respuesta = controlador_actualizacion.ObtenerPorIdUsuario(usuario.Id);

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

        private void ObtenerAudiencias()
        {
            RespuestaGetDatos respuesta = controlador_audiencia.ObtenerPorIdUsuario(usuario.Id);

            if (respuesta.FueExitosa)
            {
                dgvAudiencias.DataSource = respuesta.Datos;

                foreach (DataGridViewColumn colum in dgvAudiencias.Columns)
                {
                    if (colum.Name == "Id" || colum.Name == "UsuarioId")
                        colum.Visible = false;
                }

            }
            else
            {
                dgvAudiencias.DataSource = null;
                lblMensaje.Text = respuesta.Mensaje;
            }
        }

        private void ObtenerActualizacionesProceso()
        {
            RespuestaGetDatos respuesta = controlador_actualizacion.ObtenerPorIdUsuario(usuario.Id);

            if (respuesta.FueExitosa)
            {
                dgvActualizacion.DataSource = respuesta.Datos;

                foreach (DataGridViewColumn colum in dgvActualizacion.Columns)
                {
                    if (colum.Name == "Id" || colum.Name == "UsuarioId")
                        colum.Visible = false;
                }

            }
            else
            {
                dgvActualizacion.DataSource = null;
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
                cmbDiaAmpliacionMedidas.Items.Add(i);
                cmbDiaRemisionFiscalia.Items.Add(i);
                cmbDiaRemisionMedicinaLegal.Items.Add(i);
                cmbDiaRemisionEPS.Items.Add(i);

            }
            for (int i = System.DateTime.Now.Year; i >= System.DateTime.Now.Year - 100; i--)
            {
                cmbAnio.Items.Add(i);
                cmbAnioAmpliacionMedidas.Items.Add(i);
                cmbAnioRemisionFiscalia.Items.Add(i);
                cmbAnioRemisionMedicinaLegal.Items.Add(i);
                cmbAnioRemisionEPS.Items.Add(i);


            }
            foreach (string item in meses)
            {
                cmbMes.Items.Add(item);
                cmbMesAmpliacionMedidas.Items.Add(item);
                cmbMesRemisionFiscalia.Items.Add(item);
                cmbMesRemisionMedicinaLegal.Items.Add(item);
                cmbMesRemisionEPS.Items.Add(item);
            }

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Registrar();

            if (ValidarDatos())
            {

                if (usuario.Id > 0)
                {
                    Respuesta respuesta = controlador_actualizacion.AgregarRegistro(objRegistro);
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

        private string MedidasDeProteccion()
        {
            string retorno = "";
            if (chkDesalojo.Checked)
            {
                retorno += chkDesalojo.Text + ",";
            }

            if (chkAbstenerseLugar.Checked)
            {
                retorno += lblAbtenerseLugar.Text + ",";
            }

            if (chkEsconderHijos.Checked)
            {
                retorno += chkEsconderHijos.Text + ",";
            }

            if (chkAcudirTratamiento.Checked)
            {
                retorno += chkAcudirTratamiento.Text + ",";
            }

            if (chkProteccionPoliciva.Checked)
            {
                retorno += chkProteccionPoliciva.Text + ",";
            }

            if (chkAcompanamientoCasa.Checked)
            {
                retorno += chkAcompanamientoCasa.Text + ",";
            }

            if (chkRegimenProvisional.Checked)
            {
                retorno += chkRegimenProvisional.Text + ",";
            }

            if (chkSuspencionArmas.Checked)
            {
                retorno += chkSuspencionArmas.Text + ",";
            }

            if (chkPensionAlimentaria.Checked)
            {
                retorno += chkPensionAlimentaria.Text + ",";
            }

            if (chkUsoVivienda.Checked)
            {
                retorno += chkUsoVivienda.Text + ",";
            }

            if (chkProhibicionVenta.Checked)
            {
                retorno += chkProhibicionVenta.Text + ",";
            }

            if (chkDevolucionObjetos.Checked)
            {
                retorno += chkDevolucionObjetos.Text + ",";
            }

            if (chkOtraMedida.Checked)
            {
                retorno += chkOtraMedida.Text + ",";
            }

            return retorno;
        }

        private void Registrar()
        {
            objRegistro.UsuarioId = usuario.Id;
            objRegistro.Fecha = ObtenerFechaFormulario(cmbAnio.Text, cmbMes.Text, cmbDia.Text);
            //objRegistro.AutoQueAvocaConocimiento = AutoQueAvocaConocimiento;
            //objRegistro.OpcionMedidasProteccion = rdbMedidasProteccionSI.Checked ? "SI" : "NO";
            //objRegistro.MedidasProteccion = MedidasDeProteccion();
            //objRegistro.OtraRelacionMedidaProteccion = txtOtraMedida.Text;
            //objRegistro.SolicitudAmpliacionMedidas = rdbAmpliacionMedidasSI.Checked ? "SI" : "NO";
            //objRegistro.SolicitudAmpliacionMedidasFecha = ObtenerFechaFormulario(cmbAnioAmpliacionMedidas.Text, cmbMesAmpliacionMedidas.Text, cmbDiaAmpliacionMedidas.Text);
            //objRegistro.SolicitudAmpliacionMedidasSeOtorgaron = cmbSeOtorgaronAmpliacionMedidas.SelectedText;
            //objRegistro.RemisionFiscalia = rdbRemisionFiscaliaSI.Checked ? "SI" : "NO";
            //objRegistro.RemisionFiscaliaFecha = ObtenerFechaFormulario(cmbAnioRemisionFiscalia.Text, cmbMesRemisionFiscalia.Text, cmbDiaRemisionFiscalia.Text);
            //objRegistro.RemisionFiscaliaNumeroNoticiaCriminal = txtNumeroNoticiaRemisionFiscalia.Text;
            //objRegistro.RemisionMedicinaLegal = rdbRemisionMedicinaLegalSI.Checked ? "SI" : "NO";
            //objRegistro.RemisionMedicinaLegalFecha = ObtenerFechaFormulario(cmbAnioRemisionMedicinaLegal.Text, cmbMesRemisionMedicinaLegal.Text, cmbDiaRemisionMedicinaLegal.Text);
            //objRegistro.RemisionMedicinaLegalInforme = RemisionMedicinaLegalInforme;
            //objRegistro.RemisionEps = rdbRemisionEPSSI.Checked ? "SI" : "NO";
            //objRegistro.RemisionEpsFecha = ObtenerFechaFormulario(cmbAnioRemisionEPS.Text, cmbMesRemisionEPS.Text, cmbDiaRemisionEPS.Text);
            //objRegistro.RemisionEpsTipo = cmbTipoRemisionRemisionEPS.SelectedText;
            //objRegistro.AcompañamientoComisaria = rdbAcompanamientoComisariaSI.Checked ? "SI" : "NO";
            //objRegistro.AcompañamientoComisariaObservacion = txtObservacionAcompanamientoComisaria.Text;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            string mensaje = "Todos los campos son requeridos, por favor valide: ";

            //if (txtResponsable.Text == "")
            //{
            //    valido = false;
            //    mensaje += " Nombre agresor,";
            //}
            //if (txtRadicado.Text == "")
            //{
            //    valido = false;
            //    mensaje += " Nombres,";
            //}
            //if (cmbRelacionAgresor.Text == "")
            //{
            //    valido = false;
            //    mensaje += " Apellidos,";
            //}
            //if (cmbMedidasProteccion.Text == "")
            //{
            //    valido = false;
            //    mensaje += " Genero,";
            //}


            if (!valido)
            {
                mensaje = mensaje.TrimEnd(',');

            }
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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ReiniciarPagina();
        }

        private Respuesta SubirArchivo()
        {
            Respuesta respuesta = new Respuesta();

            respuesta.FueExitosa = false;
            respuesta.Mensaje = "Procesando...";

            try
            {
                Archivo archivo = showDialog();

                lblRutaAutoAvoca.Text = archivo.Nombre;

                string nombreArchivo = archivo.Nombre.Split('.')[0] + "_" + System.DateTime.Now.ToString("dd_MM_yyyy HH_mm_ss") + "." + archivo.Nombre.Split('.')[archivo.Nombre.Split('.').Length - 1];
                string rutaArchivoOrigen = archivo.Ruta;
                string carpetaArchivosDestino = @Program.parametroSistema.RutaDocumentos + "\\" + usuario.Documento;
                string rutaArchivoDestino = @Program.parametroSistema.RutaDocumentos + "\\" + usuario.Documento + "\\" + nombreArchivo;

                System.IO.Directory.CreateDirectory(carpetaArchivosDestino);

                System.IO.File.Copy(rutaArchivoOrigen, rutaArchivoDestino, true);

                respuesta.FueExitosa = true;
                respuesta.Mensaje = rutaArchivoDestino;

            }
            catch (Exception e)
            {

                respuesta.FueExitosa = false;
                respuesta.Mensaje = "Falló la carga del archivo: " + e.Message;
            }

            return respuesta;

        }

        private static Archivo showDialog()
        {
            Archivo respuesta = new Archivo();

            try
            {
                OpenFileDialog dialog
                     = new OpenFileDialog();
                //dialog.Filter = "pdf files(.*pdf)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    respuesta.Ruta = dialog.FileName;
                    respuesta.Nombre = dialog.SafeFileName;

                }
            }
            catch (Exception er)
            {

                MessageBox.Show("A ocurrido un error: " + er.Message);

            }
            return respuesta;
        }





        private void btnSubirAutoAvocaConocimiento_Click(object sender, EventArgs e)
        {
            Respuesta respuesta = SubirArchivo();
            if (respuesta.FueExitosa)
            {
               // AutoQueAvocaConocimiento = respuesta.Mensaje;
                string[] tdatosRuta = respuesta.Mensaje.Split('\\');
                lblRutaAutoAvoca.Text = tdatosRuta[tdatosRuta.Length - 1];
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
                lblInforme.Text = "Error";
            }
        }

        private void BtnInformeRemisionMedicinaLegal_Click(object sender, EventArgs e)
        {
            Respuesta respuesta = SubirArchivo();
            if (respuesta.FueExitosa)
            {
                //RemisionMedicinaLegalInforme = respuesta.Mensaje;
                string[] tdatosRuta = respuesta.Mensaje.Split('\\');
                lblInforme.Text = tdatosRuta[tdatosRuta.Length - 1];
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
                lblInforme.Text = "Error";
            }
        }
    }
}
