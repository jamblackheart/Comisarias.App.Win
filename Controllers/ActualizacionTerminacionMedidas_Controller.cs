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
    public class ActualizacionTerminacionMedidas_Controller
    {
        string connectionString =
            Comisarias.App.Escritorio.Properties.Settings.Default.dbComisariaConnectionString;


        public Respuesta AgregarRegistro(ActualizacionTerminacionMedidas obj)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";



            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"INSERT INTO ActualizacionTerminacionMedidadas 
                                                                    (UsuarioId
                                                                    ,Fecha
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
                                                                    ,AsolicitudDe
                                                                    ,AutoResuelveIncidente
                                                                    ,Recurso
                                                                    ,FalloRevision)
                                                            VALUES (@pUsuarioId
                                                                    ,@pFecha
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
                                                                    ,@pAsolicitudDe
                                                                    ,@pAutoResuelveIncidente
                                                                    ,@pRecurso
                                                                    ,@pFalloRevision)", con))
                    {
                        SqlParameter pUsuarioId = new SqlParameter("@pUsuarioId", SqlDbType.Int);
                        SqlParameter pFecha = new SqlParameter("@pFecha", SqlDbType.Date);
                        SqlParameter pFechaAudiencia = new SqlParameter("@pFechaAudiencia", SqlDbType.Date);

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
                        SqlParameter pAsolicitudDe = new SqlParameter("@pAsolicitudDe", SqlDbType.VarChar);
                        SqlParameter pAutoResuelveIncidente = new SqlParameter("@pAutoResuelveIncidente", SqlDbType.VarChar);
                        SqlParameter pRecurso = new SqlParameter("@pRecurso", SqlDbType.VarChar);
                        SqlParameter pFalloRevision = new SqlParameter("@pFalloRevision", SqlDbType.VarChar);

                       


                        pUsuarioId.Value = obj.UsuarioId;
                        pFecha.Value = obj.Fecha;
                        pFechaAudiencia.Value = obj.FechaAudiencia;
                        pResponsable.Value = obj.Responsable ;
                        pNotificacionVictima.Value = obj.NotificacionVictima;
                        pNotificacionVictimaVerificada.Value = obj.NotificacionVictimaVerificada;
                        pNotificacionAgresor.Value = obj.NotificacionAgresor;
                        pNotificacionAgresorVerificada.Value = obj.NotificacionAgresorVerificada;
                        pNotificacionAgresorTipo.Value = obj.NotificacionAgresorTipo;

                        pNotificacionOtros.Value = obj.NotificacionOtros;
                        pNotificacionOtrosVerificada.Value = obj.NotificacionOtrosVerificada;
                        pNotificacionOtrosCual.Value = obj.NotificacionOtrosCual;

                        pNotificacionObservacion.Value = obj.NotificacionObservacion;
                        pPruebas.Value = obj.Pruebas    ;
                        pAsolicitudDe.Value = obj.AsolicitudDe;
                        pAutoResuelveIncidente.Value = obj.AutoResuelveIncidente;
                        pRecurso.Value = obj.Recurso;
                        pFalloRevision.Value = obj.FalloRevision;
                       

                        command.Parameters.Add(pUsuarioId);
                        command.Parameters.Add(pFecha);
                        command.Parameters.Add(pFechaAudiencia);
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
                        command.Parameters.Add(pAsolicitudDe);
                        command.Parameters.Add(pAutoResuelveIncidente);
                        command.Parameters.Add(pRecurso);
                        command.Parameters.Add(pFalloRevision);
                        

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
                    using (SqlCommand command = new SqlCommand(@"SELECT Id
      ,UsuarioId
      ,Fecha
      ,FechaAudiencia 'Fecha Audiencia'
      ,Responsable
      ,NotificacionVictima 'Notificación victima'
      ,NotificacionVictimaVerificada 'Notificación victima verificada'
      ,NotificacionAgresor 'Notificación agresor'
      ,NotificacionAgresorVerificada 'Notificación agresor verificada'
      ,NotificacionAgresorTipo 'Notificación agresor tipo'
      ,NotificacionOtros 'Notificación otros'
      ,NotificacionOtrosVerificada 'Notificación otros verificada'
      ,NotificacionOtrosCual 'Notificación otros cual'
      ,NotificacionObservacion 'Notificación observación'
      ,Pruebas
      ,AsolicitudDe 'A solicitud de'
      ,AutoResuelveIncidente 'Auto resuelve incidente'
      ,Recurso
      ,FalloRevision 'Fallo revisión'
                                                        FROM ActualizacionTerminacionMedidadas
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


        public ActualizacionTerminacionMedidas ObtenerPorId(int id)
        {
            ActualizacionTerminacionMedidas retorno = new ActualizacionTerminacionMedidas();



            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"SELECT *
                                                        FROM ActualizacionTerminacionMedidadas
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
                retorno = new ActualizacionTerminacionMedidas();
            }

            return retorno;



        }


    }
}
