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
    public class Agresion_Controller
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

        public Respuesta AgregarRegistro(Agresion obj)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";



            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"INSERT INTO Agresion 
                                                                    (UsuarioId,Fecha,NombreAgresor,
                                                                    DocumentoAgresor,RelacionAgresor,OtraRelacionAgresor,
                                                                    DireccionDomicilioAgresor,Radicado,CuentaMedidasProteccion,
                                                                    CualOtraMedidaProteccion, MedidasProteccion)
                                                            VALUES (@pUsuarioId,@pFecha,@pNombreAgresor,
                                                                    @pDocumentoAgresor,@pRelacionAgresor,@pOtraRelacionAgresor,
                                                                    @pDireccionDomicilioAgresor,@pRadicado,@pCuentaMedidasProteccion,
                                                                    @pCualOtraMedidaProteccion, @pMedidasProteccion)", con))
                    {
                        SqlParameter pUsuarioId = new SqlParameter("@pUsuarioId", SqlDbType.Int);
                        SqlParameter pFecha = new SqlParameter("@pFecha", SqlDbType.Date);
                        SqlParameter pNombreAgresor = new SqlParameter("@pNombreAgresor", SqlDbType.VarChar);
                        SqlParameter pDocumentoAgresor = new SqlParameter("@pDocumentoAgresor", SqlDbType.VarChar);
                        SqlParameter pRelacionAgresor = new SqlParameter("@pRelacionAgresor", SqlDbType.VarChar);
                        SqlParameter pOtraRelacionAgresor = new SqlParameter("@pOtraRelacionAgresor", SqlDbType.VarChar);
                        SqlParameter pDireccionDomicilioAgresor = new SqlParameter("@pDireccionDomicilioAgresor", SqlDbType.VarChar);
                        SqlParameter pRadicado = new SqlParameter("@pRadicado", SqlDbType.VarChar);
                        SqlParameter pCuentaMedidasProteccion = new SqlParameter("@pCuentaMedidasProteccion", SqlDbType.VarChar);                     
                        SqlParameter pCualOtraMedidaProteccion = new SqlParameter("@pCualOtraMedidaProteccion", SqlDbType.VarChar);
                        SqlParameter pMedidasProteccion = new SqlParameter("@pMedidasProteccion", SqlDbType.VarChar);

                        pUsuarioId.Value = obj.UsuarioId;
                        pFecha.Value = obj.Fecha;
                        pNombreAgresor.Value = obj.NombreAgresor;
                        pDocumentoAgresor.Value = obj.DocumentoAgresor;
                        pRelacionAgresor.Value = obj.RelacionAgresor;
                        pOtraRelacionAgresor.Value = obj.OtraRelacionAgresor;
                        pDireccionDomicilioAgresor.Value = obj.DireccionDomicilioAgresor;
                        pRadicado.Value = obj.Radicado;
                        pCuentaMedidasProteccion.Value = obj.CuentaMedidasProteccion;
                        pCualOtraMedidaProteccion.Value = obj.CualOtraMedidaProteccion;
                        pMedidasProteccion.Value = obj.MedidasProteccion;

                        command.Parameters.Add(pUsuarioId);
                        command.Parameters.Add(pFecha);
                        command.Parameters.Add(pNombreAgresor);
                        command.Parameters.Add(pDocumentoAgresor);
                        command.Parameters.Add(pRelacionAgresor);
                        command.Parameters.Add(pOtraRelacionAgresor);
                        command.Parameters.Add(pDireccionDomicilioAgresor);
                        command.Parameters.Add(pRadicado);
                        command.Parameters.Add(pCuentaMedidasProteccion);
                        command.Parameters.Add(pCualOtraMedidaProteccion);
                        command.Parameters.Add(pMedidasProteccion);


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
      ,NombreAgresor 'Agresor'
      ,DocumentoAgresor 'Documento'
      ,RelacionAgresor 'Relación'
      ,OtraRelacionAgresor 'Otra'
      ,DireccionDomicilioAgresor 'Dirección'
      ,Radicado
      ,CuentaMedidasProteccion 'Medidas de proteccion?'
      ,MedidasProteccion 'Medidas Protección'
      ,CualOtraMedidaProteccion 'Otra medida'
                                                        FROM Agresion
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
