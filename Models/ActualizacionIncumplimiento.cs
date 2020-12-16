using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class ActualizacionIncumplimiento
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime? Fecha { get; set; }

        public string ArchivoAutoTramiteIncumplimiento { get; set; }

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

        public string Sancion { get; set; }

        public string SancionTipo { get; set; }

        public string ConsultaSancion { get; set; }

        public string RevocaConfirma { get; set; }




      

      

    }
}
