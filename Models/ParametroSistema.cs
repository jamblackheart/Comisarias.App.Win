using Comisarias.App.Escritorio.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
   public class ParametroSistema
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
       
        public string Departamento { get; set; }
        public string Municipio { get; set; }
       

        public string RutaDocumentos { get; set; }

        

    }
}
