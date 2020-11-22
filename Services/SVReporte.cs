using Comisarias.App.Escritorio.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Services
{
   public class SVReporte
    {
        public static async Task<string> GetCompras(int precompraId)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.REPORTE_COMPRAS  + precompraId);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                
                return responseBody;
            }
        }
    }
}
