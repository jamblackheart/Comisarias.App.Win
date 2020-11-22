using Comisarias.App.Escritorio.Models;
using Comisarias.App.Escritorio.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Comisarias.App.Escritorio.Services
{
    public class ApiRestConsultas
    {
        public static async Task<List<Genero>> GetGeneros()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.GENEROS);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Genero> data = JsonConvert.DeserializeObject<List<Genero>>(responseBody);
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }

        }
        public static async Task<List<EstadoCivil>> GetEstadoCiviles()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.ESTADO_CIVIL);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<EstadoCivil> data = JsonConvert.DeserializeObject<List<EstadoCivil>>(responseBody);
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }

        }
        public static async Task<List<Departamento>> GetDepartamentos()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.DEPARTAMENTOS);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Departamento> data = JsonConvert.DeserializeObject<List<Departamento>>(responseBody);
                    return data;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }
        public static async Task<List<Municipio>> GetMunicipios(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.MUNICIPIOS + "/" + id);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Municipio> data = JsonConvert.DeserializeObject<List<Municipio>>(responseBody);
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }

        }
        public static async Task<List<Barequero>> GetBarequeroPorCedula(string cedula)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.BAREQUEROS + "/GetCedula/" + cedula);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Barequero> data = JsonConvert.DeserializeObject<List<Barequero>>(responseBody);
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }

        }
        public static async Task<ViewModelBarequeroCompra> GetCompraPesoId(int compraId)
        {

            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.COMPRAS + "/barequero?compraId=" + compraId);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    return js.Deserialize<ViewModelBarequeroCompra>(responseBody);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static async Task<List<Compra>> GetComprasSedeId(int sedeId, string desde, string hasta)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.COMPRAS_REPORTE + sedeId + "&startDate=" + desde + "&endDate=" + hasta);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Compra> data = JsonConvert.DeserializeObject<List<Compra>>(responseBody);
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public static async Task<List<Compra>> GetCompraId(int id)
        {

            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.COMPRAS + "/" + id);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Compra> data = JsonConvert.DeserializeObject<List<Compra>>(responseBody);
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public static async Task<List<Compra>> GetCompras()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.COMPRAS);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Compra> data = JsonConvert.DeserializeObject<List<Compra>>(responseBody);
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public static async Task<List<Compra>> GetComprasSede(int sedeId, string estado)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.COMPRAS + "/sede?sedeId=" + sedeId + "&estado=" + estado);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Compra> data = JsonConvert.DeserializeObject<List<Compra>>(responseBody);
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        public static async Task<List<Empresa>> GetEmpresas()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.EMPRESAS);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Empresa> data = JsonConvert.DeserializeObject<List<Empresa>>(responseBody);
                    return data;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }

        public static async Task<List<Sede>> GetSedes(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.SEDES + "/" + id);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Sede> data = JsonConvert.DeserializeObject<List<Sede>>(responseBody);
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }

        }


        public static async Task<List<Compra>> GetCompras(string estado)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.COMPRAS + "?estado=" + estado);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Compra> data = JsonConvert.DeserializeObject<List<Compra>>(responseBody);
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        public static async Task<List<ViewModelCompraCompleta>> GetComprasCompletas(string estado, int idEmpresa, int idSede)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.COMPRASCOMPLETAS + "?estado=" + estado + "&&idEmpresa=" + idEmpresa + "&&idSede=" + idSede);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<ViewModelCompraCompleta> data = JsonConvert.DeserializeObject<List<ViewModelCompraCompleta>>(responseBody);
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public static async Task<List<Compra>> GetCompraPorCedulaBarequero(string cedula)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.COMPRAS + "/GetBarequeroCedula/" + cedula);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Compra> data = JsonConvert.DeserializeObject<List<Compra>>(responseBody);
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public static async Task<List<DocumentosBarequero>> GetDocumentosBarequeroPorCedula(string cedula)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.DOCUMENTOS + "/GetDocumentosCedula/" + cedula);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<DocumentosBarequero> data = JsonConvert.DeserializeObject<List<DocumentosBarequero>>(responseBody);
                    return data;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public static async Task<ViewModelConsultarBarequero> GetBarequeroPorCedula(string cedula, int empresaId, int sedeId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.BAREQUEROS + "/GetCedula?cedula=" + cedula + "&empresaId=" + empresaId + "&sedeId=" + sedeId);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    ViewModelConsultarBarequero data = JsonConvert.DeserializeObject<ViewModelConsultarBarequero>(responseBody);
                    return data;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static async Task<ViewModelConsultarBarequero> GetBarequeroPorCedulaRegistroCompra(string cedula, int empresaId, int sedeId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.BAREQUEROS + "/GetCedula?cedula=" + cedula + "&empresaId=" + empresaId + "&sedeId=" + sedeId);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    ViewModelConsultarBarequero data = JsonConvert.DeserializeObject<ViewModelConsultarBarequero>(responseBody);
                    return data;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public static async Task<ViewModelDocRechazados> GetCountDocAprobadas(int compraId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.COMPRAS_COUNT_RECHAZADOS + compraId);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    ViewModelDocRechazados data = JsonConvert.DeserializeObject<ViewModelDocRechazados>(responseBody);
                    return data;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static async Task<ViewModelConsultarBarequero> GetBarequeroiId(int Id, string fechaCompra = "")
        {
            try
            {
                using (var client = new HttpClient())
                {
                    DateTime dfecha = DateTime.MinValue;
                    DateTime.TryParse(fechaCompra, out dfecha);
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.BAREQUERO_ID + Id + "&anioCompra=" + dfecha.Year + "&mesCompra=" + dfecha.Month);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    ViewModelConsultarBarequero data = JsonConvert.DeserializeObject<ViewModelConsultarBarequero>(responseBody);
                    return data;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static async Task<ViewModelConsultarBarequero> GetExisteBarequeroPorCedulaEnEmpresa(string cedula, int empresaId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.BAREQUERO_VALIDAR_EXISTE_EMPRESA + cedula + "&empresaId=" + empresaId);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    ViewModelConsultarBarequero data = JsonConvert.DeserializeObject<ViewModelConsultarBarequero>(responseBody);
                    return data;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public static async Task<ViewModelConsultarBarequero> GetExisteBarequeroListaBloqueo(string cedula)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.BAREQUERO_VALIDAR_EXISTE_LISTABLOQUEO + cedula);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    ViewModelConsultarBarequero data = JsonConvert.DeserializeObject<ViewModelConsultarBarequero>(responseBody);
                    return data;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


       
        public static async Task<List<Precompra>> GetPrecompraPorSedeYEstado(int sedeId, string estado)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.PRECOMPRA + "/GetPrecompraSede?sedeId=" + sedeId + "&estado=" + estado);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<Precompra> data = JsonConvert.DeserializeObject<List<Precompra>>(responseBody);
                    return data;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static async Task<Precompra> GetPrecompraPorId(int PrecompraId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.PRECOMPRA_ID + PrecompraId);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Precompra data = JsonConvert.DeserializeObject<Precompra>(responseBody);
                    return data;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static async Task<Precompra> GetPrecompraBarequeroPorCedulaYEstado(string cedula, string estado)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    int statusNumber;

                    HttpResponseMessage response = await client.GetAsync(AppPointer.POINTER_ROOT + AppPointer.PRECOMPRA_CEDULA_BAREQUERO_ESTADO + cedula + "&estado=" + estado);
                    statusNumber = (int)response.StatusCode;

                    if (statusNumber == 200)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Precompra data = JsonConvert.DeserializeObject<Precompra>(responseBody);
                        return data;
                    }
                    else
                    {
                        return new Precompra();
                    }

                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
