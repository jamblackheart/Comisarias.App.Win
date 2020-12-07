using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class Orientacion { 
    
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public string Responsable { get; set; }
        public string TipoOrientacion { get; set; }
       
      
    }
}
