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
    
    public partial class ImpuestoSat
    {
        public int IdImpuesto { get; set; }
        public Nullable<int> IdTipoNomina { get; set; }
        public decimal LimiteInferior { get; set; }
        public decimal LimiteSuperior { get; set; }
        public decimal CuotaFija { get; set; }
        public decimal Porcentaje { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<int> EstatusId { get; set; }
    }
}
