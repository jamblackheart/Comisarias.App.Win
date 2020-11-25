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
                                                                        Logo=@pLogo,
                                                                        Departamento=@pDepartamento,
                                                                        Municipio=@pMunicipio,
                                                                        BaseDatos=@pBaseDatos
                                                                WHERE Id = @pId", con))
                    {
                        SqlParameter pId = new SqlParameter("@pId", SqlDbType.VarChar);
                        SqlParameter pNombre = new SqlParameter("@pNombre", SqlDbType.VarChar);
                        SqlParameter pLogo = new SqlParameter("@pLogo", SqlDbType.DateTime);
                        SqlParameter pDepartamento = new SqlParameter("@pDepartamento", SqlDbType.VarChar);
                        SqlParameter pMunicipio = new SqlParameter("@pMunicipio", SqlDbType.VarChar);
                        SqlParameter pBaseDatos = new SqlParameter("@pBaseDatos", SqlDbType.VarChar);
                        
                        pId.Value = parametros.Id;
                        pNombre.Value = parametros.Nombre;
                        pLogo.Value = parametros.Logo;
                        pDepartamento.Value = parametros.Departamento;
                        pMunicipio.Value = parametros.Municipio;
                        pBaseDatos.Value = parametros.BaseDatos;
                        

                        command.Parameters.Add(pId);
                        command.Parameters.Add(pNombre);
                        command.Parameters.Add(pLogo);
                        command.Parameters.Add(pDepartamento);
                        command.Parameters.Add(pMunicipio);
                        command.Parameters.Add(pBaseDatos);
                        

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

        public ParametroSistema ObtenerParametrosSistema() {
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
                            retorno.Logo = reader["Logo"].ToString(); 
                            retorno.Departamento = reader["Departamento"].ToString();
                            retorno.Municipio = reader["Municipio"].ToString();
                            retorno.BaseDatos = reader["BaseDatos"].ToString();                            
                           


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
