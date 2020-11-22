using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Utilities
{
    public class Estados
    {
        #region precompra
        public static string REGISTRO_PRECOMPRA ="Habilitado";
        public static string REGISTRO_RECHAZADO = "Descartado";
        public static string PESADA_PRECOMPRA = "Pesada";
        public static string PRECOMPRA = "Precompra";
        #endregion

        #region compra
        public static string COMPRA = "Compra";
        public static string COMPRA_PAGO = "Pagado";
        public static string COMPRA_REVISADA = "Revisada aprobada";
        public static string COMPRA_REVISADA_RECHAZADA = "Revisada rechazada";
        public static string COMPRA_APROBADA = "Aprobada";
        public static string COMPRA_RECHAZADA = "Rechazada";
        public static string COMPRA_APRUEBAJEFE = "ApruebaJefe";
        #endregion

        #region estados archivos 
        public static string archivoPendiente = "Pendiente";
        public static string archivoAprobado = "Aprobado";
        public static string archivoRechazado = "Rechazado";
        #endregion
    }
}
