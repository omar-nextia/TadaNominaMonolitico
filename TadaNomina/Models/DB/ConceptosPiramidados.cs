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
    
    public partial class ConceptosPiramidados
    {
        public int IdConceptoPiramido { get; set; }
        public Nullable<int> IdPeriodo { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public Nullable<int> IdConcepto { get; set; }
        public Nullable<decimal> DPago { get; set; }
        public Nullable<decimal> SD { get; set; }
        public Nullable<decimal> SMO { get; set; }
        public Nullable<decimal> ISR_SMO { get; set; }
        public Nullable<decimal> SMN { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public Nullable<decimal> SMN_Imp { get; set; }
        public Nullable<decimal> ISR_Total { get; set; }
        public Nullable<decimal> ISR_Cobrar { get; set; }
        public Nullable<decimal> ImporteBruto { get; set; }
        public string ConsiderarSMO { get; set; }
        public string TipoCalculo { get; set; }
        public Nullable<int> IdEstatus { get; set; }
        public Nullable<int> IdCaptura { get; set; }
        public Nullable<System.DateTime> FechaCaptura { get; set; }
        public Nullable<int> IdModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    }
}
