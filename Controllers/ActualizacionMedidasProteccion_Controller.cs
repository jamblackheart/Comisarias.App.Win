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
    public class ActualizacionMedidasProteccion_Controller
    {
        string connectionString =
            Comisarias.App.Escritorio.Properties.Settings.Default.dbComisariaConnectionString;

           public Respuesta AgregarRegistro(ActualizacionMedidasProteccion obj)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";



            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"INSERT INTO ActualizacionMedidasProteccion 
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
           ,AmpliacionDeMedidasProtecccion
           ,AmpliacionDeMedidasProtecccionCuales
           ,MedidasDeAtencion
           ,VerificacionSituacionRiesgo
           ,ObservacionVerificacionSituacionRiesgo
           ,Remision
           ,NotifiacionVictimaMedidasAtencion
           ,NotifiacionVictimaMedidasAtencionVerificada
           ,RemisionEntidadTerritorial
           ,Seguimiento
           ,FechaSeguimiento
           ,TiposMedida
           ,ObservacionMedida
           ,ProteccionTemporal
           ,ExtensivaHijos
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
           ,@pAmpliacionDeMedidasProtecccion
           ,@pAmpliacionDeMedidasProtecccionCuales
           ,@pMedidasDeAtencion
           ,@pVerificacionSituacionRiesgo
           ,@pObservacionVerificacionSituacionRiesgo
           ,@pRemision
           ,@pNotifiacionVictimaMedidasAtencion
           ,@pNotifiacionVictimaMedidasAtencionVerificada
           ,@pRemisionEntidadTerritorial
           ,@pSeguimiento
           ,@pFechaSeguimiento
           ,@pTiposMedida
           ,@pObservacionMedida
           ,@pProteccionTemporal
           ,@pExtensivaHijos
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




                        SqlParameter pAmpliacionDeMedidasProtecccion = new SqlParameter("@pAmpliacionDeMedidasProtecccion", SqlDbType.VarChar);
                        SqlParameter pAmpliacionDeMedidasProtecccionCuales = new SqlParameter("@pAmpliacionDeMedidasProtecccionCuales", SqlDbType.VarChar);


                        SqlParameter pMedidasDeAtencion = new SqlParameter("@pMedidasDeAtencion", SqlDbType.VarChar);
                        SqlParameter pVerificacionSituacionRiesgo = new SqlParameter("@pVerificacionSituacionRiesgo", SqlDbType.VarChar);
                        SqlParameter pObservacionVerificacionSituacionRiesgo = new SqlParameter("@pObservacionVerificacionSituacionRiesgo", SqlDbType.VarChar);
                        SqlParameter pRemision = new SqlParameter("@pRemision", SqlDbType.VarChar);
                        SqlParameter pNotifiacionVictimaMedidasAtencion = new SqlParameter("@pNotifiacionVictimaMedidasAtencion", SqlDbType.VarChar);
                        SqlParameter pNotifiacionVictimaMedidasAtencionVerificada = new SqlParameter("@pNotifiacionVictimaMedidasAtencionVerificada", SqlDbType.VarChar);
                        SqlParameter pRemisionEntidadTerritorial = new SqlParameter("@pRemisionEntidadTerritorial", SqlDbType.VarChar);
                        SqlParameter pSeguimiento = new SqlParameter("@pSeguimiento", SqlDbType.VarChar);
                        SqlParameter pFechaSeguimiento = new SqlParameter("@pFechaSeguimiento", SqlDbType.VarChar);
                        SqlParameter pTiposMedida = new SqlParameter("@pTiposMedida", SqlDbType.VarChar);
                        SqlParameter pObservacionMedida = new SqlParameter("@pObservacionMedida", SqlDbType.VarChar);
                        SqlParameter pProteccionTemporal = new SqlParameter("@pProteccionTemporal", SqlDbType.VarChar);
                        SqlParameter pExtensivaHijos = new SqlParameter("@pExtensivaHijos", SqlDbType.VarChar);
                        SqlParameter pRecurso = new SqlParameter("@pRecurso", SqlDbType.VarChar);
                        SqlParameter pFalloRevision = new SqlParameter("@pFalloRevision", SqlDbType.VarChar);




                        pUsuarioId.Value = obj.UsuarioId;
                        pFecha.Value = obj.Fecha;
                        pFechaAudiencia.Value = obj.FechaAudiencia;

                        pResponsable.Value = obj.Responsable;
                        pNotificacionVictima.Value = obj.NotifiacionVictimaMedidasAtencion;
                        pNotificacionVictimaVerificada.Value = obj.NotifiacionVictimaMedidasAtencionVerificada;
                        pNotificacionAgresor.Value = obj.NotificacionAgresor;
                        pNotificacionAgresorVerificada.Value = obj.NotificacionAgresorVerificada;
                        pNotificacionAgresorTipo.Value = obj.NotificacionAgresorTipo;
                        pNotificacionOtros.Value = obj.NotificacionOtros;
                        pNotificacionOtrosVerificada.Value = obj.NotificacionOtrosVerificada;
                        pNotificacionOtrosCual.Value = obj.NotificacionOtrosCual;
                        pNotificacionObservacion.Value = obj.NotificacionObservacion;
                        pPruebas.Value = obj.Pruebas;

                        pAmpliacionDeMedidasProtecccion.Value = obj.AmpliacionDeMedidasProtecccion;
                        pAmpliacionDeMedidasProtecccionCuales.Value = obj.AmpliacionDeMedidasProtecccionCuales;

                        pMedidasDeAtencion.Value = obj.MedidasDeAtencion;
                        pVerificacionSituacionRiesgo.Value = obj.VerificacionSituacionRiesgo;
                        pObservacionVerificacionSituacionRiesgo.Value = obj.ObservacionVerificacionSituacionRiesgo;
                        pRemision.Value = obj.Remision;
                        pNotifiacionVictimaMedidasAtencion.Value = obj.NotifiacionVictimaMedidasAtencion;
                        pNotifiacionVictimaMedidasAtencionVerificada.Value = obj.NotifiacionVictimaMedidasAtencionVerificada;
                        pRemisionEntidadTerritorial.Value = obj.RemisionEntidadTerritorial;
                        pSeguimiento.Value = obj.Seguimiento;
                        pFechaSeguimiento.Value = obj.FechaSeguimiento;
                        pTiposMedida.Value = obj.TiposMedida;
                        pObservacionMedida.Value = obj.ObservacionMedida;
                        pProteccionTemporal.Value = obj.ProteccionTemporal;
                        pExtensivaHijos.Value = obj.ExtensivaHijos;
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

                        command.Parameters.Add(pAmpliacionDeMedidasProtecccion);
                        command.Parameters.Add(pAmpliacionDeMedidasProtecccionCuales);
                       
                        command.Parameters.Add(pMedidasDeAtencion);
                        command.Parameters.Add(pVerificacionSituacionRiesgo);
                        command.Parameters.Add(pObservacionVerificacionSituacionRiesgo);
                        command.Parameters.Add(pRemision);
                        command.Parameters.Add(pNotifiacionVictimaMedidasAtencion);
                        command.Parameters.Add(pNotifiacionVictimaMedidasAtencionVerificada);
                        command.Parameters.Add(pRemisionEntidadTerritorial);
                        command.Parameters.Add(pSeguimiento);
                        command.Parameters.Add(pFechaSeguimiento);
                        command.Parameters.Add(pTiposMedida);
                        command.Parameters.Add(pObservacionMedida);
                        command.Parameters.Add(pProteccionTemporal);
                        command.Parameters.Add(pExtensivaHijos);
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

        //  public Respuesta ActualizarRegistro(InicioProceso obj)
        //  {
        //      Respuesta retorno = new Respuesta();
        //      retorno.FueExitosa = false;
        //      retorno.Mensaje = "validando...";

        //      try
        //      {
        //          using (SqlConnection con = new SqlConnection(connectionString))
        //          {
        //              con.Open();
        //              using (SqlCommand command = new SqlCommand(@"UPDATE InicioProceso SET Fecha = @pFecha,
        //,AutoQueAvocaConocimiento = @pAutoQueAvocaConocimiento,
        //,OpcionMedidasProteccion = @pOpcionMedidasProteccion, 
        //,MedidasProteccion = @pMedidasProteccion,
        //,OtraRelacionMedidaProteccion = @pOtraRelacionMedidaProteccion,
        //,SolicitudAmpliacionMedidas = @pSolicitudAmpliacionMedidas, 
        //,SolicitudAmpliacionMedidasFecha = @pSolicitudAmpliacionMedidasFecha,
        //,SolicitudAmpliacionMedidasSeOtorgaron = @pSolicitudAmpliacionMedidasSeOtorgaron, 
        //,RemisionFiscalia = @pRemisionFiscalia, 
        //,RemisionFiscaliaFecha = @pRemisionFiscaliaFecha,
        //,RemisionFiscaliaNumeroNoticiaCriminal = @pRemisionFiscaliaNumeroNoticiaCriminal,
        //,RemisionMedicinaLegal = @pRemisionMedicinaLegal, 
        //,RemisionMedicinaLegalFecha = @pRemisionMedicinaLegalFecha,
        //,RemisionMedicinaLegalInforme = @pRemisionMedicinaLegalInforme,
        //,RemisionEps = @pRemisionEps, 
        //,RemisionEpsFecha = @pRemisionEpsFecha,
        //,RemisionEpsTipo = @pRemisionEpsTipo,
        //,AcompañamientoComisaria = @pAcompañamientoComisaria, 
        //,AcompañamientoComisariaObservacion = @pAcompañamientoComisariaObservacion WHERE Id = @pId", con))
        //              {
        //                  SqlParameter pId = new SqlParameter("@pId", SqlDbType.VarChar);
        //                  SqlParameter pNombre = new SqlParameter("@pNombre", SqlDbType.VarChar);

        //                  pId.Value = id;
        //                  pNombre.Value = nombreGenero;

        //                  command.Parameters.Add(pId);
        //                  command.Parameters.Add(pNombre);

        //                  command.ExecuteNonQuery();
        //                  retorno.FueExitosa = true;
        //                  retorno.Mensaje = "Registro actualizado correctamente";

        //              }
        //              if (con.State == ConnectionState.Open)
        //              {
        //                  con.Dispose();
        //              }
        //          }

        //      }
        //      catch (Exception e)
        //      {
        //          retorno.FueExitosa = false;
        //          retorno.Mensaje = "Error en el servidor. Error: " + e.Message;
        //      }

        //      return retorno;

        //  }

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
                                                        FROM ActualizacionMedidasProteccion
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


        public ActualizacionMedidasProteccion ObtenerPorId(int id)
        {
            ActualizacionMedidasProteccion retorno = new ActualizacionMedidasProteccion();



            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"SELECT *
                                                        FROM ActualizacionMedidasProteccion
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
                retorno = new ActualizacionMedidasProteccion();
            }

            return retorno;



        }


    }
}
