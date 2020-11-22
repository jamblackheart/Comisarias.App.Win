using Comisarias.App.Escritorio.Models;
using Comisarias.App.Escritorio.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Services
{
   public class ApiRestBarequero
    {
        #region crear barequero

        public static RespuestaEnvioDeDatos CrearBarequroAsync(Barequero model)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppPointer.POINTER_ROOT);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsJsonAsync(AppPointer.BAREQUEROS, model).Result;
                 
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
                }else if (response.StatusCode == HttpStatusCode.BadRequest)
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

        #region cargar documentos barequero
        public static RespuestaEnvioDeDatos CargarDocumentosAsync(DocumentosBarequero model)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppPointer.POINTER_ROOT);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsJsonAsync(AppPointer.DOCUMENTOS, model).Result;

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
        public static RespuestaEnvioDeDatos CargarDocumentosBarequeroAsync(DocumentosBarequero model)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppPointer.POINTER_ROOT);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsJsonAsync(AppPointer.DOCUMENTOS, model).Result;

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



        public static RespuestaEnvioDeDatos ActualizarDocumentosBarequeroAsync(DocumentosBarequero model)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppPointer.POINTER_ROOT);
                client.DefaultRequestHeaders.Accept.Clear();
                
                client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.PutAsJsonAsync(AppPointer.ACTUALIZARDOCBAREQUERO, model).Result;

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
        public static async Task<Barequero> UpdateBarequeroAsync(Barequero barequero)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.PutAsJsonAsync(
                AppPointer.POINTER_ROOT + AppPointer.BAREQUEROS + "/" + barequero.Id, barequero);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                barequero = await response.Content.ReadAsAsync<Barequero>();
                return barequero;
            }
        }
        #endregion


    }
}
