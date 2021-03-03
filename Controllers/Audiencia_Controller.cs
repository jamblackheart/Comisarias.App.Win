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
    public class Audiencia_Controller
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

        public Respuesta AgregarRegistro(Audiencia obj)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";



            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"INSERT INTO Audiencias 
                                                                    (UsuarioId
                                                                       ,Fecha
                                                                       ,SeRealizo
                                                                       ,PorqueNoSeRealizo
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
                                                                       ,NoConfrontacionConElAgresor
                                                                       ,AcuerdosPrevios
                                                                       ,AcuerdosPreviosCuales
                                                                       ,AcuerdosPreviosCualesOtra
                                                                       ,Archivo
                                                                       ,OtorgaMedidasProteccion
                                                                       ,OtorgaMedidasProteccionCuales
                                                                       ,OtorgaMedidasProteccionCualesOtra
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
                                                                   ,@pSeRealizo
                                                                   ,@pPorqueNoSeRealizo
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
                                                                   ,@pNoConfrontacionConElAgresor
                                                                   ,@pAcuerdosPrevios
                                                                   ,@pAcuerdosPreviosCuales
                                                                   ,@pAcuerdosPreviosCualesOtra
                                                                   ,@pArchivo
                                                                   ,@pOtorgaMedidasProteccion
                                                                   ,@pOtorgaMedidasProteccionCuales
                                                                   ,@pOtorgaMedidasProteccionCualesOtra
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

                        SqlParameter pSeRealizo = new SqlParameter("@pSeRealizo", SqlDbType.VarChar);
                        SqlParameter pPorqueNoSeRealizo = new SqlParameter("@pPorqueNoSeRealizo", SqlDbType.VarChar);
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

                        SqlParameter pNoConfrontacionConElAgresor = new SqlParameter("@pNoConfrontacionConElAgresor", SqlDbType.VarChar);
                        SqlParameter pAcuerdosPrevios = new SqlParameter("@pAcuerdosPrevios", SqlDbType.VarChar);
                        SqlParameter pAcuerdosPreviosCuales = new SqlParameter("@pAcuerdosPreviosCuales", SqlDbType.VarChar);
                        SqlParameter pAcuerdosPreviosCualesOtra = new SqlParameter("@pAcuerdosPreviosCualesOtra", SqlDbType.VarChar);
                        SqlParameter pArchivo = new SqlParameter("@pArchivo", SqlDbType.VarChar);
                        SqlParameter pOtorgaMedidasProteccion = new SqlParameter("@pOtorgaMedidasProteccion", SqlDbType.VarChar);
                        SqlParameter pOtorgaMedidasProteccionCuales = new SqlParameter("@pOtorgaMedidasProteccionCuales", SqlDbType.VarChar);
                        SqlParameter pOtorgaMedidasProteccionCualesOtra = new SqlParameter("@pOtorgaMedidasProteccionCualesOtra", SqlDbType.VarChar);
                       
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

                        pSeRealizo.Value = obj.SeRealizo;
                        pPorqueNoSeRealizo.Value = obj.PorqueNoSeRealizo;
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

                        pNoConfrontacionConElAgresor.Value = obj.NoConfrontacionConElAgresor;
                        pAcuerdosPrevios.Value = obj.AcuerdosPrevios;
                        pAcuerdosPreviosCuales.Value = obj.AcuerdosPreviosCuales;
                        pAcuerdosPreviosCualesOtra.Value = obj.AcuerdosPreviosCualesOtra;
                        pArchivo.Value = obj.Archivo;
                        pOtorgaMedidasProteccion.Value = obj.OtorgaMedidasProteccion;
                        pOtorgaMedidasProteccionCuales.Value = obj.OtorgaMedidasProteccionCuales;
                        pOtorgaMedidasProteccionCualesOtra.Value = obj.OtorgaMedidasProteccionCualesOtra;

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
                        command.Parameters.Add(pSeRealizo);         
                        command.Parameters.Add(pPorqueNoSeRealizo); 
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

                        command.Parameters.Add(pNoConfrontacionConElAgresor);  
                        command.Parameters.Add(pAcuerdosPrevios);         
                        command.Parameters.Add(pAcuerdosPreviosCuales);   
                        command.Parameters.Add(pAcuerdosPreviosCualesOtra); 
                        command.Parameters.Add(pArchivo);         
                        command.Parameters.Add(pOtorgaMedidasProteccion);
                        command.Parameters.Add(pOtorgaMedidasProteccionCuales);
                        command.Parameters.Add(pOtorgaMedidasProteccionCualesOtra);       

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
                                                        FROM Audiencias
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


        public Audiencia ObtenerPorId(int id)
        {
            Audiencia retorno = new Audiencia();



            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"SELECT *
                                                        FROM Audiencias
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
                                //retorno.AutoQueAvocaConocimiento = reader["AutoQueAvocaConocimiento"].ToString();
                                //retorno.OpcionMedidasProteccion = reader["OpcionMedidasProteccion"].ToString();
                                //retorno.MedidasProteccion = reader["MedidasProteccion"].ToString();
                                //retorno.OtraRelacionMedidaProteccion = reader["OtraRelacionMedidaProteccion"].ToString();
                                //retorno.SolicitudAmpliacionMedidas = reader["SolicitudAmpliacionMedidas"].ToString();
                               
                                //tFecha = DateTime.MinValue;
                                //ttFecha = reader["SolicitudAmpliacionMedidasFecha"].ToString();
                                //DateTime.TryParse(ttFecha, out tFecha);
                                //retorno.SolicitudAmpliacionMedidasFecha = tFecha;

                                //retorno.SolicitudAmpliacionMedidasSeOtorgaron = reader["SolicitudAmpliacionMedidasSeOtorgaron"].ToString();
                                //retorno.RemisionFiscalia = reader["RemisionFiscalia"].ToString();

                                //tFecha = DateTime.MinValue;
                                //ttFecha = reader["RemisionFiscaliaFecha"].ToString();
                                //DateTime.TryParse(ttFecha, out tFecha);
                                //retorno.RemisionFiscaliaFecha = tFecha;

                                //retorno.RemisionFiscaliaNumeroNoticiaCriminal = reader["RemisionFiscaliaNumeroNoticiaCriminal"].ToString();
                                //retorno.RemisionMedicinaLegal = reader["RemisionMedicinaLegal"].ToString();

                                //tFecha = DateTime.MinValue;
                                //ttFecha = reader["RemisionMedicinaLegalFecha"].ToString();
                                //DateTime.TryParse(ttFecha, out tFecha);
                                //retorno.RemisionMedicinaLegalFecha = tFecha;
                               
                                
                                //retorno.RemisionMedicinaLegalInforme = reader["RemisionMedicinaLegalInforme"].ToString();
                                //retorno.RemisionEps = reader["RemisionEps"].ToString();


                                //tFecha = DateTime.MinValue;
                                //ttFecha = reader["RemisionEpsFecha"].ToString();
                                //DateTime.TryParse(ttFecha, out tFecha);
                                //retorno.RemisionEpsFecha = tFecha;

                                //retorno.RemisionEpsTipo = reader["RemisionEpsTipo"].ToString();
                                //retorno.AcompañamientoComisaria = reader["AcompañamientoComisaria"].ToString();
                                //retorno.AcompañamientoComisariaObservacion = reader["AcompañamientoComisariaObservacion"].ToString();


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
                retorno = new Audiencia();
            }

            return retorno;



        }


    }
}
