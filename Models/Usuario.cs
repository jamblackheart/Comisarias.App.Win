using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int GeneroId { get; set; }
        public string Genero { get; set; }
        public string Area { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public bool PerteneceEtnia { get; set; }
        public string CualEtnia { get; set; }
        public bool Discapacidad { get; set; }
        public string CualDiscapacidad { get; set; }
        public bool VictimaConflictoArmado { get; set; }
        public string Documento { get; set; }

        public string HijosMenores { get; set; }

    }
}
