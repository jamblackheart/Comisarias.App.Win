using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class Entrevista
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public string Responsable { get; set; }
        public string Resumen { get; set; }
        public string TipoViolencia { get; set; }
        public string IdentificacionViolencia { get; set; }
        public string ValoracionRiesgo { get; set; }
      
    }
}
