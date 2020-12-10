using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class ActualizacionCaso
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }

        public string Responsable { get; set; }

        public DateTime IncumplimientoFecha { get; set; }
        public string IncumplimientoNotificaciones { get; set; }
        public string IncumplimientoAudiencia { get; set; }
        public DateTime IncumplimientoAudienciaFecha { get; set; }
        public string IncumplimientoPruebas { get; set; }
        public string IncumplimientoFallo { get; set; }
        public string IncumplimientoSancion { get; set; }
        public string IncumplimientoSancionCual { get; set; }

        public string IncumplimientoSancionConsulta { get; set; }

        public string IncumplimientoRevocaConfirmaSancion { get; set; }
        public string IncumplimientoNota { get; set; }



        public string AmpliacionDeMedidasProtecccion { get; set; }
        public string AmpliacionDeMedidasProtecccionCuales { get; set; }



        public string TerminacionDeMedida { get; set; }
        public string TerminacionDeMedidaAsolicitudDe { get; set; }

        public string TerminacionDeMedidaPruebas { get; set; }

        public string TerminacionDeMedidaPruebasAutoQueResuelveIncidente { get; set; }

        public string TerminacionDeMedidaRecurso { get; set; }
        public string TerminacionDeMedidaFallo { get; set; }

        public string TerminacionDeMedidaArchivo { get; set; }


        public string TerminacionDeMedidaNota { get; set; }

      

    }
}
