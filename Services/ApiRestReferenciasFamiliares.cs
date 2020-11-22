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
   public class ApiRestReferenciasFamiliares
    {
        public static RespuestaEnvioDeDatos ReferenciasFamiliaresBarequeroAsync(List<ReferenciasFamiliares> list)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppPointer.POINTER_ROOT);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsJsonAsync(AppPointer.REFERENCIAS_FAMILIARES, list).Result;

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
    }
}
