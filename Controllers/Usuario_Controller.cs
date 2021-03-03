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
    public class Usuario_Controller
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
                    using (SqlCommand command = new SqlCommand(@"SELECT * FROM Usuario", con))
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
                    using (SqlCommand command = new SqlCommand(@"DELETE  Usuario WHERE Id = @pId", con))
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

        public Respuesta AgregarRegistro(Usuario usuario)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@" INSERT 
                                                                    INTO Usuario (
                                                                                   FechaNacimiento,Nombres,Apellidos,
                                                                                   GeneroId,Area,Direccion,
                                                                                   Telefono,Correo,PerteneceEtnia,
                                                                                   CualEtnia,Discapacidad,CualDiscapacidad,
                                                                                   VictimaConflictoArmado,Documento, HijosMenores)  
                                                                           VALUES (@pFechaNacimiento,@pNombres,@pApellidos,
                                                                                   @pGeneroId,@pArea,@pDireccion,
                                                                                   @pTelefono,@pCorreo,@pPerteneceEtnia,
                                                                                   @pCualEtnia,@pDiscapacidad,@pCualDiscapacidad,
                                                                                   @pVictimaConflictoArmado,@pDocumento, @pHijosMenores)", con))
                    {


                      

                        SqlParameter pNombreMotivo = new SqlParameter("@pNombreMotivo", SqlDbType.VarChar);
                        SqlParameter pFechaNacimiento = new SqlParameter("@pFechaNacimiento", SqlDbType.DateTime);
                        SqlParameter pNombres = new SqlParameter("@pNombres", SqlDbType.VarChar);
                        SqlParameter pApellidos = new SqlParameter("@pApellidos", SqlDbType.VarChar);
                        SqlParameter pGeneroId = new SqlParameter("@pGeneroId", SqlDbType.VarChar);
                        SqlParameter pArea = new SqlParameter("@pArea", SqlDbType.VarChar);
                        SqlParameter pDireccion = new SqlParameter("@pDireccion", SqlDbType.VarChar);
                        SqlParameter pTelefono = new SqlParameter("@pTelefono", SqlDbType.VarChar);
                        SqlParameter pCorreo = new SqlParameter("@pCorreo", SqlDbType.VarChar);
                        SqlParameter pPerteneceEtnia = new SqlParameter("@pPerteneceEtnia", SqlDbType.VarChar);
                        SqlParameter pCualEtnia = new SqlParameter("@pCualEtnia", SqlDbType.VarChar);
                        SqlParameter pDiscapacidad = new SqlParameter("@pDiscapacidad", SqlDbType.VarChar);
                        SqlParameter pCualDiscapacidad = new SqlParameter("@pCualDiscapacidad", SqlDbType.VarChar);
                        SqlParameter pVictimaConflictoArmado = new SqlParameter("@pVictimaConflictoArmado", SqlDbType.VarChar);
                        SqlParameter pDocumento = new SqlParameter("@pDocumento", SqlDbType.VarChar);
                        SqlParameter pHijosMenores = new SqlParameter("@pHijosMenores", SqlDbType.VarChar);


                        pFechaNacimiento.Value = usuario.FechaNacimiento;
                        pNombres.Value = usuario.Nombres;
                        pApellidos.Value = usuario.Apellidos;
                        pGeneroId.Value = usuario.GeneroId;
                        pArea.Value = usuario.Area;
                        pDireccion.Value = usuario.Direccion;
                        pTelefono.Value = usuario.Telefono;
                        pCorreo.Value = usuario.Correo;
                        pPerteneceEtnia.Value = usuario.PerteneceEtnia;
                        pCualEtnia.Value = usuario.CualEtnia;
                        pDiscapacidad.Value = usuario.Discapacidad;
                        pCualDiscapacidad.Value = usuario.CualDiscapacidad;
                        pVictimaConflictoArmado.Value = usuario.VictimaConflictoArmado;
                        pDocumento.Value = usuario.Documento;
                        pHijosMenores.Value = usuario.HijosMenores;

                        command.Parameters.Add(pFechaNacimiento);
                        command.Parameters.Add(pNombres);
                        command.Parameters.Add(pApellidos);
                        command.Parameters.Add(pGeneroId);
                        command.Parameters.Add(pArea);
                        command.Parameters.Add(pDireccion);
                        command.Parameters.Add(pTelefono);
                        command.Parameters.Add(pCorreo);
                        command.Parameters.Add(pPerteneceEtnia);
                        command.Parameters.Add(pCualEtnia);
                        command.Parameters.Add(pDiscapacidad);
                        command.Parameters.Add(pCualDiscapacidad);
                        command.Parameters.Add(pVictimaConflictoArmado);
                        command.Parameters.Add(pDocumento);
                        command.Parameters.Add(pHijosMenores);




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

        public Respuesta ActualizarRegistro(Usuario usuario)
        {
            Respuesta retorno = new Respuesta();
            retorno.FueExitosa = false;
            retorno.Mensaje = "validando...";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"UPDATE Usuario 
                                                                    SET FechaNacimiento=@pFechaNacimiento,
                                                                        Nombres=@pNombres,
                                                                        Apellidos=@pApellidos,
                                                                        GeneroId=@pGeneroId,
                                                                        Area=@pArea,
                                                                        Direccion=@pDireccion,
                                                                        Telefono=@pTelefono,
                                                                        Correo=@pCorreo,
                                                                        PerteneceEtnia=@pPerteneceEtnia,
                                                                        CualEtnia=@pCualEtnia,
                                                                        Discapacidad=@pDiscapacidad,
                                                                        CualDiscapacidad=@pCualDiscapacidad,
                                                                        VictimaConflictoArmado=@pVictimaConflictoArmado,
                                                                        Documento= @pDocumento,
                                                                        HijosMenores= @pHijosMenores

                                                                WHERE Id = @pId", con))
                    {
                        SqlParameter pId = new SqlParameter("@pId", SqlDbType.VarChar);
                        SqlParameter pNombreMotivo = new SqlParameter("@pNombreMotivo", SqlDbType.VarChar);
                        SqlParameter pFechaNacimiento = new SqlParameter("@pFechaNacimiento", SqlDbType.DateTime);
                        SqlParameter pNombres = new SqlParameter("@pNombres", SqlDbType.VarChar);
                        SqlParameter pApellidos = new SqlParameter("@pApellidos", SqlDbType.VarChar);
                        SqlParameter pGeneroId = new SqlParameter("@pGeneroId", SqlDbType.VarChar);
                        SqlParameter pArea = new SqlParameter("@pArea", SqlDbType.VarChar);
                        SqlParameter pDireccion = new SqlParameter("@pDireccion", SqlDbType.VarChar);
                        SqlParameter pTelefono = new SqlParameter("@pTelefono", SqlDbType.VarChar);
                        SqlParameter pCorreo = new SqlParameter("@pCorreo", SqlDbType.VarChar);
                        SqlParameter pPerteneceEtnia = new SqlParameter("@pPerteneceEtnia", SqlDbType.VarChar);
                        SqlParameter pCualEtnia = new SqlParameter("@pCualEtnia", SqlDbType.VarChar);
                        SqlParameter pDiscapacidad = new SqlParameter("@pDiscapacidad", SqlDbType.VarChar);
                        SqlParameter pCualDiscapacidad = new SqlParameter("@pCualDiscapacidad", SqlDbType.VarChar);
                        SqlParameter pVictimaConflictoArmado = new SqlParameter("@pVictimaConflictoArmado", SqlDbType.VarChar);
                        SqlParameter pDocumento = new SqlParameter("@pDocumento", SqlDbType.VarChar);
                        SqlParameter pHijosMenores = new SqlParameter("@pHijosMenores", SqlDbType.VarChar);


                        pId.Value = usuario.Id;
                        pFechaNacimiento.Value = usuario.FechaNacimiento;
                        pNombres.Value = usuario.Nombres;
                        pApellidos.Value = usuario.Apellidos;
                        pGeneroId.Value = usuario.GeneroId;
                        pArea.Value = usuario.Area;
                        pDireccion.Value = usuario.Direccion;
                        pTelefono.Value = usuario.Telefono;
                        pCorreo.Value = usuario.Correo;
                        pPerteneceEtnia.Value = usuario.PerteneceEtnia;
                        pCualEtnia.Value = usuario.CualEtnia;
                        pDiscapacidad.Value = usuario.Discapacidad;
                        pCualDiscapacidad.Value = usuario.CualDiscapacidad;
                        pVictimaConflictoArmado.Value = usuario.VictimaConflictoArmado;
                        pDocumento.Value = usuario.Documento;
                        pHijosMenores.Value = usuario.HijosMenores;

                        command.Parameters.Add(pId);
                        command.Parameters.Add(pFechaNacimiento);
                        command.Parameters.Add(pNombres);
                        command.Parameters.Add(pApellidos);
                        command.Parameters.Add(pGeneroId);
                        command.Parameters.Add(pArea);
                        command.Parameters.Add(pDireccion);
                        command.Parameters.Add(pTelefono);
                        command.Parameters.Add(pCorreo);
                        command.Parameters.Add(pPerteneceEtnia);
                        command.Parameters.Add(pCualEtnia);
                        command.Parameters.Add(pDiscapacidad);
                        command.Parameters.Add(pCualDiscapacidad);
                        command.Parameters.Add(pVictimaConflictoArmado);
                        command.Parameters.Add(pDocumento);
                        command.Parameters.Add(pHijosMenores);

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

        public Usuario ObtenerUsuarioPorDocumento(string Documento) {
            Usuario retorno = new Usuario();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(@"SELECT Usuario.*, Genero.Nombre NombreGenero
                                                        FROM Usuario LEFT JOIN Genero On Usuario.GeneroId = Genero.Id
                                                   WHERE Documento = @pDocumento", con))
                {
                    SqlParameter pDocumento = new SqlParameter("@pDocumento", SqlDbType.VarChar);

                    pDocumento.Value = Documento;
                    command.Parameters.Add(pDocumento);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            retorno.Id = (int)reader["Id"];


                            retorno.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);  
                            retorno.Nombres = reader["Nombres"].ToString(); 
                            retorno.Apellidos = reader["Apellidos"].ToString();
                            retorno.GeneroId = (int)reader["GeneroId"];
                            retorno.Genero = reader["NombreGenero"].ToString();                            
                            retorno.Area = reader["Area"].ToString();
                            retorno.Direccion = reader["Direccion"].ToString();
                            retorno.Telefono = reader["Telefono"].ToString();
                            retorno.Correo = reader["Correo"].ToString();
                            retorno.PerteneceEtnia = (Boolean)reader["PerteneceEtnia"];
                            retorno.CualEtnia = reader["CualEtnia"].ToString();
                            retorno.Discapacidad = (Boolean)reader["Discapacidad"];
                            retorno.CualDiscapacidad = reader["CualDiscapacidad"].ToString();
                            retorno.VictimaConflictoArmado = (Boolean)reader["VictimaConflictoArmado"];
                            retorno.Documento = reader["Documento"].ToString();
                            retorno.HijosMenores = reader["HijosMenores"].ToString();


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

        private List<string> ObtenerRolesUsuario(string funcionario)
        {
            List<string> retorno = new List<string>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(@"SELECT Rol.Nombre
                                                        FROM Rol
                                                  INNER JOIN FuncionarioRoles
                                                          ON FuncionarioRoles.IdRol = Rol.Id
                                                         AND FuncionarioRoles.IdFuncionario = @Funcionario", con))
                {
                    SqlParameter pfuncionario = new SqlParameter("@Funcionario", SqlDbType.VarChar);

                    pfuncionario.Value = funcionario;
                    command.Parameters.Add(pfuncionario);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            retorno.Add(reader.GetString(0).ToString());
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
