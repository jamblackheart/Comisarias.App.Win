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
    public partial class FrmConsultaHistoriaUsuario : Form
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
            cmbDia.Enabled = false;
            cmbMes.Enabled = false;
            cmbAnio.Enabled = false;
            txtCualDiscapacidad.Enabled = false;
            txtCualEtnia.Enabled = false;
            rbtDiscapacidadSi.Enabled = false;
            rbtDiscapacidadNo.Enabled = false;
            rbtEtniaSi.Enabled = false;
            rbtEtniaNo.Enabled = false;
            rbtVictimaConfictoSi.Enabled = false;
            rbtVictimaConfictoNo.Enabled = false;
            cmbMotivoVisita.Enabled = false;
            pnlRegistro.Visible = true;
            btnGuardar.Visible = false;
            btnGuardar.Enabled = true;

        }

        public FrmConsultaHistoriaUsuario()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

        }

        private void FrmConsultaHistoriaUsuario_Load(object sender, EventArgs e)
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
            //if (usuario.Id != 0) { 

            //}

            if (ValidarDatosUsuario())
            {
                ActualizarUsuario();
                if (usuario.Id > 0)
                {
                    Respuesta respuesta = controlador_usuario.ActualizarRegistro(usuario);
                    if (respuesta.FueExitosa)
                    {

                    }
                }
                else
                {
                    Respuesta respuesta = controlador_usuario.AgregarRegistro(usuario);
                    if (respuesta.FueExitosa)
                    {
                        usuario = controlador_usuario.ObtenerUsuarioPorDocumento(txtCedulaConsultar.Text);

                    }
                }
                RegistrarVisita();

            }

        }


        private void RegistrarVisita()
        {
            Visita visita = new Visita();
            visita.UsuarioId = usuario.Id;
            visita.Fecha = System.DateTime.Now;


            MotivoVisita motivoVisita = controlador_motivosVisita.ObtenerMotivoVisitaPorNombre(cmbMotivoVisita.Text);
            if (motivoVisita.Id != 0)
                visita.MotivoVisitaId = motivoVisita.Id;

            Respuesta respuesta = controlador_visita.AgregarRegistro(visita);
            if (respuesta.FueExitosa)
            {
                ObtenerVisitas();
                BloquearFormulario();
                lblMensaje.Text = respuesta.Mensaje;
            }
            else
            {
                BloquearFormulario();
                lblMensaje.Text = respuesta.Mensaje;
            }
        }
        private void ObtenerVisitas()
        {
            RespuestaGetDatos respuesta = controlador_visita.ObtenerPorIdUsuario(usuario.Id);

            if (respuesta.FueExitosa)
            {
                dgvVisitasAnteriores.DataSource = respuesta.Datos;

                foreach (DataGridViewColumn colum in dgvVisitasAnteriores.Columns)
                {
                    if (colum.Name == "Id")
                        colum.Visible = false;
                }
                pnlVisitasAnteriores.Visible = true;
            }
            else
            {
                dgvVisitasAnteriores.DataSource = null;
                lblMensaje.Text = respuesta.Mensaje;
                pnlVisitasAnteriores.Visible = false;
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
                    if (colum.Name == "Id")
                        colum.Visible = false;
                }
                pnlAgresiones.Visible = true;
            }
            else
            {
                dgvAgresiones.DataSource = null;
                lblMensaje.Text = respuesta.Mensaje;
                pnlAgresiones.Visible = false;
            }
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

        private bool ValidarDatosUsuario()
        {
            bool valido = true;
            string mensaje = "Todos los campos son requeridos, por favor valide: ";
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
                
                
                usuario = controlador_usuario.ObtenerUsuarioPorDocumento(txtCedulaConsultar.Text);
                if (usuario.Id != null && usuario.Id != 0)
                {
                    txtCedulaConsultar.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnConsultar.Visible = false;
                    pnlRegistro.Visible = true;
                    LlenarCamposUsuario();
                    ObtenerVisitas();
                    ObtenerAgresiones();
                    BloquearFormulario();
                }
                else
                {
                    lblMensaje.Text = "No existe el usuario";
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

     

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
