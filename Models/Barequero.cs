using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
  public  class Barequero
    {

        public int Id { get; set; }
        public string TipoIdentificacion { get; set; }

        public string TipoBarequero { get; set; }

        public string Cedula { get; set; }
 
        public Departamento Departamento { get; set; }
 
        public string Foto { get; set; }
        
        public string Nombres { get; set; }
        
        public string Apellidos { get; set; }
         
        public string TipoPersona { get; set; }
        
        public string Direccion { get; set; }
         
        public string Telefono { get; set; }
        public string FechaNacimiento { get; set; }
        public string Celular { get; set; }
     
        public string Correo { get; set; }
        
        public bool MaterialOro { get; set; }
         
        public bool MaterialPlata { get; set; }
        
        public bool MaterialPlatino { get; set; }
        public bool Estado { get; set; }
        
 
        public int GeneroId { get; set; } 
        public Genero Genero { get; set; }

        public int EstadoCivilId { get; set; }
        public EstadoCivil EstadoCivil { get; set; }

        public int MunicipioId { get; set; }
        public Municipio Municipio { get; set; }
 
        public string Padre { get; set; }
        
        public string Madre { get; set; }
         
        public string Hijos { get; set; }
        
        public string Pareja { get; set; }
        
        public int MontoOro { get; set; }
        
        public int MontoPlata { get; set; }
        
        public int MontoPlatino { get; set; }
        public bool ConHuella { get; set; }
        public byte[] Pawprint { get; set; }
        public int Pawprint_length { get; set; }
        public int EmpresaId { get; set; }
        public int SedeId { get; set; } 
        public DateTimeOffset FechaCreacion { get; set; }

        public DateTimeOffset FechaActualizacion { get; set; }

        public DateTimeOffset FechaBorrado { get; set; }
    }
}
