using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Comisarias.App.Escritorio.Models;

namespace Comisarias.App.Escritorio.Controllers
{
    public class Login_Controller
    {
        string connectionString =
            Comisarias.App.Escritorio.Properties.Settings.Default.dbComisariaConnectionString;

        public  RespuestaAuth ValidarUsuario(string usuario, string clave)
        {
            RespuestaAuth retorno = new RespuestaAuth();

            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";
            retorno.modelUserRole = null;

            if (usuario.Length == 0 || clave.Length == 0)
            {
                retorno.FueExitosa = false;
                retorno.Mensaje = "El usuario y la clave son obligatorios";
                return retorno;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    //
                    // Open the SqlConnection.
                    //
                    con.Open();
                    //
                    // This code uses an SqlCommand based on the SqlConnection.
                    //
                    using (SqlCommand command = new SqlCommand(@"SELECT TOP 1 * FROM Funcionario  
                                                                WHERE Documento = @Username AND Password = @Password", con))
                    {
                        SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
                        SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);

                        uName.Value = usuario;
                        uPassword.Value = clave;

                        command.Parameters.Add(uName);
                        command.Parameters.Add(uPassword);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                retorno.FueExitosa = true;
                                retorno.Mensaje = "Usuario y clave válidos";
                                ViewModelUserRole userRole = new ViewModelUserRole
                                {
                                    Id = reader["Id"].ToString(),
                                    Nombres = reader["Nombres"].ToString(),
                                    Apellidos = reader["Apellidos"].ToString(),
                                    Documento = reader["Documento"].ToString(),
                                    Email = reader["Email"].ToString()
                                };
                               
                                userRole.Rol = ObtenerRolesUsuario(userRole.Id);
                                retorno.modelUserRole = userRole;
                            }
                            else
                            {
                                retorno.FueExitosa = false;
                                retorno.Mensaje = "Usuario y clave no corresponden a un usuario del sistema";
                            }
                        }
                    }

                    if (con.State == ConnectionState.Open)
                    {
                        con.Dispose();
                    }
                }

            }
            catch (Exception e)
            {
                retorno.FueExitosa = false;
                retorno.Mensaje = "Error en el servidor. Error: " + e.Message;

            }


            return retorno;
        }


        private List<string> ObtenerRolesUsuario(string funcionario)
        {
            List<string> retorno = new List<string>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                
                using (SqlCommand command = new SqlCommand(@"SELECT Rol.Nombre
                                                        FROM Rol
                                                  INNER JOIN FuncionarioRoles
                                                          ON FuncionarioRoles.IdRol = Rol.Id
                                                         AND FuncionarioRoles.IdFuncionario = @Funcionario", con))
                {
                    SqlParameter pfuncionario = new SqlParameter("@Funcionario", SqlDbType.VarChar);

                    pfuncionario.Value = funcionario;
                    command.Parameters.Add(pfuncionario);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            retorno.Add(reader.GetString(0).ToString());
                        }
                    }
                }

                if (con.State == ConnectionState.Open)
                {
                    con.Dispose();

                }
            }

            return retorno;
        }
    }
}
