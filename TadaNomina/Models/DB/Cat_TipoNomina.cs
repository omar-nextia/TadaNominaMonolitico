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
    
    public partial class Cat_TipoNomina
    {
        public int IdTipoNomina { get; set; }
        public string TipoNomina { get; set; }
        public string Observaciones { get; set; }
        public decimal DiasPago { get; set; }
        public Nullable<decimal> DiasIMSS { get; set; }
        public string Clave_Sat { get; set; }
    }
}
