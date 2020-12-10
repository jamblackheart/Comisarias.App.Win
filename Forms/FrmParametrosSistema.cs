using Comisarias.App.Escritorio.Controllers;
using Comisarias.App.Escritorio.Models;
using System;
using System.Windows.Forms;


namespace Comisarias.App.Escritorio.Forms
{
    public partial class FrmParametrosSistema : Form
    {

        ParametroSistema_Controller controlador = new ParametroSistema_Controller();

        ParametroSistema parametros = new ParametroSistema();






        public FrmParametrosSistema()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            parametros = controlador.ObtenerParametrosSistema();

        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {

            parametros.Nombre = txtNombre.Text;
            parametros.Departamento = txtDepartamento.Text;
            parametros.Municipio = txtMunicipio.Text;
            
            parametros.RutaDocumentos = txtRutaArchivos.Text;

            try
            {
                controlador.ActualizarRegistro(parametros);
                lblMensaje.Text = "Actualizado correctamente";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error del sistema: " + ex.Message;
            }

;
        }

        private void FrmParametrosSistema_Load(object sender, EventArgs e)
        {
            txtNombre.Text = parametros.Nombre;
            txtDepartamento.Text = parametros.Departamento;
            txtMunicipio.Text = parametros.Municipio;
           
            txtRutaArchivos.Text = parametros.RutaDocumentos;
           
            
        }
    }
}
