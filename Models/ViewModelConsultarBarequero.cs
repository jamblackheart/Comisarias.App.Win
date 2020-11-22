using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
   public class ViewModelConsultarBarequero
    {
        public int Codigo { get; set; }
        public string Mensaje { get; set; }
        public Barequero Barequero { get; set; }

        public List<Anm> Anm { get; set; }

        public LimiteCompra LimiteCompra { get; set; }
        public List<ViewModelComprasBarequeros> ComprasAno { get; set; }
        public List<ViewModelComprasBarequeros> ComprasMes { get; set; }
        public List<ViewModelComprasBarequeros> ComprasMesCompra { get; set; }

        public int LimiteEmpresa { get; set; }

        public decimal TotalGramosCompradosMesPorEmpresa { get; set; }
        public decimal TotalGramosCompradosMesPorEmpresaFinos { get; set; }

        public string FechaVencePermisoAlcaldia { get; set; }

        public List<ViewModelComprasBarequerosAno> comprasBarequeroEmpresaAno { get; set; }

        public List<ViewModelComprasBarequerosAnoEmpresa> comprasEnPropiaEmpresaBarequeroAno { get; set; }
    }
}
