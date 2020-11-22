using Comisarias.App.Escritorio.Models;
using Comisarias.App.Escritorio.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Services
{
    public class UploadFile
    {
        public static async Task<RespuestaEnvioDeDatos> UplaodArchivo(string path)
        {

            var multiForm = new MultipartFormDataContent();

            FileStream fs = File.OpenRead(path);
            multiForm.Add(new StreamContent(fs), "file", Path.GetFileName(path));
            var client = new HttpClient();
            var url = AppPointer.POINTER_ROOT + AppPointer.PRECOMPRA_FILE;
            var response = await client.PostAsync(url, multiForm);
            var respuesta = new RespuestaEnvioDeDatos();
            if (response.IsSuccessStatusCode)
            {
                using (HttpContent content = response.Content)
                {
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
        public static async Task<RespuestaEnvioDeDatos> UploadFileSarlaftCompra(string path, int compraId,int precompraId)

        {

            var multiForm = new MultipartFormDataContent();
            var fileName = Path.GetFileName(path);
            FileStream fs = File.OpenRead(path);
            multiForm.Add(new StreamContent(fs), fileName, Path.GetFileName(path));
            var client = new HttpClient();
            var url = AppPointer.POINTER_ROOT + AppPointer.COMPRAS_SARLAFT + compraId+ "&precompraId=" + precompraId;
            var response = await client.PostAsync(url, multiForm);
            var respuesta = new RespuestaEnvioDeDatos();
            if (response.IsSuccessStatusCode)
            {
                using (HttpContent content = response.Content)
                {
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
        public static async Task<RespuestaEnvioDeDatos> UploadFileSarlaftCompraAprobar(string path, int compraId, int precompraId)

        {

            var multiForm = new MultipartFormDataContent();
            var fileName = Path.GetFileName(path);
            FileStream fs = File.OpenRead(path);
            multiForm.Add(new StreamContent(fs), fileName, Path.GetFileName(path));
            var client = new HttpClient();
            var url = AppPointer.POINTER_ROOT + AppPointer.COMPRAS_SARLAFT_APROBACION + compraId + "&precompraId=" + precompraId;
            var response = await client.PostAsync(url, multiForm);
            var respuesta = new RespuestaEnvioDeDatos();
            if (response.IsSuccessStatusCode)
            {
                using (HttpContent content = response.Content)
                {
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

        public static async Task<RespuestaEnvioDeDatos> UploadFileCompliance(string path, int precompraId)
 
        {
            
            var multiForm = new MultipartFormDataContent();
            var fileName = Path.GetFileName(path);
            FileStream fs = File.OpenRead(path);
            multiForm.Add(new StreamContent(fs), fileName, Path.GetFileName(path));  
            var client = new HttpClient();
            var url = AppPointer.POINTER_ROOT+ AppPointer.PRECOMPRA_FILE_COMPLIANCE+ precompraId;
            var response = await client.PostAsync(url, multiForm);
            var respuesta = new RespuestaEnvioDeDatos();
            if (response.IsSuccessStatusCode)
            {
                using (HttpContent content = response.Content)
                {
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
        public static async Task<RespuestaEnvioDeDatos> UploadFileVideo(string path,int precompraId)
        {

            var multiForm = new MultipartFormDataContent();
            var fileNameSend = Path.GetFileName(path);
            FileStream fs = File.OpenRead(path);
            multiForm.Add(new StreamContent(fs), fileNameSend, Path.GetFileName(path));
            var client = new HttpClient();
            var url = AppPointer.POINTER_ROOT + AppPointer.PRECOMPRA_FILE_VIDEO+precompraId;
            var response = await client.PostAsync(url, multiForm);
            var respuesta = new RespuestaEnvioDeDatos();
            if (response.IsSuccessStatusCode)
            {
                using (HttpContent content = response.Content)
                {
                    Task<string> result = content.ReadAsStringAsync();
                    respuesta.contentRequest = result.Result;
                    respuesta.Codigo = 201;
                    respuesta.Mensaje = "Vídeo cargado correctamente!";
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
        public static async Task<RespuestaEnvioDeDatos> UploadFileVideoPago(string path, int precompraId)
        {

            var multiForm = new MultipartFormDataContent();
            var fileNameSend = Path.GetFileName(path);
            FileStream fs = File.OpenRead(path);
            multiForm.Add(new StreamContent(fs), fileNameSend, Path.GetFileName(path));
            var client = new HttpClient();
            var url = AppPointer.POINTER_ROOT + AppPointer.PRECOMPRA_FILE_VIDEO_PAGO + precompraId;
            var response = await client.PostAsync(url, multiForm);
            var respuesta = new RespuestaEnvioDeDatos();
            if (response.IsSuccessStatusCode)
            {
                using (HttpContent content = response.Content)
                {
                    Task<string> result = content.ReadAsStringAsync();
                    respuesta.contentRequest = result.Result;
                    respuesta.Codigo = 201;
                    respuesta.Mensaje = "Vídeo cargado correctamente!";
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
