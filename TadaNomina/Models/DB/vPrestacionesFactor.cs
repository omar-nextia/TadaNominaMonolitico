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
    
    public partial class vPrestacionesFactor
    {
        public int IdFactorIntegracion { get; set; }
        public int IdPrestaciones { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> IdEstatus { get; set; }
        public Nullable<decimal> Limite_Inferior { get; set; }
        public Nullable<decimal> Limite_Superior { get; set; }
        public Nullable<decimal> Aguinaldo { get; set; }
        public Nullable<decimal> Vacaciones { get; set; }
        public Nullable<decimal> PrimaVacacional { get; set; }
        public Nullable<decimal> PrimaVacacionalSDI { get; set; }
        public Nullable<decimal> FactorIntegracion { get; set; }
        public Nullable<int> IdEstatusFactor { get; set; }
        public Nullable<System.DateTime> FechaInicioVigencia { get; set; }
    }
}
