using Comisarias.App.Escritorio.Models;
using Comisarias.App.Escritorio.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using static Comisarias.App.Escritorio.Models.AuthUser;

namespace Comisarias.App.Escritorio.Services
{
    public class ApiRestAuth
    {
        #region validate user ValidateUserViewModel from nit
        public static string ValidateUserAsync(ValidateUserViewModel model)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppPointer.POINTER_ROOT);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    var response = client.PostAsJsonAsync(AppPointer.VALIDIATE_USER, model).Result;

                    string res = "";
                    using (HttpContent content = response.Content)
                    {
                        // ... Read the string.
                        Task<string> result = content.ReadAsStringAsync();
                        res = result.Result;
                    }

                    return res;

                }
                catch (Exception e)
                {

                    return "Error con el servicio de autenticación";
                }
                
                
            }

        }
        #endregion
        #region login from LoginViewModel
        public static string LoginAsync(LoginViewModel model)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppPointer.POINTER_ROOT);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsJsonAsync(AppPointer.LOGIN, model).Result;
                string res = "";
                using (HttpContent content = response.Content)
                {
                    // ... Read the string.
                    Task<string> result = content.ReadAsStringAsync();
                    res = result.Result;
                }

                return res;
            }

        }
        #endregion
        #region asignar  huella usuarui
        public static string CrearHuellaUsuarioAsync(ViewModelHuellaUsuario model)
        {
            string res = "";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppPointer.POINTER_ROOT);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsJsonAsync(AppPointer.CREAR_HUELLA, model).Result;


                using (HttpContent content = response.Content)
                {
                    // ... Read the string.
                    Task<string> result = content.ReadAsStringAsync();
                    res = result.Result;
                }

            }
            return res;

        }
        #endregion
        #region create user test
        public static RespuestaEnvioDeDatos RegisterAsync(RegisterDesktopViewModel model)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppPointer.POINTER_ROOT);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync(AppPointer.REGISTER, model).Result;
                var respuesta = new RespuestaEnvioDeDatos();
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        // ... Read the string.
                        Task<string> result = content.ReadAsStringAsync();
                        respuesta.contentRequest = result.Result;
                        respuesta.Codigo = 201;
                        respuesta.Mensaje = "Registro creado correctamente!";
                    }
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    respuesta.contentRequest = "";
                    respuesta.Codigo = 400;
                    respuesta.Mensaje = "Datos enviados con error! Campos requeridos";
                }
                else if (response.StatusCode == HttpStatusCode.InternalServerError)
                {
                    respuesta.contentRequest = "";
                    respuesta.Codigo = 500;
                    respuesta.Mensaje = "Error interno en el servidor";
                }

                return respuesta;
            }

        }
        #endregion
    }
}
