using Comisarias.App.Escritorio.Controllers;
using Comisarias.App.Escritorio.Models;
using System;
using System.Windows.Forms;


namespace Comisarias.App.Escritorio.Forms
{
    public partial class FrmRegistrarEntrevista : Form
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
        ActualizacionMedidasProteccion_Controller controlador_actualizacionMedidasProteccion = new ActualizacionMedidasProteccion_Controller();
        ActualizacionIncumplimiento_Controller controlador_actualizacionIncumplimiento = new ActualizacionIncumplimiento_Controller();
        ActualizacionTerminacionMedidas_Controller controlador_actualizacionTerminacionMedidas = new ActualizacionTerminacionMedidas_Controller();
        ActualizacionCaso_Controller controlador_actualizacionCaso = new ActualizacionCaso_Controller();


        Entrevista objRegistro = new Entrevista();

        string adjunto = "";

        public FrmRegistrarEntrevista()
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
            pnlRegistroNuevo.Enabled = true;

            lblMensaje.Text = "";
            cmbDia.Text = "";
            cmbAnio.Text = "";
            cmbMes.Text = "";

            txtResponsable.Text = "";
            txtResumen.Text = "";
            cmbValoracionDelRiesgo.Text = "";
            cmbIdentificacionViolencia.Text = "";

            chkViolenciaFisica.Checked = false;
            chkPsicologica.Checked = false; 
            chkPatrimonial.Checked = false; 
            chkVerbal.Checked = false; 
            chkSexual.Checked = false;

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
            cmbHijosMenores.Enabled = false;
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

