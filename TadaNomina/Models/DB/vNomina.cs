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
    
    public partial class vNomina
    {
        public int IdNomina { get; set; }
        public int IdEmpleado { get; set; }
        public int IdPeriodoNomina { get; set; }
        public Nullable<int> IdRegistroPatronal { get; set; }
        public Nullable<int> IdSindicato { get; set; }
        public Nullable<decimal> RiesgoTrabajo { get; set; }
        public Nullable<int> IdEntidad { get; set; }
        public Nullable<int> IdCentroCostos { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public Nullable<int> IdPuesto { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<int> IdArea { get; set; }
        public Nullable<int> IdBancoTrad { get; set; }
        public string CuentaBancariaTrad { get; set; }
        public string CuentaInterbancariaTrad { get; set; }
        public Nullable<System.DateTime> FechaAltaIMSS { get; set; }
        public Nullable<System.DateTime> FechaReconocimientoAntiguedad { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public string AjusteImpuesto { get; set; }
        public Nullable<decimal> DiasTrabajados { get; set; }
        public Nullable<decimal> Faltas { get; set; }
        public Nullable<decimal> Incapacidades { get; set; }
        public Nullable<decimal> SueldoDiario { get; set; }
        public Nullable<decimal> SueldoDiarioReal { get; set; }
        public Nullable<decimal> SueldoPagado { get; set; }
        public Nullable<decimal> Apoyo { get; set; }
        public Nullable<decimal> BaseGravada { get; set; }
        public Nullable<decimal> BaseGravadaP { get; set; }
        public Nullable<decimal> BaseGravadaLiquidacion { get; set; }
        public Nullable<decimal> ISRLiquidacion { get; set; }
        public Nullable<decimal> LimiteInferior { get; set; }
        public Nullable<decimal> DiferenciaLimite { get; set; }
        public Nullable<decimal> Porcentaje { get; set; }
        public Nullable<decimal> PorcentajeCalculado { get; set; }
        public Nullable<decimal> CuotaFija { get; set; }
        public Nullable<decimal> ISR { get; set; }
        public Nullable<decimal> Subsidio { get; set; }
        public Nullable<decimal> ImpuestoRetener { get; set; }
        public Nullable<decimal> SubsidioPagar { get; set; }
        public Nullable<decimal> ReintegroISR { get; set; }
        public Nullable<decimal> Anios { get; set; }
        public Nullable<decimal> FactorIntegracion { get; set; }
        public Nullable<decimal> SDI { get; set; }
        public Nullable<decimal> SDI_Proyeccion_Real { get; set; }
        public Nullable<decimal> ISN { get; set; }
        public Nullable<decimal> Dias_Vacaciones { get; set; }
        public Nullable<decimal> Sueldo_Vacaciones { get; set; }
        public Nullable<decimal> Excedente_Obrera { get; set; }
        public Nullable<decimal> Prestaciones_Dinero { get; set; }
        public Nullable<decimal> Gastos_Med_Pension { get; set; }
        public Nullable<decimal> Invalidez_Vida { get; set; }
        public Nullable<decimal> Cesantia_Vejez { get; set; }
        public Nullable<decimal> Cuota_Fija_Patronal { get; set; }
        public Nullable<decimal> Excedente_Patronal { get; set; }
        public Nullable<decimal> Prestamo_Dinero_Patronal { get; set; }
        public Nullable<decimal> Gastos_Med_Pension_Patronal { get; set; }
        public Nullable<decimal> Riesgo_Trabajo_Patronal { get; set; }
        public Nullable<decimal> Invalidez_Vida_Patronal { get; set; }
        public Nullable<decimal> Prestamo_Especie { get; set; }
        public Nullable<decimal> Retiro { get; set; }
        public Nullable<decimal> Cesantia_Vejez_Patronal { get; set; }
        public Nullable<decimal> INFONAVIT_Patronal { get; set; }
        public Nullable<decimal> ER { get; set; }
        public Nullable<decimal> DD { get; set; }
        public Nullable<decimal> Neto { get; set; }
        public Nullable<decimal> TotalEfectivo { get; set; }
        public Nullable<decimal> ERS { get; set; }
        public Nullable<decimal> DDS { get; set; }
        public Nullable<decimal> Netos { get; set; }
        public Nullable<decimal> IMSS_Obrero { get; set; }
        public Nullable<decimal> Total_Patron { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> Honorario { get; set; }
        public Nullable<decimal> TotalCosteo { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> IVAEsq { get; set; }
        public Nullable<decimal> HonorarioEsq { get; set; }
        public Nullable<decimal> SubtotalEsq { get; set; }
        public Nullable<decimal> TotalEsq { get; set; }
        public Nullable<decimal> SueldoPagado_Real { get; set; }
        public Nullable<decimal> Sueldo_Vacaciones_Real { get; set; }
        public Nullable<decimal> Total_ER_Real { get; set; }
        public Nullable<decimal> Total_DD_Real { get; set; }
        public Nullable<decimal> Neto_Real { get; set; }
        public Nullable<decimal> ISR_Real { get; set; }
        public Nullable<decimal> Subsidio_Real { get; set; }
        public Nullable<decimal> IMSS_Obrero_Real { get; set; }
        public Nullable<decimal> IMSS_Patronal_Real { get; set; }
        public Nullable<decimal> Base_Gravada_Real { get; set; }
        public Nullable<decimal> DiasTrabajadosIMSS { get; set; }
        public Nullable<decimal> AniosReal { get; set; }
        public Nullable<decimal> DiasTrabajadosReal { get; set; }
        public string Beneficiario { get; set; }
        public Nullable<System.DateTime> FechaEmisionFiniquito { get; set; }
        public Nullable<System.DateTime> FechaCobroCheque { get; set; }
        public string NumeroCheque { get; set; }
        public Nullable<int> BanderaFiniquitos { get; set; }
        public Nullable<int> IdFacturasContabilidad { get; set; }
        public Nullable<int> IdEstatus { get; set; }
        public Nullable<int> IdCaptura { get; set; }
        public Nullable<System.DateTime> FechaCaptura { get; set; }
        public Nullable<decimal> TotalOtrasPercepciones { get; set; }
        public string Curp { get; set; }
        public string Rfc { get; set; }
        public string Imss { get; set; }
        public string ClaveEmpleado { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public Nullable<decimal> SDI_Liquidacion { get; set; }
    }
}
