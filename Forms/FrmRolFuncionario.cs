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
    public partial class FrmRolFuncionario : Form
    {
        MedidasProteccion_Controller Controlador = new MedidasProteccion_Controller();
        Parametro parametro = new Parametro();
        private void ReiniciarPagina()
        {
            txtNombre.Text = "";
        }

        public FrmRolFuncionario()
        {
            InitializeComponent();
            CargarDatos();

            this.WindowState = FormWindowState.Maximized;

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
            //parametro.Id = dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
            //parametro.Nombre = dgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
            //InjectarValores();
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            if (nombre != "")
            {
                Respuesta respuesta = Controlador.AgregarRegistro(nombre);
                if (respuesta.FueExitosa)
                {
                    CargarDatos();
                    txtNombre.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Debe indicar el nombre de la medida de protección.");
            }
                
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            if (nombre != "")
            {
                Respuesta respuesta = Controlador.ActualizarRegistro(parametro.Id,nombre);
                if (respuesta.FueExitosa)
                {
                    CargarDatos();
                    txtNombre.Text = "";
                    MessageBox.Show("Registro actualizado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("El Nombre no puede estar vacio.");
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            parametro.Id = dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
            parametro.Nombre = dgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
            InjectarValores();
        }

        private void FrmMedidasProteccion_Load(object sender, EventArgs e)
        {

        }
    }
}
