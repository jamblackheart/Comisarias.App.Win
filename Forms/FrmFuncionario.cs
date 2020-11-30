﻿using Comisarias.App.Escritorio.Models;
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
    public partial class FrmFuncionario : Form
    {
        Funcionario_Controller Controlador = new Funcionario_Controller();
        User user = new User();
        private void ReiniciarPagina()
        {
            txtNombres.Text = "";
        }

        public FrmFuncionario()
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

                    if (colum.Name == "Email")
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

        private void InjectarValores()
        {
            txtNombres.Text = user.Nombres;
            txtApellidos.Text = user.Apellidos;
            txtDocumento.Text = user.Documento;
            txtPassword.Text = user.Password;
        }

        private void LimpiarValores()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDocumento.Text = "";
            txtPassword.Text = "";
        }


        private void Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Está seguro que desea eliminar el registro: " + user.Nombres + "?", "Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                Respuesta respuesta = Controlador.EliminarRegistro(user.Id);
                if (respuesta.FueExitosa)
                {
                    user = new User();
                    InjectarValores();
                    CargarDatos();
                }
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string documentos = txtDocumento.Text;
            string password = txtPassword.Text;

            if (nombres != "" || apellidos != "" || documentos != "" || password != "" )
            {

                Respuesta respuesta = Controlador.AgregarRegistro(new User
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    Documento = documentos,
                    Password = password

                });
                if (respuesta.FueExitosa)
                {
                    CargarDatos();
                    LimpiarValores();
                    MessageBox.Show("Registro creado correctamente.");
                }
                else {
                    MessageBox.Show("Error creando el registro: " + respuesta.Mensaje);
                }
            }
            else
            {
                MessageBox.Show("Todos los valores son abligatorios.");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
           

            if (txtNombres.Text != "" || txtApellidos.Text != "" || txtDocumento.Text != "" || txtPassword.Text != "")
            {
                user.Nombres = txtNombres.Text;
                user.Apellidos = txtApellidos.Text;
                user.Documento = txtDocumento.Text;
                user.Password = txtPassword.Text;

                    Respuesta respuesta = Controlador.ActualizarRegistro(user);
                if (respuesta.FueExitosa)
                {
                    CargarDatos();
                    LimpiarValores();
                    MessageBox.Show("Registro actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error actualizando el registro: " + respuesta.Mensaje);
                }
            }
            else
            {
                MessageBox.Show("El Nombre no puede estar vacio.");
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarValores();
            user.Id = (int)dgvDatos.Rows[e.RowIndex].Cells["Id"].Value;
            user.Nombres = dgvDatos.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
            user.Apellidos = dgvDatos.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString();
            user.Documento = dgvDatos.Rows[e.RowIndex].Cells["Documento"].Value.ToString();
            user.Password = dgvDatos.Rows[e.RowIndex].Cells["Password"].Value.ToString();

           
            InjectarValores();
        }

        private void FrmMedidasProteccion_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
