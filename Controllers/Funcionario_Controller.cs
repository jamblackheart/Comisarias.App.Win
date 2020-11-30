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
    public class Funcionario_Controller
    {
        string connectionString =
            Comisarias.App.Escritorio.Properties.Settings.Default.dbComisariaConnectionString;

        public RespuestaGetDatos ObtenerTodos()
        {
            RespuestaGetDatos retorno = new RespuestaGetDatos();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";
            retorno.Datos = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"SELECT * FROM Funcionario", con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            retorno.FueExitosa = true;
                            retorno.Mensaje = "Datos consultados";
                            adapter.Fill(retorno.Datos);
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

        public Respuesta EliminarRegistro(int id)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"DELETE Funcionario WHERE Id = @pId", con))
                    {
                        SqlParameter pId = new SqlParameter("@pId", SqlDbType.Int);

                        pId.Value = id;
                        command.Parameters.Add(pId);

                        command.ExecuteNonQuery();
                        retorno.FueExitosa = true;
                        retorno.Mensaje = "Registro eliminado correctamente";

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

        public Respuesta AgregarRegistro(User user)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"INSERT INTO Funcionario 
                                VALUES (@pNombres, @pApellidos,@pDocumento, @pEmail,@pPassword)", con))
                    {
                        SqlParameter pNombres = new SqlParameter("@pNombres", SqlDbType.VarChar);
                        SqlParameter pApellidos = new SqlParameter("@pApellidos", SqlDbType.VarChar);
                        SqlParameter pDocumento = new SqlParameter("@pDocumento", SqlDbType.VarChar);
                        SqlParameter pEmail = new SqlParameter("@pEmail", SqlDbType.VarChar);
                        SqlParameter pPassword = new SqlParameter("@pPassword", SqlDbType.VarChar);


                        
                        pNombres.Value = user.Nombres;
                        pApellidos.Value = user.Apellidos;
                        pDocumento.Value = user.Documento;
                        pEmail.Value = "na";
                        pPassword.Value = user.Password;


                        
                        command.Parameters.Add(pNombres);
                        command.Parameters.Add(pApellidos);
                        command.Parameters.Add(pDocumento);
                        command.Parameters.Add(pEmail);
                        command.Parameters.Add(pPassword);

                        int rowsAfected = command.ExecuteNonQuery();
                        retorno.FueExitosa = true;
                        retorno.Mensaje = "Registro agregado correctamente";

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

        public Respuesta ActualizarRegistro(User user)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"UPDATE Funcionario 
                    SET Nombres = @pNombres, 
                        Apellidos = @pApellidos,
                        Documento = @pDocumento,
                        Email = @pEmail,
                        Password = @pPassword
                  WHERE Id = @pId", con))
                    {
                        SqlParameter pId = new SqlParameter("@pId", SqlDbType.VarChar);
                        SqlParameter pNombres = new SqlParameter("@pNombres", SqlDbType.VarChar);
                        SqlParameter pApellidos = new SqlParameter("@pApellidos", SqlDbType.VarChar);
                        SqlParameter pDocumento = new SqlParameter("@pDocumento", SqlDbType.VarChar);
                        SqlParameter pEmail = new SqlParameter("@pEmail", SqlDbType.VarChar);
                        SqlParameter pPassword = new SqlParameter("@pPassword", SqlDbType.VarChar);


                        pId.Value = user.Id;
                        pNombres.Value = user.Nombres;
                        pApellidos.Value = user.Apellidos;
                        pDocumento.Value = user.Documento;
                        pEmail.Value = "";
                        pPassword.Value = user.Password;
                        

                        command.Parameters.Add(pId);
                        command.Parameters.Add(pNombres);
                        command.Parameters.Add(pApellidos);
                        command.Parameters.Add(pDocumento);
                        command.Parameters.Add(pEmail);
                        command.Parameters.Add(pPassword);


                        command.ExecuteNonQuery();
                        retorno.FueExitosa = true;
                        retorno.Mensaje = "Registro actualizado correctamente";

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

        public List<RolFuncionario> ObtenerRolesUsuario(int idFuncionario)
        {
            List<RolFuncionario> retorno = new List<RolFuncionario>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(@"SELECT FuncionarioRoles.IdFuncionario,
                                                                    FuncionarioRoles.IdRol,
                                                                    Rol.Nombre
                                                        FROM Rol
                                                  INNER JOIN FuncionarioRoles
                                                          ON FuncionarioRoles.IdRol = Rol.Id
                                                         AND FuncionarioRoles.IdFuncionario = @Funcionario", con))
                {
                    SqlParameter pfuncionario = new SqlParameter("@Funcionario", SqlDbType.Int);

                    pfuncionario.Value = idFuncionario;
                    command.Parameters.Add(pfuncionario);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            retorno.Add(new RolFuncionario{ 
                                                    IdFuncionario = (int)reader["IdFuncionario"],
                                                    IdRol = (int)reader["IdRol"],
                                                    Rol = reader["Nombre"].ToString()
                            });
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


        public int ObtenerRolUsuarioPorNombreRol(string rol)
        {
            int retorno = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(@"SELECT Id
                                                        FROM Rol
                                                     WHERE Nombre = @pNombre", con))
                {
                    SqlParameter pNombre = new SqlParameter("@pNombre", SqlDbType.VarChar);

                    pNombre.Value = rol;
                    command.Parameters.Add(pNombre);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            retorno = (int)reader["Id"];                          
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

        public Respuesta EliminarRegistroRolFuncionario(int funcionarioId, int rolId)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"DELETE FuncionarioRoles WHERE IdFuncionario = @pIdFuncionario and idRol = @pIdRol", con))
                    {
                        SqlParameter pIdFuncionario = new SqlParameter("@pIdFuncionario", SqlDbType.Int);
                        SqlParameter pIdRol = new SqlParameter("@pIdRol", SqlDbType.Int);

                        pIdFuncionario.Value = funcionarioId;
                        pIdRol.Value = rolId;

                        command.Parameters.Add(pIdFuncionario);
                        command.Parameters.Add(pIdRol);

                        command.ExecuteNonQuery();
                        retorno.FueExitosa = true;
                        retorno.Mensaje = "Registro eliminado correctamente";

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

        public Respuesta AgregarRegistroRolFuncionario(int funcionarioId, int rolId)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"INSERT INTO FuncionarioRoles 
                                VALUES (@pIdFuncionario, @pIdRol)", con))
                    {
                        SqlParameter pIdFuncionario = new SqlParameter("@pIdFuncionario", SqlDbType.Int);
                        SqlParameter pIdRol = new SqlParameter("@pIdRol", SqlDbType.Int);

                        pIdFuncionario.Value = funcionarioId;
                        pIdRol.Value = rolId;

                        command.Parameters.Add(pIdFuncionario);
                        command.Parameters.Add(pIdRol);

                        int rowsAfected = command.ExecuteNonQuery();
                        retorno.FueExitosa = true;
                        retorno.Mensaje = "Registro agregado correctamente";

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



    }
}
