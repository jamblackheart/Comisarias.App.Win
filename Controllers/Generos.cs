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
    public class Generos_Controller
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
                    using (SqlCommand command = new SqlCommand(@"SELECT * FROM Genero", con))
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

        public Respuesta EliminarRegistro(string id)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"DELETE Genero WHERE Id = @pId", con))
                    {
                        SqlParameter pId = new SqlParameter("@pId", SqlDbType.VarChar);

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

        public Respuesta AgregarRegistro(string nombreGenero)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"INSERT INTO Genero VALUES (@pNombreGenero)", con))
                    {
                        SqlParameter pNombreGenero = new SqlParameter("@pNombreGenero", SqlDbType.VarChar);

                        pNombreGenero.Value = nombreGenero;
                        command.Parameters.Add(pNombreGenero);

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

        public Respuesta ActualizarRegistro(string id, string nombreGenero)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"UPDATE Genero SET Nombre = @pNombre WHERE Id = @pId", con))
                    {
                        SqlParameter pId = new SqlParameter("@pId", SqlDbType.VarChar);
                        SqlParameter pNombre = new SqlParameter("@pNombre", SqlDbType.VarChar);

                        pId.Value = id;
                        pNombre.Value = nombreGenero;

                        command.Parameters.Add(pId);
                        command.Parameters.Add(pNombre);

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
