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
    
    public partial class vEmpleadosIMSS_NA
    {
        public int IdEmpleado { get; set; }
        public int IdUnidadNegocio { get; set; }
        public Nullable<int> IdCentroCostos { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public Nullable<int> IdPuesto { get; set; }
        public Nullable<int> IdRegistroPatronal { get; set; }
        public int IdEntidad { get; set; }
        public string ClaveEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<decimal> SD { get; set; }
        public Nullable<decimal> SDIMSS { get; set; }
        public Nullable<decimal> SDI { get; set; }
        public Nullable<int> IdBancoTrad { get; set; }
        public string CuentaBancariaTrad { get; set; }
        public string CuentaInterbancariaTrad { get; set; }
        public string Curp { get; set; }
        public string Rfc { get; set; }
        public string Imss { get; set; }
        public string CorreoElectronico { get; set; }
        public Nullable<System.DateTime> FechaReconocimientoAntiguedad { get; set; }
        public Nullable<System.DateTime> FechaAltaIMSS { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public string Esquema { get; set; }
        public string TipoContrato { get; set; }
        public string RFCSubContratacion { get; set; }
        public int IdEstatus { get; set; }
        public int IdCaptura { get; set; }
        public System.DateTime FechaCaptura { get; set; }
        public Nullable<int> IdModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UnidadNegocio { get; set; }
        public string ClaveCC { get; set; }
        public string CentroCostos { get; set; }
        public string ClaveDepto { get; set; }
        public string Departamento { get; set; }
        public string ClavePuesto { get; set; }
        public string Puesto { get; set; }
        public Nullable<int> IdPrestaciones { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoNomina { get; set; }
        public string TipoNomina { get; set; }
        public decimal DiasPago { get; set; }
        public Nullable<decimal> DiasIMSS { get; set; }
        public Nullable<decimal> NetoPagar { get; set; }
        public Nullable<int> IdPerfil { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public string NombrePatrona { get; set; }
        public string RegistroPatronal { get; set; }
        public string Banco { get; set; }
        public decimal Compensacion_Dia_Trabajado { get; set; }
        public Nullable<decimal> CantidadUnidad { get; set; }
        public string NumeroCredito { get; set; }
        public string Tipo { get; set; }
        public string Cliente { get; set; }
        public string CampoBusqueda { get; set; }
        public byte[] PassKiosko { get; set; }
        public string Telefono { get; set; }
        public string Nacionalidad { get; set; }
        public string Estatus { get; set; }
        public string MotivoBaja { get; set; }
    }
}
