using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class ViewModelComprasBarequeros
    {
        public int Id { get; set; }
        public decimal MontoOro { get; set; }
        public decimal MontoPlata { get; set; }
        public decimal MontoPlatino { get; set; }
        public DateTimeOffset FechaCreacion { get; set; }
        public string Estado { get; set; }
        public string Sede { get; set; }
        public decimal TotalGramos { get; set; }
        public decimal ValorPagar { get; set; }

        
    }
}
