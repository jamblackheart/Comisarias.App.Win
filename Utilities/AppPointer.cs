using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Utilities
{
    class AppPointer
    {
        //PRODUCCION Comisarias
        //public static string POINTER_ROOT = "http://13.92.99.108:81/api/";
        //public static string POINTER_ROOT_FILES = "http://13.92.99.108:81/";
        //public static string POINTER_ROOT_FILES_VIDEOS = "http://13.92.99.108:81/Video?id=";


        //PRODUCCION Comisarias
        //public static string POINTER_ROOT = "http://13.92.99.108/api/";
        //public static string POINTER_ROOT_FILES = "http://13.92.99.108/";
        //public static string POINTER_ROOT_FILES_VIDEOS = "http://13.92.99.108/Video?id=";

        //-----------------OJO, HAY QUE CAMBIAR AMBAS RUTAS -------------------------------
        //LOCAL
        public static string POINTER_ROOT = "http://localhost:44333/api/";
        public static string POINTER_ROOT_FILES = "http://localhost:44333/";
        public static string POINTER_ROOT_FILES_VIDEOS = "http://localhost:44333/Video?id=";


        public static string RUTA_STORAGE_VIDEO = "https://serverComisariasdiag.blob.core.windows.net/Comisariasvideos/";
        public static string RUTA_STORAGE_BAREQUERO = "https://serverComisariasdiag.blob.core.windows.net/barequeros/";
        public static string RUTA_STORAGE_PRECOMPRA = "https://serverComisariasdiag.blob.core.windows.net/compras/";


        public static string strStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=serverComisariasdiag;AccountKey=QghOZU485+3M3t5JBMBUDf5SoYjiOxHnslCz7XfjmBG8/YcHa00J2xCXq3vX/2r0tQCqkib1f6ygZsHOUx3PuA==;EndpointSuffix=core.windows.net";
        public static string stgareVideos = "Comisariasvideos";
        public static string stgareCompras = "compras";
        public static string stgareBarequeros = "barequeros";
        public static string stgareEmpresas = "empresas";

        public static string VALIDIATE_USER = "auth/ValidateUser";
        public static string LOGIN = "auth/login";
        public static string REGISTER = "auth/adduser";
        public static string CREAR_HUELLA = "auth/addhuella";
        public static string GENEROS = "generos";
        public static string ESTADO_CIVIL = "estadocivil";
        public static string MUNICIPIOS = "municipios";
        public static string DEPARTAMENTOS = "departamentos";
        public static string EMPRESAS = "empresas";
        public static string SEDES = "sedes";
        public static string BAREQUEROS = "Barequeros";
        public static string COMPRAS = "compras";
        public static string COMPRASCOMPLETAS = "Compras/GetComprasCompletas";
        public static string DOCUMENTOS = "documentosbarequeros";

        public static string ACTUALIZARDOCBAREQUERO = "ActualizarDocumentosBarequeros";
        public static string PRECOMPRA = "precompras";
        public static string PRECOMPRA_FILE = "upload/file";
        public static string PRECOMPRA_FILE_COMPLIANCE = "upload/filecompliance?precompraId=";
        public static string PRECOMPRA_FILE_VIDEO = "upload/filevideo?precompraId=";
        public static string PRECOMPRA_FILE_VIDEO_PAGO = "upload/filevideopago?precompraId=";
        public static string PRECOMPRA_ID = "Precompras?id=";
        public static string PRECOMPRA_UPDATE = "Precompras/UpdatePrecompra";
        public static string BAREQUERO_VALIDAR_EXISTE_EMPRESA = "Barequeros/GetCedulaFromEmpresa?cedula=";
        public static string BAREQUERO_VALIDAR_EXISTE_LISTABLOQUEO = "Barequeros/GetCedulaFromlockedList?cedula=";

        public static string REFERENCIAS_FAMILIARES = "ReferenciasFamiliares/List";
        public static string UPLOAD_MULTI_FILES = "upload/UploadFilesPrecompra?PrecompraId=";
        public static string UPLOAD_MULTI_FILES_BAREQUERO = "upload/UploadFilesBarequero?cedula=";
        public static string PRECOMPRA_CEDULA_BAREQUERO_ESTADO = "Precompras/GetPrecompraBarequeroEstado?cedula=";
        public static string COMPRAS_UPDATE = "Compras/UpdateCompra";
        public static string COMPRAS_BAREQUERO = "Barequeros/GetId?barequeroId=";

        public static string BAREQUERO_ID = "Barequeros/GetBarequeroPorId?barequeroId=";
       

        public static string COMPRAS_SARLAFT_APROBACION  = "upload/compra/sarlaft?compraId=";
        public static string COMPRAS_SARLAFT = "upload/compra/sarlaftcompra?compraId=";
        public static string COMPRAS_REPORTE = "compras/GetComprasReports?sedeId=";
        public static string COMPRAS_COUNT_RECHAZADOS = "Compras/GetDocRechazadosCompra?idCompra=";

        public static string REPORTE_COMPRAS = "reports/ComprasBarequero?precompraId=";
    }
}
