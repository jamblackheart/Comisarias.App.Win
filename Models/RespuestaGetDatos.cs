using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
   public class RespuestaGetDatos
    {
        public bool FueExitosa { get; set; }
        public string Mensaje { get; set; }
        public DataTable Datos { get; set; }
    }
}
