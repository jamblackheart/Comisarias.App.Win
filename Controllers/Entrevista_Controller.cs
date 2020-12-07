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
    public class Entrevista_Controller
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
                    using (SqlCommand command = new SqlCommand(@"SELECT * FROM Agresion", con))
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
                    using (SqlCommand command = new SqlCommand(@"DELETE Agresion WHERE Id = @pId", con))
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

        public Respuesta AgregarRegistro(Entrevista obj)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";



            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"INSERT INTO Entrevista 
                                                                    (UsuarioId
                                                                      ,Fecha
                                                                      ,Responsable
                                                                      ,Resumen
                                                                      ,TipoViolencia
                                                                      ,IdentificacionViolencia
                                                                      ,ValoracionRiesgo)
                                                            VALUES (@pUsuarioId
                                                                  ,@pFecha
                                                                  ,@pResponsable
                                                                  ,@pResumen
                                                                  ,@pTipoViolencia
                                                                  ,@pIdentificacionViolencia
                                                                  ,@pValoracionRiesgo)", con))
                    {
                        SqlParameter pUsuarioId = new SqlParameter("@pUsuarioId", SqlDbType.Int);
                        SqlParameter pFecha = new SqlParameter("@pFecha", SqlDbType.Date);
                        SqlParameter pResponsable = new SqlParameter("@pResponsable", SqlDbType.VarChar);
                        SqlParameter pResumen = new SqlParameter("@pResumen", SqlDbType.VarChar);
                        SqlParameter pTipoViolencia = new SqlParameter("@pTipoViolencia", SqlDbType.VarChar);
                        SqlParameter pIdentificacionViolencia = new SqlParameter("@pIdentificacionViolencia", SqlDbType.VarChar);
                        SqlParameter pValoracionRiesgo = new SqlParameter("@pValoracionRiesgo", SqlDbType.VarChar);
                      

                        pUsuarioId.Value = obj.UsuarioId;
                        pFecha.Value = obj.Fecha;
                        pResponsable.Value = obj.Responsable;
                        pResumen.Value = obj.Resumen;
                        pTipoViolencia.Value = obj.TipoViolencia;
                        pIdentificacionViolencia.Value = obj.IdentificacionViolencia;
                        pValoracionRiesgo.Value = obj.ValoracionRiesgo;
                        

                        command.Parameters.Add(pUsuarioId);
                        command.Parameters.Add(pFecha);
                        command.Parameters.Add(pResponsable);
                        command.Parameters.Add(pResumen);
                        command.Parameters.Add(pTipoViolencia);
                        command.Parameters.Add(pIdentificacionViolencia);
                        command.Parameters.Add(pValoracionRiesgo);
                       

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

        public RespuestaGetDatos ObtenerPorIdUsuario(int idUsuario)
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
                    using (SqlCommand command = new SqlCommand(@"SELECT Id
                                                                        ,UsuarioId
                                                                        ,Fecha
                                                                        ,Responsable
                                                                        ,Resumen
                                                                        ,TipoViolencia 'Tipo de violencia'
                                                                        ,IdentificacionViolencia 'Identificación de la violencia'
                                                                        ,ValoracionRiesgo 'Valoración del riesgo'
                                                        FROM Entrevista
                                                   WHERE UsuarioId = @pUsuarioId", con))
                    {
                        SqlParameter pUsuarioId = new SqlParameter("@pUsuarioId", SqlDbType.VarChar);

                        pUsuarioId.Value = idUsuario;
                        command.Parameters.Add(pUsuarioId);

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

    }
}
