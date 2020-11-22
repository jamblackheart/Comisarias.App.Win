using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class ViewModelRegistroCompra
    {
        public int PrecompraId { get; set; }
      
        public string UsuarioModifico { get; set; }
      
        public string Estado { get; set; }

        public string RazonDescarte { get; set; }

        public string VideoCompraPago { get; set; }

        public string FechaVencePermiso { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }

        public string AsesorCompra { get; set; }
        public DateTimeOffset AsesorCompraFecha { get; set; }
        public string AsesorPagaCompra { get; set; }
        public DateTimeOffset AsesorPagaCompraFecha { get; set; }
        public string AsesorVerificaCompra { get; set; }
        public DateTimeOffset AsesorVerificaCompraFecha { get; set; }
        public string AsesorVerificaAuxiliar { get; set; }
        public DateTimeOffset AsesorVerificaAuxiliarFecha { get; set; }
        public string AsesorVerificaJefe { get; set; }
        public DateTimeOffset AsesorVerificaJefeFecha { get; set; }
        public string FotoCompra { get; set; }
        public string SarlaftAprobacion { get; set; }

        public string TipoPago { get; set; }
        public  string FacturaCompra { get; set; }
    }
}
