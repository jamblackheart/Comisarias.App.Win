﻿using Comisarias.App.Escritorio.Controllers;
using Comisarias.App.Escritorio.Models;
using System;
using System.Windows.Forms;


namespace Comisarias.App.Escritorio.Forms
{
    public partial class FrmRegistrarAgresion : Form
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

        Agresion objRegistro = new Agresion();

        RelacionAgresor_Controller ControladorRelacionAgresor = new RelacionAgresor_Controller();
        MedidasProteccion_Controller ControladorMedidasProteccion = new MedidasProteccion_Controller();

        public FrmRegistrarAgresion()
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
            txtNombreAgresor.Text = "";

            usuario = new Usuario();

            txtNombreAgresor.Text = "";
           txtDocumentoAgresor.Text = "";
            cmbRelacionAgresor.Text  = "";
            txtCualRelacion.Text = "";
            txtDireccionAgresor.Text = ""; 
            txtRadicado.Text = "";
            rdbCuentaConMedidasPreventivasSI.Checked = false;
            rdbCuentaConMedidasPreventivasNO.Checked = true ;
           
            txtOtraMedida.Text =  "";

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

        }

        private void CargarInfomacionEnControles()
        {
            RespuestaGetDatos respuestaRelacionAgresor = ControladorRelacionAgresor.ObtenerTodos();

            if (respuestaRelacionAgresor.FueExitosa)
            {
                cmbRelacionAgresor.DataSource = respuestaRelacionAgresor.Datos;
                cmbRelacionAgresor.DisplayMember = "Nombre";
                cmbRelacionAgresor.ValueMember = "Id";

            }
            else
            {
                cmbRelacionAgresor.DataSource = null;
                lblMensaje.Text = respuestaRelacionAgresor.Mensaje;
            }

           
           
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
                    Respuesta respuesta = controlador_agresion.AgregarRegistro(objRegistro);
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
            objRegistro.NombreAgresor = txtNombreAgresor.Text;
            objRegistro.DocumentoAgresor = txtDocumentoAgresor.Text;
            objRegistro.RelacionAgresor = cmbRelacionAgresor.Text;
            objRegistro.OtraRelacionAgresor = txtCualRelacion.Text;
            objRegistro.DireccionDomicilioAgresor = txtDireccionAgresor.Text;
            objRegistro.Radicado = txtRadicado.Text;
            objRegistro.CuentaMedidasProteccion = rdbCuentaConMedidasPreventivasSI.Checked ? "SI" : "NO";
            objRegistro.MedidasProteccion = MedidasDeProteccion();
            objRegistro.CualOtraMedidaProteccion = txtOtraMedida.Text;

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

            if (objRegistro.Fecha == null)
            {
                valido = false;
                mensaje += " Fecha,";
            }

           

           

            if (txtNombreAgresor.Text == "")
            {
                valido = false;
                mensaje += " Nombre agresor,";
            }
            if (txtDocumentoAgresor.Text == "")
            {
                valido = false;
                mensaje += " Documento agresor,";
            }
            if (txtDireccionAgresor.Text == "")
            {
                valido = false;
                mensaje += " Dirección agresor,";
            }

            if (cmbRelacionAgresor.Text == "")
            {
                valido = false;
                mensaje += " Relación con el agresor,";
            }
            if (txtRadicado.Text == "")
            {
                valido = false;
                mensaje += " Radicado,";
            }


            if (rdbCuentaConMedidasPreventivasSI.Checked)
            {
                if (chkDesalojo.Checked == false &&
                    chkAbstenerseLugar.Checked == false &&
                    chkEsconderHijos.Checked == false &&
                    chkAcudirTratamiento.Checked == false &&
                    chkProteccionPoliciva.Checked == false &&
                    chkAcompanamientoCasa.Checked == false &&
                    chkRegimenProvisional.Checked == false &&
                    chkSuspencionArmas.Checked == false &&
                    chkPensionAlimentaria.Checked == false &&
                    chkUsoVivienda.Checked == false &&
                    chkProhibicionVenta.Checked == false &&
                    chkDevolucionObjetos.Checked == false &&
                    chkOtraMedida.Checked == false) 
                {
                    valido = false;
                    mensaje += " Debe seleccinar una medida de protección,";
                }


            }

            if (chkOtraMedida.Checked && txtOtraMedida.Text == "")
            {
                valido = false;
                mensaje += " Cual otra medida,";
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
            else {


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
            else {

                txtOtraMedida.Enabled = false;
                txtOtraMedida.Text = "";
            }
        }
    }
}


