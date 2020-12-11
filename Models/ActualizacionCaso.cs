using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class ActualizacionCaso
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime? Fecha { get; set; }

        public string Responsable { get; set; }

        public string Adjunto { get; set; }
        public string Observacion { get; set; }


       

      

    }
}
