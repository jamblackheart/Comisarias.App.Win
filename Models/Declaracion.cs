using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
    public class Declaracion
    {
        //Propiedades

        public string Consecutivo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Municipio { get; set; }
        public string Departamento { get; set; }
        public string GramosBrutos { get; set; }
        public string Trimestre1 { get; set; }
        public string Trimestre2 { get; set; }
        public string Trimestre3 { get; set; }
        public string Trimestre4 { get; set; }
        public string Enero { get; set; }
        public string Febrero { get; set; }
        public string Marzo { get; set; }
        public string Abril { get; set; }
        public string Mayo { get; set; }
        public string Junio { get; set; }
        public string Julio { get; set; }
        public string Agosto { get; set; }
        public string Septiembre { get; set; }
        public string Octubre { get; set; }
        public string Noviembre { get; set; }
        public string Diciembre { get; set; }
        public string AnoActual { get; set; }
        public string Empresa { get; set; }
        public string Rucom { get; set; }
        public string Nit { get; set; }
        public string MunicipioEmpresa { get; set; }
        public string DepartamentoEmpresa { get; set; }
        public string DiaCompra { get; set; }
        public string MesCompra { get; set; }
        public string AnoCompra { get; set; }

        public Declaracion()
        {
        }
        //Constructor que recibe parámetro de la misma clase
        public Declaracion(Declaracion Add)
        {
            Nombre = Add.Nombre;
            Apellidos = Add.Apellidos;
            Documento = Add.Documento;
            Direccion = Add.Direccion;
            Telefono = Add.Telefono;
            CorreoElectronico = Add.CorreoElectronico;
            Municipio = Add.Municipio;
            Departamento = Add.Departamento;
            GramosBrutos = Add.GramosBrutos;
            Trimestre1 = Add.Trimestre1;
            Trimestre2 = Add.Trimestre2;
            Trimestre3 = Add.Trimestre3;
            Trimestre4 = Add.Trimestre4;
            Enero = Add.Enero; 
            Febrero = Add.Febrero;
            Marzo = Add.Marzo;
            Abril = Add.Abril;
            Mayo = Add.Mayo;
            Junio = Add.Junio;
            Julio = Add.Julio;
            Agosto = Add.Agosto;
            Septiembre = Add.Septiembre;
            Octubre = Add.Octubre;
            Noviembre = Add.Noviembre;
            Diciembre = Add.Diciembre;
            AnoActual = Add.AnoActual;
            Empresa = Add.Empresa;
            Rucom = Add.Rucom;
            Nit = Add.Nit;
            MunicipioEmpresa = Add.MunicipioEmpresa;
            DepartamentoEmpresa = Add.DepartamentoEmpresa;
            DiaCompra = Add.DiaCompra;
            MesCompra = Add.MesCompra;
            AnoCompra = Add.AnoCompra;
        }
    }
}
