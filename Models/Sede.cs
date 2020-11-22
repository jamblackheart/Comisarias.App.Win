using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
   public class Sede
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }

    }
}
