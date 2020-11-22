using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
   public class ReferenciasFamiliares
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        
        public string Telefono { get; set; }
        
        public string Parentezco { get; set; }
        
        public int BarequeroId { get; set; }
        public Barequero Barequero { get; set; }

        
        public DateTimeOffset FechaCreacion { get; set; }
        
        public DateTimeOffset FechaActualizacion { get; set; }
       
        public DateTimeOffset FechaBorrado { get; set; }
    }
}
