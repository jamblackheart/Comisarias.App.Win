﻿using System;
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

        public Respuesta AgregarRegistro(Agresion objAgresion)
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
                                                                    DocumentoAgresor,RelacionAgresorId,OtraRelacionAgresor,
                                                                    DireccionDomicilioAgresor,Radicado,CuentaMedidasProteccion,
                                                                    MedidaProteccionId,CualOtraMedidaProteccion)
                                                            VALUES (@pUsuarioId,@pFecha,@pNombreAgresor,
                                                                    @pDocumentoAgresor,@pRelacionAgresorId,@pOtraRelacionAgresor,
                                                                    @pDireccionDomicilioAgresor,@pRadicado,@pCuentaMedidasProteccion,
                                                                    @pMedidaProteccionId,@pCualOtraMedidaProteccion)", con))
                    {
                        SqlParameter pUsuarioId = new SqlParameter("@pUsuarioId", SqlDbType.Int);
                        SqlParameter pFecha = new SqlParameter("@pFecha", SqlDbType.Date);
                        SqlParameter pNombreAgresor = new SqlParameter("@pNombreAgresor", SqlDbType.VarChar);
                        SqlParameter pDocumentoAgresor = new SqlParameter("@pDocumentoAgresor", SqlDbType.VarChar);
                        SqlParameter pRelacionAgresorId = new SqlParameter("@pRelacionAgresorId", SqlDbType.Int);
                        SqlParameter pOtraRelacionAgresor = new SqlParameter("@pOtraRelacionAgresor", SqlDbType.VarChar);
                        SqlParameter pDireccionDomicilioAgresor = new SqlParameter("@pDireccionDomicilioAgresor", SqlDbType.VarChar);
                        SqlParameter pRadicado = new SqlParameter("@pRadicado", SqlDbType.VarChar);
                        SqlParameter pCuentaMedidasProteccion = new SqlParameter("@pCuentaMedidasProteccion", SqlDbType.Bit);
                        SqlParameter pMedidaProteccionId = new SqlParameter("@pMedidaProteccionId", SqlDbType.Int);
                        SqlParameter pCualOtraMedidaProteccion = new SqlParameter("@pCualOtraMedidaProteccion", SqlDbType.VarChar);

                        pUsuarioId.Value = objAgresion.UsuarioId;
                        pFecha.Value = objAgresion.Fecha;
                        pNombreAgresor.Value = objAgresion.NombreAgresor;
                        pDocumentoAgresor.Value = objAgresion.DocumentoAgresor;
                       // pRelacionAgresorId.Value = objAgresion.RelacionAgresorId;
                        pOtraRelacionAgresor.Value = objAgresion.OtraRelacionAgresor;
                        pDireccionDomicilioAgresor.Value = objAgresion.DireccionDomicilioAgresor;
                        pRadicado.Value = objAgresion.Radicado;
                        pCuentaMedidasProteccion.Value = objAgresion.CuentaMedidasProteccion;
                     //   pMedidaProteccionId.Value = objAgresion.MedidaProteccionId;
                        pCualOtraMedidaProteccion.Value = objAgresion.CualOtraMedidaProteccion;

                        command.Parameters.Add(pUsuarioId);
                        command.Parameters.Add(pFecha);
                        command.Parameters.Add(pNombreAgresor);
                        command.Parameters.Add(pDocumentoAgresor);
                        command.Parameters.Add(pRelacionAgresorId);
                        command.Parameters.Add(pOtraRelacionAgresor);
                        command.Parameters.Add(pDireccionDomicilioAgresor);
                        command.Parameters.Add(pRadicado);
                        command.Parameters.Add(pCuentaMedidasProteccion);
                        command.Parameters.Add(pMedidaProteccionId);
                        command.Parameters.Add(pCualOtraMedidaProteccion);


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