using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class ActualizacionMedidasProteccion
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

        public string AmpliacionDeMedidasProtecccion { get; set; }

        public string AmpliacionDeMedidasProtecccionCuales { get; set; }

        public string MedidasDeAtencion { get; set; }
        public string VerificacionSituacionRiesgo { get; set; }
        public string ObservacionVerificacionSituacionRiesgo { get; set; }

        public string Remision { get; set; }

        public string NotifiacionVictimaMedidasAtencion { get; set; }
        public string NotifiacionVictimaMedidasAtencionVerificada { get; set; }

        public string RemisionEntidadTerritorial { get; set; }
        public string Seguimiento { get; set; }

        public string FechaSeguimiento { get; set; }

        public string TiposMedida { get; set; }
        public string ObservacionMedida { get; set; }

        public string ProteccionTemporal { get; set; }


        public string ExtensivaHijos { get; set; }

        public string Recurso { get; set; }

        public string FalloRevision { get; set; }




    }
}
