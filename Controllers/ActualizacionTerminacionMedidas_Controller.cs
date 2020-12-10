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
                    using (SqlCommand command = new SqlCommand(@"INSERT INTO InicioProceso 
                                                                    (UsuarioId
                                                                       ,Fecha
                                                                       ,AutoQueAvocaConocimiento
                                                                       ,OpcionMedidasProteccion
                                                                       ,MedidasProteccion
                                                                       ,OtraRelacionMedidaProteccion
                                                                       ,SolicitudAmpliacionMedidas
                                                                       ,SolicitudAmpliacionMedidasFecha
                                                                       ,SolicitudAmpliacionMedidasSeOtorgaron
                                                                       ,RemisionFiscalia
                                                                       ,RemisionFiscaliaFecha
                                                                       ,RemisionFiscaliaNumeroNoticiaCriminal
                                                                       ,RemisionMedicinaLegal
                                                                       ,RemisionMedicinaLegalFecha
                                                                       ,RemisionMedicinaLegalInforme
                                                                       ,RemisionEps
                                                                       ,RemisionEpsFecha
                                                                       ,RemisionEpsTipo
                                                                       ,AcompañamientoComisaria
                                                                       ,AcompañamientoComisariaObservacion)
                                                            VALUES (@pUsuarioId
                                                                       ,@pFecha
                                                                       ,@pAutoQueAvocaConocimiento
                                                                       ,@pOpcionMedidasProteccion
                                                                       ,@pMedidasProteccion
                                                                       ,@pOtraRelacionMedidaProteccion
                                                                       ,@pSolicitudAmpliacionMedidas
                                                                       ,@pSolicitudAmpliacionMedidasFecha
                                                                       ,@pSolicitudAmpliacionMedidasSeOtorgaron
                                                                       ,@pRemisionFiscalia
                                                                       ,@pRemisionFiscaliaFecha
                                                                       ,@pRemisionFiscaliaNumeroNoticiaCriminal
                                                                       ,@pRemisionMedicinaLegal
                                                                       ,@pRemisionMedicinaLegalFecha
                                                                       ,@pRemisionMedicinaLegalInforme
                                                                       ,@pRemisionEps
                                                                       ,@pRemisionEpsFecha
                                                                       ,@pRemisionEpsTipo
                                                                       ,@pAcompañamientoComisaria
                                                                       ,@pAcompañamientoComisariaObservacion)", con))
                    {
                        SqlParameter pUsuarioId = new SqlParameter("@pUsuarioId", SqlDbType.Int);
                        SqlParameter pFecha = new SqlParameter("@pFecha", SqlDbType.Date);
                        SqlParameter pAutoQueAvocaConocimiento = new SqlParameter("@pAutoQueAvocaConocimiento", SqlDbType.VarChar);
                        SqlParameter pOpcionMedidasProteccion = new SqlParameter("@pOpcionMedidasProteccion", SqlDbType.VarChar);


                        SqlParameter pMedidasProteccion = new SqlParameter("@pMedidasProteccion", SqlDbType.VarChar);
                        SqlParameter pOtraRelacionMedidaProteccion = new SqlParameter("@pOtraRelacionMedidaProteccion", SqlDbType.VarChar);
                        SqlParameter pSolicitudAmpliacionMedidas = new SqlParameter("@pSolicitudAmpliacionMedidas", SqlDbType.VarChar);
                        SqlParameter pSolicitudAmpliacionMedidasFecha = new SqlParameter("@pSolicitudAmpliacionMedidasFecha", SqlDbType.Date);
                        SqlParameter pSolicitudAmpliacionMedidasSeOtorgaron = new SqlParameter("@pSolicitudAmpliacionMedidasSeOtorgaron", SqlDbType.VarChar);
                        SqlParameter pRemisionFiscalia = new SqlParameter("@pRemisionFiscalia", SqlDbType.VarChar);
                        SqlParameter pRemisionFiscaliaFecha = new SqlParameter("@pRemisionFiscaliaFecha", SqlDbType.Date);
                        SqlParameter pRemisionFiscaliaNumeroNoticiaCriminal = new SqlParameter("@pRemisionFiscaliaNumeroNoticiaCriminal", SqlDbType.VarChar);
                        SqlParameter pRemisionMedicinaLegal = new SqlParameter("@pRemisionMedicinaLegal", SqlDbType.VarChar);
                        SqlParameter pRemisionMedicinaLegalFecha = new SqlParameter("@pRemisionMedicinaLegalFecha", SqlDbType.Date);
                        SqlParameter pRemisionMedicinaLegalInforme = new SqlParameter("@pRemisionMedicinaLegalInforme", SqlDbType.VarChar);
                        SqlParameter pRemisionEps = new SqlParameter("@pRemisionEps", SqlDbType.VarChar);
                        SqlParameter pRemisionEpsFecha = new SqlParameter("@pRemisionEpsFecha", SqlDbType.Date);
                        SqlParameter pRemisionEpsTipo = new SqlParameter("@pRemisionEpsTipo", SqlDbType.VarChar);
                        SqlParameter pAcompañamientoComisaria = new SqlParameter("@pAcompañamientoComisaria", SqlDbType.VarChar);
                        SqlParameter pAcompañamientoComisariaObservacion = new SqlParameter("@pAcompañamientoComisariaObservacion", SqlDbType.VarChar);



                        pUsuarioId.Value = obj.UsuarioId;
                        pFecha.Value = obj.Fecha;
                        //pAutoQueAvocaConocimiento.Value = obj.AutoQueAvocaConocimiento;
                        //pOpcionMedidasProteccion.Value = obj.OpcionMedidasProteccion;
                        //pMedidasProteccion.Value = obj.MedidasProteccion;
                        //pOtraRelacionMedidaProteccion.Value = obj.OtraRelacionMedidaProteccion;
                        //pSolicitudAmpliacionMedidas.Value = obj.SolicitudAmpliacionMedidas;
                        //pSolicitudAmpliacionMedidasFecha.Value = obj.SolicitudAmpliacionMedidasFecha;
                        //pSolicitudAmpliacionMedidasSeOtorgaron.Value = obj.SolicitudAmpliacionMedidasSeOtorgaron;
                        //pRemisionFiscalia.Value = obj.RemisionFiscalia;
                        //pRemisionFiscaliaFecha.Value = obj.RemisionFiscaliaFecha;
                        //pRemisionFiscaliaNumeroNoticiaCriminal.Value = obj.RemisionFiscaliaNumeroNoticiaCriminal;
                        //pRemisionMedicinaLegal.Value = obj.RemisionMedicinaLegal;
                        //pRemisionMedicinaLegalFecha.Value = obj.RemisionMedicinaLegalFecha;
                        //pRemisionMedicinaLegalInforme.Value = obj.RemisionMedicinaLegalInforme;
                        //pRemisionEps.Value = obj.RemisionEps;
                        //pRemisionEpsFecha.Value = obj.RemisionEpsFecha;
                        //pRemisionEpsTipo.Value = obj.RemisionEpsTipo;
                        //pAcompañamientoComisaria.Value = obj.AcompañamientoComisaria;
                        //pAcompañamientoComisariaObservacion.Value = obj.AcompañamientoComisariaObservacion;



                        command.Parameters.Add(pUsuarioId);
                        command.Parameters.Add(pFecha);
                        command.Parameters.Add(pAutoQueAvocaConocimiento);
                        command.Parameters.Add(pOpcionMedidasProteccion);
                        command.Parameters.Add(pMedidasProteccion);
                        command.Parameters.Add(pOtraRelacionMedidaProteccion);
                        command.Parameters.Add(pSolicitudAmpliacionMedidas);
                        command.Parameters.Add(pSolicitudAmpliacionMedidasFecha);
                        command.Parameters.Add(pSolicitudAmpliacionMedidasSeOtorgaron);
                        command.Parameters.Add(pRemisionFiscalia);
                        command.Parameters.Add(pRemisionFiscaliaFecha);
                        command.Parameters.Add(pRemisionFiscaliaNumeroNoticiaCriminal);
                        command.Parameters.Add(pRemisionMedicinaLegal);
                        command.Parameters.Add(pRemisionMedicinaLegalFecha);
                        command.Parameters.Add(pRemisionMedicinaLegalInforme);
                        command.Parameters.Add(pRemisionEps);
                        command.Parameters.Add(pRemisionEpsFecha);
                        command.Parameters.Add(pRemisionEpsTipo);
                        command.Parameters.Add(pAcompañamientoComisaria);
                        command.Parameters.Add(pAcompañamientoComisariaObservacion);

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
                    using (SqlCommand command = new SqlCommand(@"SELECT Id
      ,UsuarioId
      ,Fecha
      ,AutoQueAvocaConocimiento 'Auto que avoca conocimiento'
      ,OpcionMedidasProteccion 'Opción medidas proteccion?'
      ,MedidasProteccion 'Medidas protección'
      ,OtraRelacionMedidaProteccion 'Otra Medida?'
      ,SolicitudAmpliacionMedidas 'Ampliación Medidas?'
      ,SolicitudAmpliacionMedidasFecha 'Ampliación Medidas fecha'
      ,SolicitudAmpliacionMedidasSeOtorgaron 'Se otorgaron?'
      ,RemisionFiscalia 'Remisión a fiscalía?'
      ,RemisionFiscaliaFecha 'Fecha fiscalía'
      ,RemisionFiscaliaNumeroNoticiaCriminal 'Noticia criminal'
      ,RemisionMedicinaLegal   'Remisión a medicina legal?'
      ,RemisionMedicinaLegalFecha 'Fecha medicina legal' 
      ,RemisionMedicinaLegalInforme 'Informe'
      ,RemisionEps 'Remisión a EPS?'
      ,RemisionEpsFecha 'Fecha eps'
      ,RemisionEpsTipo 'Tipo'
      ,AcompañamientoComisaria  'Acompañamiento comisaria?'
      ,AcompañamientoComisariaObservacion 'Observación'
                                                        FROM InicioProceso
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
                                                        FROM InicioProceso
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
