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
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public bool Etnia { get; set; }
        public string EtniaCual { get; set; }
        public bool Discapacidad { get; set; }
        public string DiscapacidadCual { get; set; }
        public string Area { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public bool VictimaConflicto { get; set; }



    }
}
