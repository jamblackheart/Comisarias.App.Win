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
    public class ActualizacionIncumplimiento_Controller
    {
        string connectionString =
            Comisarias.App.Escritorio.Properties.Settings.Default.dbComisariaConnectionString;

        //public RespuestaGetDatos ObtenerTodos()
        //{
        //    RespuestaGetDatos retorno = new RespuestaGetDatos();
        //    retorno.FueExitosa = false;
        //    retorno.Mensaje = "validando...";
        //    retorno.Datos = new DataTable();

        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(connectionString))
        //        {
        //            con.Open();
        //            using (SqlCommand command = new SqlCommand(@"SELECT * FROM InicioProceso", con))
        //            {
        //                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //                {
        //                    retorno.FueExitosa = true;
        //                    retorno.Mensaje = "Datos consultados";
        //                    adapter.Fill(retorno.Datos);
        //                }
        //            }
        //            if (con.State == ConnectionState.Open)
        //            {
        //                con.Dispose();
        //            }
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        retorno.FueExitosa = false;
        //        retorno.Mensaje = "Error en el servidor. Error: " + e.Message;
        //    }

        //    return retorno;
        //}

        //public Respuesta EliminarRegistro(string id)
        //{
        //    Respuesta retorno = new Respuesta();
        //    retorno.FueExitosa = false;
        //    retorno.Mensaje = "validando...";

        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(connectionString))
        //        {
        //            con.Open();
        //            using (SqlCommand command = new SqlCommand(@"DELETE InicioProceso WHERE Id = @pId", con))
        //            {
        //                SqlParameter pId = new SqlParameter("@pId", SqlDbType.VarChar);

        //                pId.Value = id;
        //                command.Parameters.Add(pId);

        //                command.ExecuteNonQuery();
        //                retorno.FueExitosa = true;
        //                retorno.Mensaje = "Registro eliminado correctamente";

        //            }
        //            if (con.State == ConnectionState.Open)
        //            {
        //                con.Dispose();
        //            }
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        retorno.FueExitosa = false;
        //        retorno.Mensaje = "Error en el servidor. Error: " + e.Message;
        //    }

        //    return retorno;

        //}

        public Respuesta AgregarRegistro(ActualizacionIncumplimiento obj)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";



            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"INSERT INTO ActualizacionIncumplimiento 
                                                                    (UsuarioId
           ,Fecha
           ,ArchivoAutoTramiteIncumplimiento
           ,FechaAudiencia
           ,Responsable
           ,NotificacionVictima
           ,NotificacionVictimaVerificada
           ,NotificacionAgresor
           ,NotificacionAgresorVerificada
           ,NotificacionAgresorTipo
           ,NotificacionOtros
           ,NotificacionOtrosVerificada
           ,NotificacionOtrosCual
           ,NotificacionObservacion
           ,Pruebas
           ,Sancion
           ,SancionTipo
           ,ConsultaSancion
           ,RevocaConfirma)
                                                            VALUES (@pUsuarioId
           ,@pFecha
           ,@pArchivoAutoTramiteIncumplimiento
           ,@pFechaAudiencia
           ,@pResponsable
           ,@pNotificacionVictima
           ,@pNotificacionVictimaVerificada
           ,@pNotificacionAgresor
           ,@pNotificacionAgresorVerificada
           ,@pNotificacionAgresorTipo
           ,@pNotificacionOtros
           ,@pNotificacionOtrosVerificada
           ,@pNotificacionOtrosCual
           ,@pNotificacionObservacion
           ,@pPruebas
           ,@pSancion
           ,@pSancionTipo
           ,@pConsultaSancion
           ,@pRevocaConfirma)", con))
                    {
                        SqlParameter pUsuarioId = new SqlParameter("@pUsuarioId", SqlDbType.Int);
                        SqlParameter pFecha = new SqlParameter("@pFecha", SqlDbType.Date);
                        SqlParameter pFechaAudiencia = new SqlParameter("@pFechaAudiencia", SqlDbType.Date);

                        
                        SqlParameter pArchivoAutoTramiteIncumplimiento = new SqlParameter("@pArchivoAutoTramiteIncumplimiento", SqlDbType.VarChar);

                        SqlParameter pResponsable = new SqlParameter("@pResponsable", SqlDbType.VarChar);
                        SqlParameter pNotificacionVictima = new SqlParameter("@pNotificacionVictima", SqlDbType.VarChar);
                        SqlParameter pNotificacionVictimaVerificada = new SqlParameter("@pNotificacionVictimaVerificada", SqlDbType.VarChar);
                        SqlParameter pNotificacionAgresor = new SqlParameter("@pNotificacionAgresor", SqlDbType.VarChar);
                        SqlParameter pNotificacionAgresorVerificada = new SqlParameter("@pNotificacionAgresorVerificada", SqlDbType.VarChar);
                        SqlParameter pNotificacionAgresorTipo = new SqlParameter("@pNotificacionAgresorTipo", SqlDbType.VarChar);
                        SqlParameter pNotificacionOtros = new SqlParameter("@pNotificacionOtros", SqlDbType.VarChar);
                        SqlParameter pNotificacionOtrosVerificada = new SqlParameter("@pNotificacionOtrosVerificada", SqlDbType.VarChar);
                        SqlParameter pNotificacionOtrosCual = new SqlParameter("@pNotificacionOtrosCual", SqlDbType.VarChar);
                        SqlParameter pNotificacionObservacion = new SqlParameter("@pNotificacionObservacion", SqlDbType.VarChar);
                        SqlParameter pPruebas = new SqlParameter("@pPruebas", SqlDbType.VarChar);

                        SqlParameter pSancion = new SqlParameter("@pSancion", SqlDbType.VarChar);
                        SqlParameter pSancionTipo = new SqlParameter("@pSancionTipo", SqlDbType.VarChar);
                        SqlParameter pConsultaSancion = new SqlParameter("@pConsultaSancion", SqlDbType.VarChar);
                        SqlParameter pRevocaConfirma = new SqlParameter("@pRevocaConfirma", SqlDbType.VarChar);

                        





                        pUsuarioId.Value = obj.UsuarioId;
                        pFecha.Value = obj.Fecha;
                        pFechaAudiencia.Value = obj.FechaAudiencia;
                        pArchivoAutoTramiteIncumplimiento.Value = obj.ArchivoAutoTramiteIncumplimiento;
                        pResponsable.Value = obj.Responsable;
                        pNotificacionVictima.Value = obj.NotificacionVictima;
                        pNotificacionVictimaVerificada.Value = obj.NotificacionVictimaVerificada;
                        pNotificacionAgresor.Value = obj.NotificacionAgresor;
                        pNotificacionAgresorVerificada.Value = obj.NotificacionAgresorVerificada;
                        pNotificacionAgresorTipo.Value = obj.NotificacionAgresorTipo;
                        pNotificacionOtros.Value = obj.NotificacionOtros;
                        pNotificacionOtrosVerificada.Value = obj.NotificacionOtrosVerificada;
                        pNotificacionOtrosCual.Value = obj.NotificacionOtrosCual;
                        pNotificacionObservacion.Value = obj.NotificacionObservacion;
                        pPruebas.Value = obj.Pruebas;

                        pSancion.Value = obj.Sancion;
                        pSancionTipo.Value = obj.SancionTipo;
                        pConsultaSancion.Value = obj.ConsultaSancion;
                        pRevocaConfirma.Value = obj.RevocaConfirma;

                       



                        command.Parameters.Add(pUsuarioId);
                        command.Parameters.Add(pFecha);

                        command.Parameters.Add(pFechaAudiencia);
                        command.Parameters.Add(pArchivoAutoTramiteIncumplimiento);
                        command.Parameters.Add(pResponsable);
                        command.Parameters.Add(pNotificacionVictima);
                        command.Parameters.Add(pNotificacionVictimaVerificada);
                        command.Parameters.Add(pNotificacionAgresor);
                        command.Parameters.Add(pNotificacionAgresorVerificada);
                        command.Parameters.Add(pNotificacionAgresorTipo);
                        command.Parameters.Add(pNotificacionOtros);
                        command.Parameters.Add(pNotificacionOtrosVerificada);
                        command.Parameters.Add(pNotificacionOtrosCual);
                        command.Parameters.Add(pNotificacionObservacion);
                        command.Parameters.Add(pPruebas);

                        command.Parameters.Add(pSancion);
                        command.Parameters.Add(pSancionTipo);
                        command.Parameters.Add(pConsultaSancion);
                        command.Parameters.Add(pRevocaConfirma);

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
                    using (SqlCommand command = new SqlCommand(@"SELECT *
                                                        FROM ActualizacionIncumplimiento
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


        public ActualizacionIncumplimiento ObtenerPorId(int id)
        {
            ActualizacionIncumplimiento retorno = new ActualizacionIncumplimiento();



            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"SELECT *
                                                        FROM ActualizacionIncumplimiento
                                                   WHERE Id = @pId", con))
                    {
                        SqlParameter pId = new SqlParameter("@pId", SqlDbType.VarChar);

                        pId.Value = id;
                        command.Parameters.Add(pId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                retorno.Id = (int)reader["Id"];


                                retorno.UsuarioId = (int)reader["UsuarioId"];
                                DateTime tFecha = DateTime.MinValue;
                                string ttFecha = reader["Fecha"].ToString();
                                DateTime.TryParse(ttFecha, out tFecha);
                                retorno.Fecha = tFecha;
                              


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
                retorno = new ActualizacionIncumplimiento();
            }

            return retorno;



        }


    }
}
