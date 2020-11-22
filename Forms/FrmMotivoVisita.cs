using DPFP;
using DPFP.Capture;
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
using Comisarias.App.Escritorio.Controllers;

namespace Comisarias.App.Escritorio.Forms
{
    public partial class FrmMotivoVisita : Form
    {
        MotivosVisita_Controller Controlador = new MotivosVisita_Controller();
        Parametro parametro = new Parametro();
        private void ReiniciarPagina()
        {
            txtNombre.Text = "";
        }

        public FrmMotivoVisita()
        {
            InitializeComponent();
            CargarDatos();

            this.WindowState = FormWindowState.Maximized;

        }

        private void FrmMotivoVisita_Load(object sender, EventArgs e)
        {
        }

        private void CargarDatos()
        {
            RespuestaGetDatos respuesta = Controlador.ObtenerTodos();

            if (respuesta.FueExitosa)
            {
                dgvDatos.DataSource = respuesta.Datos;

                foreach (DataGridViewColumn colum in dgvDatos.Columns)
                {
                    if (colum.Name == "Id")
                        colum.Visible = false;
                }
            }
            else
            {
                dgvDatos.DataSource = null;
                lblMensaje.Text = respuesta.Mensaje;
            }
        }


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarPagina();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            parametro.Id = dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
            parametro.Nombre = dgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
            InjectarValores();
        }

        private void InjectarValores() {
            txtNombre.Text = parametro.Nombre;
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Está seguro que desea eliminar el registro: " + parametro.Nombre + "?", "Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                Respuesta respuesta = Controlador.EliminarRegistro(parametro.Id);
                if (respuesta.FueExitosa)
                {
                    parametro = new Parametro();
                    InjectarValores();
                    CargarDatos();
                }
            }

        }
    }
}
