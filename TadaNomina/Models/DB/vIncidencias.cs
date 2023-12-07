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
    
    public partial class vIncidencias
    {
        public int IdIncidencia { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public Nullable<int> IdPeriodoNomina { get; set; }
        public Nullable<int> IdConcepto { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
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
        public Nullable<int> IdEstatus { get; set; }
        public Nullable<int> IdCaptura { get; set; }
        public Nullable<System.DateTime> FechaCaptura { get; set; }
        public Nullable<int> IdModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public string Periodo { get; set; }
        public string ClaveEmpleado { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public Nullable<decimal> SD { get; set; }
        public Nullable<decimal> SDIMSS { get; set; }
        public Nullable<decimal> SDI { get; set; }
        public string Curp { get; set; }
        public string Rfc { get; set; }
        public string Imss { get; set; }
        public string ClaveConcepto { get; set; }
        public string ClaveSAT { get; set; }
        public string Concepto { get; set; }
        public string Informacion { get; set; }
        public string TipoConcepto { get; set; }
        public string TipoDato { get; set; }
        public string Integrable { get; set; }
        public string IntegraSDI { get; set; }
        public string Exenta { get; set; }
        public string UnidadExenta { get; set; }
        public Nullable<decimal> CantidadExenta { get; set; }
        public Nullable<decimal> PorcentajeGravado { get; set; }
        public string TipoEsquema { get; set; }
        public string CalculaMontos { get; set; }
        public Nullable<decimal> SDPor { get; set; }
        public Nullable<decimal> SDEntre { get; set; }
        public string AfectaSeldo { get; set; }
        public string AfectaCargaSocial { get; set; }
        public string ClaveGpo { get; set; }
        public Nullable<int> BanderaFiniquitos { get; set; }
        public Nullable<int> BanderaAguinaldos { get; set; }
        public Nullable<int> BanderaIncidenciasFijas { get; set; }
        public string SumaNetoFinal { get; set; }
        public Nullable<int> BanderaConceptoEspecial { get; set; }
        public Nullable<int> BanderaInfonavit { get; set; }
        public Nullable<int> BanderaFonacot { get; set; }
        public Nullable<int> BanderaPensionAlimenticia { get; set; }
        public string MultiplicaDT { get; set; }
        public Nullable<int> IdConceptoSistema { get; set; }
        public Nullable<decimal> CantidadEsquema { get; set; }
        public Nullable<int> BanderaChecadores { get; set; }
        public Nullable<int> BanderaVacaciones { get; set; }
        public string IntegraISN { get; set; }
        public Nullable<int> BanderaAdelantoPULPI { get; set; }
        public string PagoEfectivo { get; set; }
        public string UsuarioCaptura { get; set; }
        public Nullable<int> BanderaAusentismos { get; set; }
        public Nullable<int> BanderaPiramidacion { get; set; }
        public Nullable<int> BanderaBallistic { get; set; }
        public Nullable<int> BanderaSaldos { get; set; }
        public string CalculoDiasHoras { get; set; }
        public string IntegraPension { get; set; }
        public string CalculoAutomatico { get; set; }
        public Nullable<int> Orden { get; set; }
        public string Formula { get; set; }
    }
}
