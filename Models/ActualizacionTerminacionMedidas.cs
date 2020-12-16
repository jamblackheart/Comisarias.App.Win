using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class ActualizacionTerminacionMedidas
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime? Fecha { get; set; }

        public DateTime? FechaAudiencia { get; set; }

        public string Responsable { get; set; }

        public string NotificacionVictima { get; set; }
        public string NotificacionVictimaVerificada { get; set; }

        public string NotificacionAgresor { get; set; }
        public string NotificacionAgresorVerificada { get; set; }

        public string NotificacionAgresorTipo { get; set; }

        public string NotificacionOtros { get; set; }
        public string NotificacionOtrosVerificada { get; set; }

        public string NotificacionOtrosCual { get; set; }


        public string NotificacionObservacion { get; set; }


        public string Pruebas { get; set; }

        public string AsolicitudDe { get; set; }

        public string AutoResuelveIncidente { get; set; }

        public string Recurso { get; set; }

        public string FalloRevision { get; set; }

       

      

    }
}
