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
using Newtonsoft.Json;

namespace Comisarias.App.Escritorio.Services
{
    class ApiRestPrecompra
    {
        #region compra barequero
        public static async Task<ViewModelConsultarPrecompra> RegistroPreCompraAsync(string cedula,int empresaId, int sedeId, string asesorAtendio, string cupoDisponibleCompra ,string rutaCompliance="", bool esRechazo = false, string razonDescarte = "")
        {
            using (var client = new HttpClient())
            {
                var model = new Precompra();
                model.Cedula = cedula;
                model.SedeId = sedeId;

                model.EmpresaId = empresaId; 
                
                if(rutaCompliance != "NUll")
                {
                    model.DocCompliance = rutaCompliance;
                } 

                if (esRechazo)
                {
                    model.Estado = Estados.REGISTRO_RECHAZADO;
                    model.RazonDescarte = razonDescarte;
                }
                else {
                    model.Estado = Estados.REGISTRO_PRECOMPRA;

                }
                model.AsesorAtendio = asesorAtendio;
                model.FechaCreacion = System.DateTime.Now;
                model.CupoDisponibleCompra = decimal.Parse(cupoDisponibleCompra);
                client.BaseAddress = new Uri(AppPointer.POINTER_ROOT);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync(AppPointer.PRECOMPRA, model).Result;
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                ViewModelConsultarPrecompra data = JsonConvert.DeserializeObject<ViewModelConsultarPrecompra>(responseBody);
                return data;
            }
        }

     
        public static RespuestaEnvioDeDatos ActualizarPreCompraAsync(ViewModelRegistroCompra model)
        {

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(AppPointer.POINTER_ROOT);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsJsonAsync(AppPointer.PRECOMPRA_UPDATE, model).Result;

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
        public static RespuestaEnvioDeDatos ActualizarCompraAsync(ViewModelRegistroCompra model)
        {

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(AppPointer.POINTER_ROOT);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsJsonAsync(AppPointer.COMPRAS_UPDATE, model).Result;

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
        public static RespuestaEnvioDeDatos AgregarPesoPrecompra(Precompra model)
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(AppPointer.POINTER_ROOT);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PutAsJsonAsync(AppPointer.PRECOMPRA + "/" + model.Id, model).Result;

                var respuesta = new RespuestaEnvioDeDatos();
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        // ... Read the string.
                        Task<string> result = content.ReadAsStringAsync();
                        respuesta.contentRequest = result.Result;
                        respuesta.Codigo = 204;
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
       public static async Task<Precompra> UpdatePrecompraAsync(Precompra precompra)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.PutAsJsonAsync(
                AppPointer.POINTER_ROOT + AppPointer.PRECOMPRA + "/" + precompra.Id, precompra);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                precompra = await response.Content.ReadAsAsync<Precompra>();
                return precompra;
            }
        }

      
        #endregion


    }
}
