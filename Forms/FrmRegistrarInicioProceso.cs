using Comisarias.App.Escritorio.Controllers;
using Comisarias.App.Escritorio.Models;
using System;
using System.Windows.Forms;


namespace Comisarias.App.Escritorio.Forms
{
    public partial class FrmRegistrarInicioProceso : Form
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

        InicioProceso objRegistro = new InicioProceso();
        string AutoQueAvocaConocimiento = "";
        string RemisionMedicinaLegalInforme = "";

        
        public FrmRegistrarInicioProceso()
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
            

            usuario = new Usuario();


            AutoQueAvocaConocimiento = "";
            RemisionMedicinaLegalInforme = "";
            lblRutaAutoAvoca.Text = "";
            lblInforme.Text = "";

            txtOtraMedida.Text = "";

            chkDesalojo.Checked = false;
            chkAbstenerseLugar.Checked = false;
            chkEsconderHijos.Checked = false;
            chkAcudirTratamiento.Checked = false;
            chkProteccionPoliciva.Checked = false;
            chkAcompanamientoCasa.Checked = false;
            chkRegimenProvisional.Checked = false;
            chkSuspencionArmas.Checked = false;
            chkPensionAlimentaria.Checked = false;
            chkUsoVivienda.Checked = false;
            chkProhibicionVenta.Checked = false;
            chkDevolucionObjetos.Checked = false;
            chkOtraMedida.Checked = false;

            rdbAmpliacionMedidasSI.Checked = false;
            rdbAmpliacionMedidasNO.Checked = true;
            
            cmbDiaAmpliacionMedidas.Text = "";
            cmbMesAmpliacionMedidas.Text = "";
            cmbAnioAmpliacionMedidas.Text = "";
            cmbSeOtorgaronAmpliacionMedidas.Text = "";

            rdbRemisionFiscaliaSI.Checked = false;
            rdbRemisionFiscaliaNO.Checked = true;
            cmbDiaRemisionFiscalia.Text = "";
            cmbMesRemisionFiscalia.Text = "";
            cmbAnioRemisionFiscalia.Text = "";
            txtNumeroNoticiaRemisionFiscalia.Text = "";


            rdbRemisionMedicinaLegalSI.Checked = false;
            rdbRemisionMedicinaLegalNO.Checked = true;
            cmbDiaRemisionMedicinaLegal.Text = "";
            cmbMesRemisionMedicinaLegal.Text = "";
            cmbAnioRemisionMedicinaLegal.Text = "";



            rdbRemisionEPSSI.Checked = false;
            rdbRemisionEPSNO.Checked = true;
            cmbDiaRemisionEPS.Text = "";
            cmbMesRemisionEPS.Text = "";
            cmbAnioRemisionEPS.Text = "";
            cmbTipoRemisionRemisionEPS.Text = "";

            rdbAcompanamientoComisariaSI.Checked = false;
            rdbAcompanamientoComisariaNO.Checked = true;
            txtObservacionAcompanamientoComisaria.Text = "";

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
                dgvActualizacionIncumplimiento.DataSource = null;
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

            cmbDiaAmpliacionMedidas.Items.Clear();
            cmbAnioAmpliacionMedidas.Items.Clear();
            cmbMesAmpliacionMedidas.Items.Clear();

            cmbDiaRemisionFiscalia.Items.Clear();
            cmbAnioRemisionFiscalia.Items.Clear();
            cmbMesRemisionFiscalia.Items.Clear();

            cmbDiaRemisionMedicinaLegal.Items.Clear();
            cmbAnioRemisionMedicinaLegal.Items.Clear();
            cmbMesRemisionMedicinaLegal.Items.Clear();

