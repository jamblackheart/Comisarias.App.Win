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
   public class ApiRestCompra
    {
        #region compra barequero
        public static RespuestaEnvioDeDatos CompraBarequeroAsync(Compra model)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppPointer.POINTER_ROOT);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsJsonAsync(AppPointer.COMPRAS, model).Result;

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
        public static async Task<Compra> UpdatePrecompraAsync(Compra compra)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.PutAsJsonAsync(
                AppPointer.POINTER_ROOT + AppPointer.COMPRAS + "/" + compra.Id, compra);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                compra = await response.Content.ReadAsAsync<Compra>();
                return compra;
            }
        }
        #endregion
    }
}
