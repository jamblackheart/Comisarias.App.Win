using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
   public class DocumentosBarequero
    {
        public int Id { get; set; }
        public string PermisoAlcaldia { get; set; }
        public string PermisoAlcaldiaEstado { get; set; }
        public string Cedula { get; set; }
        public string CedulaEstado { get; set; }
        public string Rut { get; set; }
        public string RutEstado { get; set; }
        public string Contraloria { get; set; }
        public string ContraloriaEstado { get; set; }
        public string Registraduria { get; set; }
        public string RegistraduriaEstado { get; set; }
        public string Rucom { get; set; }
        public string RucomEstado { get; set; }
        public string Produccion { get; set; }
        public string ProduccionEstado { get; set; }
        public string AntecedentesJudiciales { get; set; }
        public string AntecedentesJudicialesEstado { get; set; }
        public string Produraduria { get; set; }
        public string ProduraduriaEstado { get; set; }
        public string ConsentimientoInformado { get; set; }
        public string ConsentimientoInformadoEstado { get; set; }
        public int BarequeroId { get; set; }
        
    }
}