            CargarInfomacionEnControles();
        }


        private void CargarHistoria()
        {
            ObtenerVisitas();
            ObtenerAgresiones();
            ObtenerOrientaciones();
            ObtenerEntrevistas();
            ObtenerIniciosProceso();
            ObtenerAudiencias();

            ObtenerActualizacionesMedidasProteccion();
            ObtenerActualizacionesTerminacionMedidas();
            ObtenerActualizacionesIncumplimiento();
            ObtenerActualizacionesCaso();

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
            RespuestaGetDatos respuesta = controlador_actualizacionCaso.ObtenerPorIdUsuario(usuario.Id);

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

        private void ObtenerActualizacionesCaso()
        {
            RespuestaGetDatos respuesta = controlador_actualizacionCaso.ObtenerPorIdUsuario(usuario.Id);

            if (respuesta.FueExitosa)
            {
                dgvActualizacionCaso.DataSource = respuesta.Datos;

                foreach (DataGridViewColumn colum in dgvActualizacionCaso.Columns)
                {
                    if (colum.Name == "Id" || colum.Name == "UsuarioId")
                        colum.Visible = false;
                }

            }
            else
            {
                dgvActualizacionCaso.DataSource = null;
                lblMensaje.Text = respuesta.Mensaje;
            }
        }

        private void ObtenerActualizacionesIncumplimiento()
        {
            RespuestaGetDatos respuesta = controlador_actualizacionIncumplimiento.ObtenerPorIdUsuario(usuario.Id);

            if (respuesta.FueExitosa)
            {
                dgvActualizacionIncumplimiento.DataSource = respuesta.Datos;

                foreach (DataGridViewColumn colum in dgvActualizacionIncumplimiento.Columns)
                {
                    if (colum.Name == "Id" || colum.Name == "UsuarioId")
                        colum.Visible = false;
                }

            }
            else
            {
                dgvActualizacionMedidasProteccion.DataSource = null;
                lblMensaje.Text = respuesta.Mensaje;
            }
        }

        private void ObtenerActualizacionesMedidasProteccion()
        {
            RespuestaGetDatos respuesta = controlador_actualizacionMedidasProteccion.ObtenerPorIdUsuario(usuario.Id);

            if (respuesta.FueExitosa)
            {
                dgvActualizacionMedidasProteccion.DataSource = respuesta.Datos;

                foreach (DataGridViewColumn colum in dgvActualizacionMedidasProteccion.Columns)
                {
                    if (colum.Name == "Id" || colum.Name == "UsuarioId")
                        colum.Visible = false;
                }

            }
            else
            {
                dgvActualizacionMedidasProteccion.DataSource = null;
                lblMensaje.Text = respuesta.Mensaje;
            }
        }

        private void ObtenerActualizacionesTerminacionMedidas()
        {
            RespuestaGetDatos respuesta = controlador_actualizacionTerminacionMedidas.ObtenerPorIdUsuario(usuario.Id);

            if (respuesta.FueExitosa)
            {
                dgvActualizacionTerminacionMedidas.DataSource = respuesta.Datos;

                foreach (DataGridViewColumn colum in dgvActualizacionTerminacionMedidas.Columns)
                {
                    if (colum.Name == "Id" || colum.Name == "UsuarioId")
                        colum.Visible = false;
                }

            }
            else
            {
                dgvActualizacionTerminacionMedidas.DataSource = null;
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

            cmbGeneros.Text = "";
            cmbArea.Text = "";

            lblMensaje.Text = "";


            txtNombres.Text = usuario.Nombres;
            txtApellidos.Text = usuario.Apellidos;
            cmbGeneros.SelectedText = usuario.Genero;
            cmbArea.SelectedText = usuario.Area;
            cmbHijosMenores.SelectedText = usuario.HijosMenores;
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

            cmbDia.Items.Clear();
            cmbAnio.Items.Clear();
            cmbMes.Items.Clear();

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
                    Respuesta respuesta = controlador_entrevista.AgregarRegistro(objRegistro);
                    if (respuesta.FueExitosa)
                    {
                        MessageBox.Show("Registro exitoso");
                        CargarHistoria();
                        pnlRegistroNuevo.Enabled = false;
                        lblMensaje.Text = "Guardado";
                    }
                }
                else
                {
                    lblMensajeAgresion.Text = "Problema con el usuario consultado no pudo agregarse la agresion";
                }


            }

        }


        private void Registrar()
        {
            objRegistro.UsuarioId = usuario.Id;
            objRegistro.Fecha = ObtenerFechaFormulario(cmbAnio.Text, cmbMes.Text, cmbDia.Text);
            objRegistro.Responsable = txtResponsable.Text;
            objRegistro.Resumen = txtResumen.Text;
            objRegistro.TipoViolencia = TipoViolencia();
            objRegistro.IdentificacionViolencia = cmbIdentificacionViolencia.Text;
            objRegistro.ValoracionRiesgo = cmbValoracionDelRiesgo.Text;
            objRegistro.Adjunto = adjunto;
           
        }


        private string TipoViolencia()
        {
            string retorno = "";
            if (chkViolenciaFisica.Checked)
            {
                retorno += chkViolenciaFisica.Text + ",";
            }

            if (chkPsicologica.Checked)
            {
                retorno += chkPsicologica.Text + ",";
            }

            if (chkPatrimonial.Checked)
            {
                retorno += chkPatrimonial.Text + ",";
            }

            if (chkVerbal.Checked)
            {
                retorno += chkVerbal.Text + ",";
            }

            if (chkSexual.Checked)
            {
                retorno += chkSexual.Text + ",";
            }


            return retorno;
        }


        private bool ValidarDatos()
        {
            bool valido = true;
            string mensaje = "Todos los campos son requeridos, por favor valide: ";

            if (objRegistro.Fecha == null)
            {
                valido = false;
                mensaje += " Fecha,";
            }

           

            if (txtResponsable.Text == "")
            {
                valido = false;
                mensaje += " Responsable,";
            }
            if (txtResumen.Text == "")
            {
                valido = false;
                mensaje += " Resumen,";
            }
            if (cmbValoracionDelRiesgo.Text == "")
            {
                valido = false;
                mensaje += " Valoración del riesgo,";
            }

            if (cmbIdentificacionViolencia.Text == "")
            {
                valido = false;
                mensaje += " Identificación de la violencia,";
            }

            if (!chkViolenciaFisica.Checked && 
                !chkPsicologica.Checked &&
                !chkPatrimonial.Checked &&
                !chkVerbal.Checked &&
                !chkSexual.Checked)
            {
                valido = false;
                mensaje += " Algún tipo de violencia,";
            }

            if (!valido)
            {
                mensaje = mensaje.TrimEnd(',');
                lblMensaje.Text = mensaje;

            }

            return valido;
        }

        private DateTime? ObtenerFechaFormulario(string panio, string pmes, string pdia)
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
                return null;
                throw;
            }

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ReiniciarPagina();
        }

        private void btnSubirAdjunto_Click(object sender, EventArgs e)
        {
            Respuesta respuesta = SubirArchivo();
            if (respuesta.FueExitosa)
            {
                adjunto = respuesta.Mensaje;
                string[] tdatosRuta = respuesta.Mensaje.Split('\\');
                lblAdjunto.Text = tdatosRuta[tdatosRuta.Length - 1];
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
                lblAdjunto.Text = "Error";
            }
        }

        private Respuesta SubirArchivo()
        {
            Respuesta respuesta = new Respuesta();

            respuesta.FueExitosa = false;
            respuesta.Mensaje = "Procesando...";

            try
            {
                Archivo archivo = showDialog();

                lblAdjunto.Text = archivo.Nombre;

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


    }
}
