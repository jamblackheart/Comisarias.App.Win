using Comisarias.App.Escritorio.Controllers;
using Comisarias.App.Escritorio.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Comisarias.App.Escritorio.Forms
{
    public partial class FrmRolFuncionario : Form
    {
        Funcionario_Controller Controlador = new Funcionario_Controller();
        RolFuncionario rolFuncionario  = new RolFuncionario();
        bool rolesCargados = false;
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

        private void CargarRoles()
        {
            try
            {
                List<RolFuncionario> roles = Controlador.ObtenerRolesUsuario(rolFuncionario.IdFuncionario);

                foreach (RolFuncionario rol in roles)
                {
                    if (rol.Rol == "Parametros") {
                        chkParametros.Checked = true;
                    }
                    else if (rol.Rol == "RegistrarVisita") {
                        chkRegistrarVisita.Checked = true;
                    }
                    else if (rol.Rol == "Consultas")
                    {
                        chkConsultas.Checked = true;
                    }
                    else if (rol.Rol == "Procedimientos")
                    {
                        chkProcedimientos.Checked = true;
                    }
                    
                }

                rolesCargados = true;

            }
            catch (Exception e )
            {

                MessageBox.Show("Error: " + e.Message);
            }
            
        }



        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rolFuncionario = new RolFuncionario();
            rolesCargados = false;
            rolFuncionario.IdFuncionario = (int)dgvDatos.Rows[e.RowIndex].Cells["Id"].Value;

            chkParametros.Checked = false;
            chkConsultas.Checked = false;
            chkProcedimientos.Checked = false;
            chkRegistrarVisita.Checked = false;
            

            CargarRoles();
        }

        private void FrmRolFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void chkParametros_CheckedChanged(object sender, EventArgs e)
        {
            if (rolesCargados) { 
                if (chkParametros.Checked){
                    Controlador.AgregarRegistroRolFuncionario(rolFuncionario.IdFuncionario, Controlador.ObtenerRolUsuarioPorNombreRol("Parametros"));
                }
                else {
                    Controlador.EliminarRegistroRolFuncionario(rolFuncionario.IdFuncionario, Controlador.ObtenerRolUsuarioPorNombreRol("Parametros"));
                }
            }
        }

        private void chkRegistrarVisita_CheckedChanged(object sender, EventArgs e)
        {
            if (rolesCargados)
            {
                if (chkRegistrarVisita.Checked)
                {
                    Controlador.AgregarRegistroRolFuncionario(rolFuncionario.IdFuncionario, Controlador.ObtenerRolUsuarioPorNombreRol("RegistrarVisita"));
                }
                else
                {
                    Controlador.EliminarRegistroRolFuncionario(rolFuncionario.IdFuncionario, Controlador.ObtenerRolUsuarioPorNombreRol("RegistrarVisita"));
                }
            }
        }

        private void chkConsultas_CheckedChanged(object sender, EventArgs e)
        {
            if (rolesCargados)
            {
                if (chkRegistrarVisita.Checked)
                {
                    Controlador.AgregarRegistroRolFuncionario(rolFuncionario.IdFuncionario, Controlador.ObtenerRolUsuarioPorNombreRol("Consultas"));
                }
                else
                {
                    Controlador.EliminarRegistroRolFuncionario(rolFuncionario.IdFuncionario, Controlador.ObtenerRolUsuarioPorNombreRol("Consultas"));
                }
            }
        }

        private void chkProcedimientos_CheckedChanged(object sender, EventArgs e)
        {
            if (rolesCargados)
            {
                if (chkProcedimientos.Checked)
                {
                    Controlador.AgregarRegistroRolFuncionario(rolFuncionario.IdFuncionario, Controlador.ObtenerRolUsuarioPorNombreRol("Procedimientos"));
                }
                else
                {
                    Controlador.EliminarRegistroRolFuncionario(rolFuncionario.IdFuncionario, Controlador.ObtenerRolUsuarioPorNombreRol("Procedimientos"));
                }
            }
        }
    }
}
