using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
   public class ViewModelUserRole
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
        public string NombreEmpresa { get; set; }
        public int EmpresaId { get; set; }
        public string NombreSede { get; set; }
        public int SedeId { get; set; }
        public List<string> Rol { get; set; }
        public DateTimeOffset FechaCreacion { get; set; }
        public bool isConnet { get; set; }
        public int CurrentConnection { get; set; }
        public bool ConHuella { get; set; }
        public string Pawprint { get; set; }
        public int Pawprint_length { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
    }
}
