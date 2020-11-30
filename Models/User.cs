using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Nombres { get; set; }

        public String Apellidos { get; set; }
        public String Documento { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }

    }
}
