using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class InicioProceso
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public string AutoQueAvocaConocimiento { get; set; }
        public string OpcionMedidasProteccion { get; set; }
        public string MedidasProteccion { get; set; }
        public string OtraRelacionMedidaProteccion { get; set; }
        public string SolicitudAmpliacionMedidas { get; set; }
        public DateTime SolicitudAmpliacionMedidasFecha { get; set; }
        public string SolicitudAmpliacionMedidasSeOtorgaron { get; set; }

        public string RemisionFiscalia { get; set; }
        public DateTime RemisionFiscaliaFecha { get; set; }
        public string RemisionFiscaliaNumeroNoticiaCriminal { get; set; }

        public string RemisionMedicinaLegal { get; set; }
        public DateTime RemisionMedicinaLegalFecha { get; set; }
        public string RemisionMedicinaLegalInforme { get; set; }

        public string RemisionEps { get; set; }
        public DateTime RemisionEpsFecha { get; set; }
        public string RemisionEpsTipo { get; set; }

        public string AcompañamientoComisaria { get; set; }
        public string AcompañamientoComisariaObservacion { get; set; }

    }
}
