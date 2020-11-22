using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class Anm
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public decimal Oro { get; set; }
        public decimal Plata { get; set; }
        public decimal Platino { get; set; }
        public decimal Total { get; set; }
    }
}
