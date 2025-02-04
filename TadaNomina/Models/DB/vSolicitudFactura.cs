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
    
    public partial class vSolicitudFactura
    {
        public int IdFacturasContabilidad { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdUnidadNegocio { get; set; }
        public string FechaFactura { get; set; }
        public string Periodo { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> IdEmpresaFacturadora { get; set; }
        public Nullable<int> IdConceptoFacturacion { get; set; }
        public string Observaciones { get; set; }
        public string FacturaPDF { get; set; }
        public string FacturaXML { get; set; }
        public Nullable<System.DateTime> FechaEnvioFactura { get; set; }
        public Nullable<int> IdAdjuntoFactura { get; set; }
        public Nullable<int> IdCaptura { get; set; }
        public Nullable<System.DateTime> FechaCaptura { get; set; }
        public Nullable<int> IdCancelacion { get; set; }
        public string MotivoCancelacion { get; set; }
        public string Cliente { get; set; }
        public string UnidadNegocio { get; set; }
        public Nullable<int> IdFacturadora { get; set; }
        public string Facturadora { get; set; }
        public string RFC { get; set; }
        public string Concepto { get; set; }
        public string ClaveSat { get; set; }
        public string DescripcionClaveSat { get; set; }
        public string AdjuntarComprobante { get; set; }
        public string UsoCFDI { get; set; }
        public string MetodoPago { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public Nullable<int> IdEstatus { get; set; }
        public string FormaPago { get; set; }
        public Nullable<int> IdClienteRazonSocialFacturacion { get; set; }
        public string RazonSocialCliente { get; set; }
        public string REP_PDF { get; set; }
        public string REP_XML { get; set; }
        public Nullable<int> CargaFactura { get; set; }
        public Nullable<int> CargaREP { get; set; }
        public string ObservacionesContabilidad { get; set; }
        public string RFC_Receptor { get; set; }
        public string PeriodosEnFactura { get; set; }
        public Nullable<System.DateTime> FechaComprobantePago { get; set; }
        public string Comprobante { get; set; }
        public Nullable<decimal> SaldoFavor { get; set; }
        public Nullable<decimal> SaldoAplicado { get; set; }
        public Nullable<decimal> NTotal { get; set; }
        public string Costeo_HTML { get; set; }
        public string Estatus { get; set; }
        public string ArchivoBancos { get; set; }
        public Nullable<int> Expr1 { get; set; }
        public string Periodos { get; set; }
        public Nullable<decimal> TotalPercepcionesTradicional { get; set; }
        public Nullable<decimal> TotalPercepcionesEsquema { get; set; }
        public Nullable<decimal> Total_Patron { get; set; }
        public Nullable<decimal> ISN { get; set; }
        public Nullable<decimal> Honorario { get; set; }
        public Nullable<decimal> Otros { get; set; }
        public string ObservacionesRep { get; set; }
    }
}
