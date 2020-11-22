using Comisarias.App.Escritorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Comisarias.App.Escritorio.Services
{
    public class TransformRequest
    {
        public static Reporte GetDatastringCompras(string stringRequest)
        {
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                return js.Deserialize<Reporte>(stringRequest);
            }
            catch (Exception ex)
            {

                return null;
            }
            
           

        }
        public static RespuestaAuth GetDatastringRequest(string stringRequest)
        {
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                return js.Deserialize<RespuestaAuth>(stringRequest);
            }
            catch (Exception ex)
            {

                return null;
            }



        }
        public static ViewModelBarequero GetDataViewModelBarequero(string strinRequest)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Deserialize<ViewModelBarequero>(strinRequest);
        }
        public static Precompra GetDataPrecompra(string strinRequest)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Deserialize<Precompra>(strinRequest);
        }
        

    }
}
