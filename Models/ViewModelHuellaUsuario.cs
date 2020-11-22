using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
   public class ViewModelHuellaUsuario
    {
        
        public string Id { get; set; }

        public bool ConHuella { get; set; }
      
        public byte[] Pawprint { get; set; }
        
        public int Pawprint_length { get; set; }

        public string Usuario { get; set; }
        public string Contrasena { get; set; }
    }
}
