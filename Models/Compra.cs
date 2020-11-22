using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
  public  class Compra
    {
        public int Id { get; set; }
        public bool MaterialOro { get; set; }
         
        public bool MaterialPlata { get; set; }
        
        public bool MaterialPlatino { get; set; }
         
        public decimal MontoOro { get; set; }
        
        public decimal MontoPlata { get; set; }
        
        public decimal MontoPlatino { get; set; }
         
        public DateTimeOffset FechaCreacion { get; set; }
         
        public DateTimeOffset FechaActualizacion { get; set; }
        
        public int BarequeroId { get; set; }
         
        public string AsesorAtendio { get; set; }
        
        public string UsuarioModifico { get; set; }
        public DateTimeOffset UsuarioModificoFecha { get; set; }
        public string AsesorPesa { get; set; }
        public DateTimeOffset AsesorPesaFecha { get; set; }
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
        public decimal TotalGramos { get; set; }
        
        public decimal ValorPagar { get; set; }

        public decimal ValorGramo { get; set; }

        public decimal Merma { get; set; }

        public string TipoMaterial { get; set; }

        public decimal LeyPromedio { get; set; }
        public decimal GramosFinos { get; set; }


        public int SedeId { get; set; }
        public string Estado { get; set; } 
        public string DocCompliance { get; set; }
        public string DocComplianceEstado { get; set; }
        public decimal TotalGramosPropios { get; set; } 
        public string Contraloria { get; set; }
        public string ContraloriaEstado { get; set; }
        public string Registraduria { get; set; }
        public string RegistraduriaEstado { get; set; }
        public string Rucom { get; set; }
        public string RucomEstado { get; set; }
        public string AntecedentesJudiciales { get; set; }
        public string AntecedentesJudicialesEstado { get; set; }
        public string Produraduria { get; set; }
        public string ProduraduriaEstado { get; set; }
        public string FechaVencePermiso { get; set; }

        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string PermisoAlcaldia { get; set; }
        public string PermisoAlcaldiaEstado { get; set; }
        public string CertificadoProduccion { get; set; }
        public string CertificadoProduccionEstado { get; set; }
        public string FotoCompra { get; set; }
        public string FotoCompraEstado { get; set; }
        public string VideoCompra { get; set; }
        public string VideoCompraEstado { get; set; }
        public string VideoCompraPago { get; set; }
        public string VideoCompraPagoEstado { get; set; }
        public string DocSarlaftAprobacion { get; set; } 
        public string RazonDescarte { get; set; }
        public int PrecompraId { get; set; }
        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public int EmpresaId { get; set; }
        public bool DocSarlaftAprobacionEstado { get; set; }
        public string DocSarlaftAprobacionCompra { get; set; }

        public string TipoPago { get; set; }
        public int Consecutivo { get; set; }
        public string FacturaCompra { get; set; }
        public string FacturaCompraEstado { get; set; }


 

       
        public string Prefijo { get; set; }
              
        public string NombreSede { get; set; }
          
        public string Resolucion { get; set; }
                
        public decimal pMerma { get; set; }
                
        public decimal pOro { get; set; }

        public decimal pPlata { get; set; }
     
        public decimal pMargen { get; set; }

    }
}
