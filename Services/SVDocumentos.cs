using Comisarias.App.Escritorio.Models;
using Comisarias.App.Escritorio.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Services
{
   public class SVDocumentos
    {
        public static async Task<DocumentosBarequero> UpdateDocumentosBarequerosAsync(DocumentosBarequero documentos)
        {
            using (var client = new HttpClient())
            {

                HttpResponseMessage response = await client.PutAsJsonAsync(
                AppPointer.POINTER_ROOT + AppPointer.DOCUMENTOS + "/" + documentos.Id, documentos);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                documentos = await response.Content.ReadAsAsync<DocumentosBarequero>();
                return documentos;
            }
        }
        public static async Task<DocumentosBarequero> GetDocumentosBarequeroId(int barequeroId)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.DOCUMENTOS+"/"+barequeroId);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                 DocumentosBarequero data = JsonConvert.DeserializeObject<DocumentosBarequero>(responseBody);
                return data;
            }
        }
    }
}