            cmbDiaRemisionEPS.Items.Clear();
            cmbAnioRemisionEPS.Items.Clear();
            cmbMesRemisionEPS.Items.Clear();


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
                    Respuesta respuesta = controlador_inicioProceso.AgregarRegistro(objRegistro);
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
                    lblMensaje.Text = "Problema con el usuario consultado no pudo agregarse la agresion";
                }


            }

        }

    
        private void Registrar()
        {
            objRegistro.UsuarioId = usuario.Id;
            objRegistro.Fecha = ObtenerFechaFormulario(cmbAnio.Text, cmbMes.Text, cmbDia.Text);
            objRegistro.AutoQueAvocaConocimiento = AutoQueAvocaConocimiento;
            objRegistro.OpcionMedidasProteccion = rdbCuentaConMedidasPreventivasSI.Checked ? "SI" : "NO";
            objRegistro.MedidasProteccion = MedidasDeProteccion();
            objRegistro.OtraRelacionMedidaProteccion = txtOtraMedida.Text;
            objRegistro.SolicitudAmpliacionMedidas = rdbAmpliacionMedidasSI.Checked ? "SI" : "NO";
            objRegistro.SolicitudAmpliacionMedidasFecha = ObtenerFechaFormulario(cmbAnioAmpliacionMedidas.Text, cmbMesAmpliacionMedidas.Text, cmbDiaAmpliacionMedidas.Text);
            objRegistro.SolicitudAmpliacionMedidasSeOtorgaron = cmbSeOtorgaronAmpliacionMedidas.Text;
            objRegistro.RemisionFiscalia = rdbRemisionFiscaliaSI.Checked ? "SI" : "NO";
            objRegistro.RemisionFiscaliaFecha = ObtenerFechaFormulario(cmbAnioRemisionFiscalia.Text, cmbMesRemisionFiscalia.Text, cmbDiaRemisionFiscalia.Text);
            objRegistro.RemisionFiscaliaNumeroNoticiaCriminal = txtNumeroNoticiaRemisionFiscalia.Text;
            objRegistro.RemisionMedicinaLegal = rdbRemisionMedicinaLegalSI.Checked ? "SI" : "NO";
            objRegistro.RemisionMedicinaLegalFecha = ObtenerFechaFormulario(cmbAnioRemisionMedicinaLegal.Text, cmbMesRemisionMedicinaLegal.Text, cmbDiaRemisionMedicinaLegal.Text);
            objRegistro.RemisionMedicinaLegalInforme = RemisionMedicinaLegalInforme;
            objRegistro.RemisionEps = rdbRemisionEPSSI.Checked ? "SI" : "NO";
            objRegistro.RemisionEpsFecha = ObtenerFechaFormulario(cmbAnioRemisionEPS.Text, cmbMesRemisionEPS.Text, cmbDiaRemisionEPS.Text);
            objRegistro.RemisionEpsTipo = cmbTipoRemisionRemisionEPS.Text;
            objRegistro.AcompañamientoComisaria = rdbAcompanamientoComisariaSI.Checked ? "SI" : "NO";
            objRegistro.AcompañamientoComisariaObservacion = txtObservacionAcompanamientoComisaria.Text;
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

        private bool ValidarDatos()
        {
            bool valido = true;
            string mensaje = "Todos los campos son requeridos, por favor valide: ";

            if (objRegistro.Fecha == null) {
                valido = false;
                mensaje += " Fecha,";
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
                AutoQueAvocaConocimiento = respuesta.Mensaje;
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
                RemisionMedicinaLegalInforme = respuesta.Mensaje;
                string[] tdatosRuta = respuesta.Mensaje.Split('\\');
                lblInforme.Text = tdatosRuta[tdatosRuta.Length - 1];
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
                lblInforme.Text = "Error";
            }
        }

        private void rdbCuentaConMedidasPreventivasSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCuentaConMedidasPreventivasSI.Checked)
            {

                chkDesalojo.Enabled = true;
                chkAbstenerseLugar.Enabled = true;
                lblAbtenerseLugar.Enabled = true;
                chkEsconderHijos.Enabled = true;
                chkAcudirTratamiento.Enabled = true;
                chkProteccionPoliciva.Enabled = true;
                chkAcompanamientoCasa.Enabled = true;
                chkRegimenProvisional.Enabled = true;
                chkSuspencionArmas.Enabled = true;
                chkPensionAlimentaria.Enabled = true;
                chkUsoVivienda.Enabled = true;
                chkProhibicionVenta.Enabled = true;
                chkDevolucionObjetos.Enabled = true;
                chkOtraMedida.Enabled = true;
            }
            else
            {


                txtOtraMedida.Text = "";

                chkDesalojo.Checked = false;
                chkAbstenerseLugar.Checked = false;
                lblAbtenerseLugar.Enabled = false;
                chkEsconderHijos.Checked = false;
                chkAcudirTratamiento.Checked = false;
                chkProteccionPoliciva.Checked = false;
                chkAcompanamientoCasa.Checked = false;
                chkRegimenProvisional.Checked = false;
                chkSuspencionArmas.Checked = false;
                chkPensionAlimentaria.Checked = false;
                chkUsoVivienda.Checked = false;
                chkProhibicionVenta.Checked = false;
                chkDevolucionObjetos.Checked = false;
                chkOtraMedida.Checked = false;


                chkDesalojo.Enabled = false;
                chkAbstenerseLugar.Enabled = false;
                chkEsconderHijos.Enabled = false;
                chkAcudirTratamiento.Enabled = false;
                chkProteccionPoliciva.Enabled = false;
                chkAcompanamientoCasa.Enabled = false;
                chkRegimenProvisional.Enabled = false;
                chkSuspencionArmas.Enabled = false;
                chkPensionAlimentaria.Enabled = false;
                chkUsoVivienda.Enabled = false;
                chkProhibicionVenta.Enabled = false;
                chkDevolucionObjetos.Enabled = false;
                chkOtraMedida.Enabled = false;

            }
        }

        private void chkOtraMedida_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOtraMedida.Checked)
            {
                txtOtraMedida.Enabled = true;
            }
            else
            {

                txtOtraMedida.Enabled = false;
                txtOtraMedida.Text = "";
            }
        }

        private void rdbAmpliacionMedidasSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAmpliacionMedidasSI.Checked)
            {
                cmbDiaAmpliacionMedidas.Enabled = true;
                cmbMesAmpliacionMedidas.Enabled = true;
                cmbAnioAmpliacionMedidas.Enabled = true;
                cmbSeOtorgaronAmpliacionMedidas.Enabled = true;
            }
            else {
                cmbDiaAmpliacionMedidas.Enabled = false;
                cmbMesAmpliacionMedidas.Enabled = false;
                cmbAnioAmpliacionMedidas.Enabled = false;
                cmbSeOtorgaronAmpliacionMedidas.Enabled = false;

                cmbDiaAmpliacionMedidas.Text = "";
                cmbMesAmpliacionMedidas.Text = "";
                cmbAnioAmpliacionMedidas.Text = "";
                cmbSeOtorgaronAmpliacionMedidas.Text = "";

            }
        }

        private void rdbRemisionFiscaliaSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRemisionFiscaliaSI.Checked)
            {
                cmbDiaRemisionFiscalia.Enabled = true;
                cmbMesRemisionFiscalia.Enabled = true;
                cmbAnioRemisionFiscalia.Enabled = true;
                txtNumeroNoticiaRemisionFiscalia.Enabled = true;
            }
            else
            {
                cmbDiaRemisionFiscalia.Enabled = false;
                cmbMesRemisionFiscalia.Enabled = false;
                cmbAnioRemisionFiscalia.Enabled = false;
                txtNumeroNoticiaRemisionFiscalia.Enabled = false;


                cmbDiaRemisionFiscalia.Text = "";
                cmbMesRemisionFiscalia.Text = "";
                cmbAnioRemisionFiscalia.Text = "";

                txtNumeroNoticiaRemisionFiscalia.Text = "";
               

            }
        }

        private void rdbRemisionMedicinaLegalSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRemisionMedicinaLegalSI.Checked)
            {
                cmbDiaRemisionMedicinaLegal.Enabled = true;
                cmbMesRemisionMedicinaLegal.Enabled = true;
                cmbAnioRemisionMedicinaLegal.Enabled = true;
              
            }
            else
            {
                cmbDiaRemisionMedicinaLegal.Enabled = false;
                cmbMesRemisionMedicinaLegal.Enabled = false;
                cmbAnioRemisionMedicinaLegal.Enabled = false;


                cmbDiaRemisionMedicinaLegal.Text = "";
                cmbMesRemisionMedicinaLegal.Text = "";
                cmbAnioRemisionMedicinaLegal.Text = "";



            }
        }

        private void rdbRemisionEPSSI_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbRemisionEPSSI.Checked)
            {
                cmbDiaRemisionEPS.Enabled = true;
                cmbMesRemisionEPS.Enabled = true;
                cmbAnioRemisionEPS.Enabled = true;
                cmbTipoRemisionRemisionEPS.Enabled = true;
            }
            else
            {
                cmbDiaRemisionEPS.Enabled = false;
                cmbMesRemisionEPS.Enabled = false;
                cmbAnioRemisionEPS.Enabled = false;
                cmbTipoRemisionRemisionEPS.Enabled = false;


                cmbDiaRemisionEPS.Text = "";
                cmbMesRemisionEPS.Text = "";
                cmbAnioRemisionEPS.Text = "";
                cmbTipoRemisionRemisionEPS.Text = "";




            }

        }

        private void rdbAcompanamientoComisariaSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAcompanamientoComisariaSI.Checked)
            {
                txtObservacionAcompanamientoComisaria.Enabled = true;
              
            }
            else
            {
                txtObservacionAcompanamientoComisaria.Enabled = false;



                txtObservacionAcompanamientoComisaria.Text = "";
               

            }
        }
    }
}
