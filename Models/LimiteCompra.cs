using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class LimiteCompra
    {
        public int Id { get; set; }

        public DateTimeOffset FechaPublicacion { get; set; }

        public decimal LimiteAno { get; set; }
        public decimal LimiteMes { get; set; }
    }
}
