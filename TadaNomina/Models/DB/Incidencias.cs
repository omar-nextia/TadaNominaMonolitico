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
    
    public partial class Incidencias
    {
        public int IdIncidencia { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public Nullable<int> IdPeriodoNomina { get; set; }
        public Nullable<int> IdConcepto { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> CantidadEsquema { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<decimal> Exento { get; set; }
        public Nullable<decimal> Gravado { get; set; }
        public Nullable<decimal> MontoEsquema { get; set; }
        public Nullable<decimal> ExentoEsquema { get; set; }
        public Nullable<decimal> GravadoEsquema { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public string Folio { get; set; }
        public string Observaciones { get; set; }
        public Nullable<int> BanderaFiniquitos { get; set; }
        public Nullable<int> BanderaAguinaldos { get; set; }
        public Nullable<int> BanderaIncidenciasFijas { get; set; }
        public Nullable<int> BanderaConceptoEspecial { get; set; }
        public Nullable<int> BanderaInfonavit { get; set; }
        public Nullable<int> BanderaFonacot { get; set; }
        public Nullable<int> BanderaPensionAlimenticia { get; set; }
        public Nullable<int> BanderaChecadores { get; set; }
        public Nullable<int> BanderaVacaciones { get; set; }
        public Nullable<int> BanderaAdelantoPULPI { get; set; }
        public Nullable<int> BanderaAusentismos { get; set; }
        public Nullable<int> BanderaPiramidacion { get; set; }
        public Nullable<int> BanderaBallistic { get; set; }
        public Nullable<int> BanderaSaldos { get; set; }
        public Nullable<int> IdEstatus { get; set; }
        public Nullable<int> IdCaptura { get; set; }
        public Nullable<System.DateTime> FechaCaptura { get; set; }
        public Nullable<int> IdModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<int> BanderaCompensaciones { get; set; }
        public string Origen { get; set; }
        public Nullable<int> BanderaIncidencia { get; set; }
    }
}
