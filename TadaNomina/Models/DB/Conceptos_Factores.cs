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
    
    public partial class Conceptos_Factores
    {
        public int IdConceptoFactor { get; set; }
        public Nullable<int> IdConcepto { get; set; }
        public Nullable<decimal> Limite_Inferior { get; set; }
        public Nullable<decimal> Limite_Superior { get; set; }
        public string TipoDato { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<System.DateTime> FechaInicioVigencia { get; set; }
        public Nullable<int> IdEstatus { get; set; }
        public Nullable<int> IdCaptura { get; set; }
        public Nullable<System.DateTime> FechaCaptura { get; set; }
        public Nullable<int> IdModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    }
}
