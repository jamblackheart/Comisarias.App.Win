using Comisarias.App.Escritorio.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
   public class ViewModelParametroSistema
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
     
        public string Departamento { get; set; }
        public string Municipio { get; set; }
       

        public string RutaDocumentos { get; set; }


        public ViewModelParametroSistema()
        {
            ParametroSistema_Controller controlador = new ParametroSistema_Controller();
            ParametroSistema parametros = controlador.ObtenerParametrosSistema();
            this.Id = parametros.Id;
            this.Nombre = parametros.Nombre;
           
            this.Departamento = parametros.Departamento;
            this.Municipio = parametros.Municipio;
          
            this.RutaDocumentos = parametros.RutaDocumentos;

        }
    }
}
