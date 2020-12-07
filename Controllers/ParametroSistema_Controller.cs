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
    public class ParametroSistema_Controller
    {
        string connectionString =
            Comisarias.App.Escritorio.Properties.Settings.Default.dbComisariaConnectionString;



        public Respuesta ActualizarRegistro(ParametroSistema parametros)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"UPDATE Parametros 
                                                                    SET Nombre=@pNombre,
                                                                       
                                                                        Departamento=@pDepartamento,
                                                                        Municipio=@pMunicipio,
                                                                       
                                                                        RutaDocumentos = @pRutaDocumentos
                                                                WHERE Id = @pId", con))
                    {
                        SqlParameter pId = new SqlParameter("@pId", SqlDbType.VarChar);
                        SqlParameter pNombre = new SqlParameter("@pNombre", SqlDbType.VarChar);
                        SqlParameter pLogo = new SqlParameter("@pLogo", SqlDbType.VarChar);
                        SqlParameter pDepartamento = new SqlParameter("@pDepartamento", SqlDbType.VarChar);
                        SqlParameter pMunicipio = new SqlParameter("@pMunicipio", SqlDbType.VarChar);
                        SqlParameter pBaseDatos = new SqlParameter("@pBaseDatos", SqlDbType.VarChar);
                        SqlParameter pRutaDocumentos = new SqlParameter("@pRutaDocumentos", SqlDbType.VarChar);

                        pId.Value = parametros.Id;
                        pNombre.Value = parametros.Nombre;
                      
                        pDepartamento.Value = parametros.Departamento;
                        pMunicipio.Value = parametros.Municipio;
                       
                        pRutaDocumentos.Value = parametros.RutaDocumentos;



                        command.Parameters.Add(pId);
                        command.Parameters.Add(pNombre);
                       
                        command.Parameters.Add(pDepartamento);
                        command.Parameters.Add(pMunicipio);
                       
                        command.Parameters.Add(pRutaDocumentos);

                        try
                        {
                            command.ExecuteNonQuery();
                            retorno.FueExitosa = true;
                            retorno.Mensaje = "Registro actualizado correctamente";
                        }
                        catch (Exception e)
                        {
                            retorno.FueExitosa = false;
                            retorno.Mensaje = "Error al actualizar: " + e.Message;
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

        public ParametroSistema ObtenerParametrosSistema()
        {
            ParametroSistema retorno = new ParametroSistema();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(@"SELECT TOP 1 * 
                                                        FROM Parametros", con))
                {


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            retorno.Id = (int)reader["Id"];


                            retorno.Nombre = reader["Nombre"].ToString();
                           
                            retorno.Departamento = reader["Departamento"].ToString();
                            retorno.Municipio = reader["Municipio"].ToString();
                         
                            retorno.RutaDocumentos = reader["RutaDocumentos"].ToString();



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
