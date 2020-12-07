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
    public class Orientacion_Controller
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

        public Respuesta AgregarRegistro(Orientacion obj)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";



            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"INSERT INTO Orientacion 
                                                                    (UsuarioId
                                                                       ,Fecha
                                                                       ,Responsable
                                                                       ,TipoOrientacion
                                                                      )
                                                            VALUES (@pUsuarioId
                                                                       ,@pFecha
                                                                       ,@pResponsable
                                                                       ,@pTipoOrientacion)", con))
                    {
                        SqlParameter pUsuarioId = new SqlParameter("@pUsuarioId", SqlDbType.Int);
                        SqlParameter pFecha = new SqlParameter("@pFecha", SqlDbType.Date);
                        SqlParameter pResponsable = new SqlParameter("@pResponsable", SqlDbType.VarChar);
                        SqlParameter pTipoOrientacion = new SqlParameter("@pTipoOrientacion", SqlDbType.VarChar);


                        pUsuarioId.Value = obj.UsuarioId;
                        pFecha.Value = obj.Fecha;
                        pResponsable.Value = obj.Responsable;
                        pTipoOrientacion.Value = obj.TipoOrientacion;

                        command.Parameters.Add(pUsuarioId);
                        command.Parameters.Add(pFecha);
                        command.Parameters.Add(pResponsable);
                        command.Parameters.Add(pTipoOrientacion);


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
      ,Fecha
      ,UsuarioId
      ,Responsable
      ,TipoOrientacion 'Tipo orientación'
                                                        FROM Orientacion
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


        public InicioProceso ObtenerPorId(int id)
        {
            InicioProceso retorno = new InicioProceso();



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
                retorno = new InicioProceso();
            }

            return retorno;



        }


    }
}
