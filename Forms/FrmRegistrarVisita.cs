using Comisarias.App.Escritorio.Controllers;
using Comisarias.App.Escritorio.Models;
using System;
using System.Data;
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


        Visita objRegistro = new Visita();


        public FrmRegistrarVisita()
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

            pnlRegistro.Enabled = true;
            LimpiarRegistro();

        }


        private void LimpiarRegistro()
        {
            lblMensaje.Text = "";
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



        private void FrmValidarBarequero_Load(object sender, EventArgs e)
        {
            usuario = new Usuario();
            lblFechaActual.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
            LlenarCamposFecha();
            ObtenerMotivosVisita();
            ObtenerGeneros();
            ObtenerAreas();



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

                txtCedulaConsultar.Enabled = false;
                btnConsultar.Enabled = false;
                btnConsultar.Visible = false;
                pnlRegistro.Visible = true;


                usuario = controlador_usuario.ObtenerUsuarioPorDocumento(txtCedulaConsultar.Text);
                if (usuario.Id != null && usuario.Id != 0)
                {
                    txtCedulaConsultar.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnConsultar.Visible = false;

                    //
                    LlenarCamposUsuario();
                    CargarHistoria();
                    // BloquearFormulario();
                    LlenarCamposFecha();
                }
                else
                {


                    lblMensaje.Text = "Usuario nuevo, se creará con los datos ingresados en este formulario";
                }
            }


        }





        private void LlenarCamposUsuario()
        {
            cmbDia.Text = "";
            cmbAnio.Text = "";
            cmbMes.Text = "";
            cmbGeneros.Text = "";
            cmbArea.Text = "";
            cmbHijosMenores.Text = "";

            lblMensaje.Text = "";

            txtNombres.Text = usuario.Nombres;
            txtApellidos.Text = usuario.Apellidos;
            cmbGeneros.SelectedText = usuario.Genero;
            cmbArea.SelectedText = usuario.Area;
            cmbHijosMenores.SelectedText = usuario.HijosMenores;
            
            txtTelefono.Text = usuario.Telefono;
            txtEmail.Text = usuario.Correo;
            txtDireccion.Text = usuario.Direccion;
            cmbDia.SelectedText = usuario.FechaNacimiento.Day.ToString();
            cmbMes.SelectedText = meses[usuario.FechaNacimiento.Month-1];
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


            if (ValidarDatos())
            {
                ActualizarUsuario();
                if (usuario.Id > 0)
                {
                    Respuesta respuesta = controlador_usuario.ActualizarRegistro(usuario);
                    if (respuesta.FueExitosa)
                    {

                        GuardarVisita();
                        CargarHistoria();
                        lblMensaje.Text = "";
                    }
                    else
                    {
                        lblMensaje.Text = "Problema con la actualización del usuario consultado, no pudo agregarse la visita";
                    }

                }
                else
                {
                    Respuesta respuesta = controlador_usuario.AgregarRegistro(usuario);
                    if (respuesta.FueExitosa)
                    {

                        GuardarVisita();

                    }
                    else
                    {
                        lblMensaje.Text = "Problema con la creación del usuario, no pudo agregarse la visita";
                    }
                }

            }

        }

        public void GuardarVisita()
        {


            usuario = controlador_usuario.ObtenerUsuarioPorDocumento(txtCedulaConsultar.Text);

            if (usuario.Id > 0)
            {
                Registrar();

                Respuesta respuesta = controlador_visita.AgregarRegistro(objRegistro);
                if (respuesta.FueExitosa)
                {
                    MessageBox.Show("Registro exitoso");
                    CargarHistoria();
                    pnlRegistro.Enabled = false;
                    lblMensaje.Text = "Guardado";

                }
            }
            else
            {

                lblMensaje.Text = "Problema con el usuario consultado no pudo agregarse la agresion";
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

        private void Registrar()
        {

            objRegistro.UsuarioId = usuario.Id;
            objRegistro.Fecha = System.DateTime.Now;


            MotivoVisita motivoVisita = controlador_motivosVisita.ObtenerMotivoVisitaPorNombre(cmbMotivoVisita.Text);
            if (motivoVisita.Id != 0)
                objRegistro.MotivoVisitaId = motivoVisita.Id;



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




            if (txtCedulaConsultar.Text == "")
            {
                valido = false;
                mensaje += " Documento,";
            }
            if (txtNombres.Text == "")
            {
                valido = false;
                mensaje += " Nombres,";
            }
            if (txtApellidos.Text == "")
            {
                valido = false;
                mensaje += " Apellidos,";
            }
            if (cmbGeneros.Text == "")
            {
                valido = false;
                mensaje += " Genero,";
            }
            if (cmbArea.Text == "")
            {
                valido = false;
                mensaje += " Área,";
            }
            if (txtTelefono.Text == "")
            {
                valido = false;
                mensaje += " Teléfono,";
            }
            if (txtEmail.Text == "")
            {
                valido = false;
                mensaje += " Email,";
            }
            if (txtDireccion.Text == "")
            {
                valido = false;
                mensaje += " Dirección,";
            }
            if (cmbMotivoVisita.Text == "")
            {
                valido = false;
                mensaje += " Motivo visita,";
            }

            if (rbtDiscapacidadSi.Checked == false && rbtDiscapacidadNo.Checked == false)
            {
                valido = false;
                mensaje += " Discapacidad,";
            }

            if (rbtEtniaSi.Checked == false && rbtEtniaNo.Checked == false)
            {
                valido = false;
                mensaje += " Etnia,";
            }
            if (rbtVictimaConfictoSi.Checked == false && rbtVictimaConfictoNo.Checked == false)
            {
                valido = false;
                mensaje += " Victima conflicto armado,";
            }
            if (cmbAnio.Text == "" || cmbMes.Text == "" || cmbDia.Text == "")
            {
                valido = false;
                mensaje += " Fecha de nacimiento,";
            }

            if (rbtEtniaSi.Checked && txtCualEtnia.Text == "")
            {
                valido = false;
                mensaje += " Cúal etnia,";
            }

            if (rbtDiscapacidadSi.Checked && txtCualDiscapacidad.Text == "")
            {
                valido = false;
                mensaje += " Cúal discapacidad,";
            }

            if (!valido)
            {
                mensaje = mensaje.TrimEnd(',');
                lblMensaje.Text = mensaje;
            }
            return valido;
        }

        private DateTime ObtenerFechaFormulario()
        {

            try
            {

                int anio = 0;
                Int32.TryParse(cmbAnio.Text, out anio);


                int mes = 0;
                mes = Array.IndexOf(meses, cmbMes.Text) + 1;

                int dia = 0;
                Int32.TryParse(cmbDia.Text, out dia);

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


        private void ActualizarUsuario()
        {

            try
            {
                usuario.Documento = txtCedulaConsultar.Text;
                usuario.Nombres = txtNombres.Text;
                usuario.Apellidos = txtApellidos.Text;
                usuario.Genero = cmbGeneros.Text;

                Genero genero = controlador_generos.ObtenerGeneroPorNombre(cmbGeneros.Text);
                if (genero.Id != 0)
                    usuario.GeneroId = genero.Id;

                usuario.Area = cmbArea.Text;

                usuario.HijosMenores = cmbHijosMenores.Text;
                usuario.Telefono = txtTelefono.Text;
                usuario.Correo = txtEmail.Text;
                usuario.Direccion = txtDireccion.Text;
                usuario.FechaNacimiento = ObtenerFechaFormulario();
                usuario.CualDiscapacidad = txtCualDiscapacidad.Text;
                usuario.CualEtnia = txtCualEtnia.Text;
                usuario.Discapacidad = rbtDiscapacidadSi.Checked;
                usuario.PerteneceEtnia = rbtEtniaSi.Checked;
                usuario.VictimaConflictoArmado = rbtVictimaConfictoSi.Checked;
            }
            catch (Exception e)
            {
                ReiniciarPagina();
                lblMensaje.Text = "Error del servidor: " + e.Message;

            }

        }

        private void rbtEtniaSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEtniaSi.Checked)
            {
                txtCualEtnia.Enabled = true;
            }
            else
            {
                txtCualEtnia.Text = "";
                txtCualEtnia.Enabled = false;
            }
        }

        private void rbtDiscapacidadSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDiscapacidadSi.Checked)
            {
                txtCualDiscapacidad.Enabled = true;
            }
            else
            {
                txtCualDiscapacidad.Text = "";
                txtCualDiscapacidad.Enabled = false;
            }
        }
    }
}
