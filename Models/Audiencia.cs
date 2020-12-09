using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class Audiencia
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }

        public string Responsable { get; set; }
        public string SeRealizo { get; set; }

        public string PorqueNoSeRealizo { get; set; }
        public string EnvioNotificacionVictima { get; set; }
        public string VerificacionNotificacionVictima { get; set; }
        public string EnvioNotificacionAgresor { get; set; }
        public string VerificacionNotificacionAgresor { get; set; }
        public string EnvioNotificacionOtro { get; set; }
        public string VerificacionNotificacionOtro { get; set; }
        public string EnvioNotificacionOtroCuales { get; set; }
        public string NotaVerificacion { get; set; }

        public string NoConfrontacionConElAgresor { get; set; }
        public string AcuerdosPrevios { get; set; }
        public string AcuerdosPreviosCuales { get; set; }
        public string Pruebas { get; set; }

        public string FalloOtorgaMedidasProteccion { get; set; }
        public string FalloOtorgaMedidasProteccionCuales { get; set; }
        public string FalloOtorgaMedidasProteccionCualesOtra { get; set; }

        public string FalloOtorgaMedidasAtencion { get; set; }
        public string FalloOtorgaMedidasAtencionCuales { get; set; }
        public string FalloOtorgaMedidasAtencionCualesOtra { get; set; }

        public string ExtensivaAhijos { get; set; }
        public string Recurso { get; set; }
        public string FalloRevision { get; set; }
        public string FalloRevisionNota { get; set; }
        
    }
}
