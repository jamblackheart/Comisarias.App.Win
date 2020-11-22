using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
   public class ViewModelConsultarPrecompra
    {
        public int Codigo { get; set; }
        public string Mensaje { get; set; }
        public Precompra Precompra { get; set; }



    }
}
