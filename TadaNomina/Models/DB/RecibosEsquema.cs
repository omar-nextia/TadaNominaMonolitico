//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TadaNomina.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class RecibosEsquema
    {
        public int IdRecibosEsquema { get; set; }
        public Nullable<int> IdPeriodoNomina { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public string RFC { get; set; }
        public Nullable<decimal> Total_Percepciones { get; set; }
        public Nullable<decimal> Total_Deducciones { get; set; }
        public string CadenaXML { get; set; }
        public string Periodo { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public Nullable<System.DateTime> FechaCaptura { get; set; }
        public Nullable<int> IdEstatus { get; set; }
    }
}
