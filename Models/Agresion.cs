using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class Agresion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreAgresor { get; set; }
        public string DocumentoAgresor { get; set; }
        public string RelacionAgresor { get; set; }
        public string OtraRelacionAgresor { get; set; }
        public string DireccionDomicilioAgresor { get; set; }
        public string Radicado { get; set; }
        public string CuentaMedidasProteccion { get; set; }
       
        public string CualOtraMedidaProteccion { get; set; }
       
    }
}
