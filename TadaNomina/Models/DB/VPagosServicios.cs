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
    
    public partial class VPagosServicios
    {
        public int IdEmpleado { get; set; }
        public int IdUnidadNegocio { get; set; }
        public Nullable<int> IdCentroCostos { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public Nullable<int> IdPuesto { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<int> IdArea { get; set; }
        public Nullable<int> IdRegistroPatronal { get; set; }
        public int IdEntidad { get; set; }
        public Nullable<int> IdPrestaciones { get; set; }
        public Nullable<int> IdJornada { get; set; }
        public string ClaveEmpleado { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<decimal> SD { get; set; }
        public Nullable<decimal> SDIMSS { get; set; }
        public Nullable<decimal> SDI { get; set; }
        public Nullable<decimal> NetoPagar { get; set; }
        public Nullable<int> IdBancoTrad { get; set; }
        public string CuentaBancariaTrad { get; set; }
        public string CuentaInterbancariaTrad { get; set; }
        public string Curp { get; set; }
        public string Rfc { get; set; }
        public string Imss { get; set; }
        public string CorreoElectronico { get; set; }
        public byte[] Password { get; set; }
        public Nullable<System.DateTime> FechaReconocimientoAntiguedad { get; set; }
        public Nullable<System.DateTime> FechaAltaIMSS { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public string MotivoBaja { get; set; }
        public string Recontratable { get; set; }
        public string Esquema { get; set; }
        public string TipoContrato { get; set; }
        public Nullable<System.DateTime> FechaTerminoContrato { get; set; }
        public string RFCSubContratacion { get; set; }
        public Nullable<int> IdPerfil { get; set; }
        public int IdEstatus { get; set; }
        public int IdCaptura { get; set; }
        public System.DateTime FechaCaptura { get; set; }
        public Nullable<int> IdModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public byte[] Contrasena { get; set; }
        public byte[] PassKiosko { get; set; }
        public string Telefono { get; set; }
        public string Nacionalidad { get; set; }
        public Nullable<int> idSindicato { get; set; }
        public string PremioP { get; set; }
        public Nullable<decimal> SaldoVacaciones { get; set; }
        public Nullable<decimal> BanderaSaldo { get; set; }
        public Nullable<decimal> SaldoPeriodoAnterior { get; set; }
        public Nullable<decimal> SaldoAdeudoVacaciones { get; set; }
        public Nullable<decimal> DiasExtras { get; set; }
        public Nullable<decimal> SaldoDiasExtras { get; set; }
        public Nullable<decimal> BanderaSaldoExtras { get; set; }
        public Nullable<int> IdCodigoPostal { get; set; }
        public string Calle { get; set; }
        public string noExt { get; set; }
        public string noInt { get; set; }
        public string Colonia { get; set; }
        public string Alcaldia { get; set; }
        public string Entidad { get; set; }
        public string CP { get; set; }
        public string RutaCSF { get; set; }
        public string DocumentoAlta { get; set; }
        public string DocumentoBaja { get; set; }
        public string MotivoBajaRH { get; set; }
        public Nullable<decimal> SD_Proyeccion { get; set; }
        public Nullable<decimal> SDIMSS_Proyeccion { get; set; }
        public Nullable<decimal> SDI_Proyeccion { get; set; }
        public Nullable<System.DateTime> FechaAltaIMSS_Proyeccion { get; set; }
        public Nullable<System.DateTime> FechaReconocimientoAntiguedad_Proyeccion { get; set; }
        public Nullable<decimal> Neto_Proyeccion { get; set; }
        public Nullable<int> IdBancoViaticos { get; set; }
        public string CuentaBancariaViaticos { get; set; }
        public string CuentaInterbancariaViaticos { get; set; }
        public string CardChecador { get; set; }
        public string passChecador { get; set; }
        public Nullable<int> PrivilegioChecador { get; set; }
        public string Foto { get; set; }
        public string ImagenPerfil { get; set; }
        public string Origen { get; set; }
        public Nullable<System.DateTime> FechaModificacionNube { get; set; }
        public Nullable<System.DateTime> FechaModificacionCIF { get; set; }
        public int IdPagoOrdenServicio { get; set; }
        public int IdPeriodoNomina { get; set; }
        public int IdOrdenServicio { get; set; }
        public int Expr1 { get; set; }
        public Nullable<int> IdConcepto { get; set; }
        public decimal Pago { get; set; }
        public string DescripcionPago { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoActual { get; set; }
        public string Honorario { get; set; }
        public string EnvioHonorario { get; set; }
        public int Expr2 { get; set; }
        public int Expr3 { get; set; }
        public System.DateTime Expr4 { get; set; }
        public Nullable<int> IdModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    }
}
