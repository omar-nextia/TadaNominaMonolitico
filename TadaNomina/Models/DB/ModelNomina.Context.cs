﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NominaEntities1 : DbContext
    {
        public NominaEntities1()
            : base("name=NominaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Sueldos_Minimos> Sueldos_Minimos { get; set; }
        public virtual DbSet<ImpuestoSat> ImpuestoSat { get; set; }
        public virtual DbSet<SubsidioEmpleoSat> SubsidioEmpleoSat { get; set; }
        public virtual DbSet<ImpuestosIMSS> ImpuestosIMSS { get; set; }
        public virtual DbSet<IncidenciasProgramadas> IncidenciasProgramadas { get; set; }
        public virtual DbSet<vIncidenciasProgramadas> vIncidenciasProgramadas { get; set; }
        public virtual DbSet<vRegistroPatronal> vRegistroPatronal { get; set; }
        public virtual DbSet<Cat_CentroCostos> Cat_CentroCostos { get; set; }
        public virtual DbSet<Cat_Departamentos> Cat_Departamentos { get; set; }
        public virtual DbSet<vCreditoFonacot> vCreditoFonacot { get; set; }
        public virtual DbSet<CreditosFonacot> CreditosFonacot { get; set; }
        public virtual DbSet<FactorIntegracion> FactorIntegracion { get; set; }
        public virtual DbSet<PensionAlimenticia> PensionAlimenticia { get; set; }
        public virtual DbSet<vPensionAlimenticia> vPensionAlimenticia { get; set; }
        public virtual DbSet<Cat_Areas> Cat_Areas { get; set; }
        public virtual DbSet<ConfiguracionNominaPeriodoEmpleado> ConfiguracionNominaPeriodoEmpleado { get; set; }
        public virtual DbSet<Bimestres> Bimestres { get; set; }
        public virtual DbSet<RecibosEsquema> RecibosEsquema { get; set; }
        public virtual DbSet<vRecibosEsquema> vRecibosEsquema { get; set; }
        public virtual DbSet<RecuperacionIMSS> RecuperacionIMSS { get; set; }
        public virtual DbSet<Incidencias_Consolidadas> Incidencias_Consolidadas { get; set; }
        public virtual DbSet<vNominaSelectFiniquito> vNominaSelectFiniquito { get; set; }
        public virtual DbSet<Cat_Accesos_GeoVictoria> Cat_Accesos_GeoVictoria { get; set; }
        public virtual DbSet<CreditosInfonavit> CreditosInfonavit { get; set; }
        public virtual DbSet<vCreditoInfonavit> vCreditoInfonavit { get; set; }
        public virtual DbSet<ConfiguracionFiniquito> ConfiguracionFiniquito { get; set; }
        public virtual DbSet<vConfiguracionFiniquito> vConfiguracionFiniquito { get; set; }
        public virtual DbSet<vDesgloceVacaciones> vDesgloceVacaciones { get; set; }
        public virtual DbSet<NominaProvision> NominaProvision { get; set; }
        public virtual DbSet<vNominaTrabajo> vNominaTrabajo { get; set; }
        public virtual DbSet<AdelantoNomina> AdelantoNomina { get; set; }
        public virtual DbSet<ConceptosPiramidados> ConceptosPiramidados { get; set; }
        public virtual DbSet<vConceptosPiramidados> vConceptosPiramidados { get; set; }
        public virtual DbSet<vNomina> vNomina { get; set; }
        public virtual DbSet<Cat_Jornadas> Cat_Jornadas { get; set; }
        public virtual DbSet<FactoresCyV_IMSS> FactoresCyV_IMSS { get; set; }
        public virtual DbSet<vPrestacionesFactor> vPrestacionesFactor { get; set; }
        public virtual DbSet<PeriodoNomina> PeriodoNomina { get; set; }
        public virtual DbSet<vPeriodoNomina> vPeriodoNomina { get; set; }
        public virtual DbSet<Nomina> Nomina { get; set; }
        public virtual DbSet<NominaTrabajo> NominaTrabajo { get; set; }
        public virtual DbSet<Saldos> Saldos { get; set; }
        public virtual DbSet<vSaldos> vSaldos { get; set; }
        public virtual DbSet<vCompensaciones> vCompensaciones { get; set; }
        public virtual DbSet<vAusentismos> vAusentismos { get; set; }
        public virtual DbSet<Cat_HonorariosFacturas> Cat_HonorariosFacturas { get; set; }
        public virtual DbSet<HistoricoHonorarios> HistoricoHonorarios { get; set; }
        public virtual DbSet<Honorarios> Honorarios { get; set; }
        public virtual DbSet<vHonorarios> vHonorarios { get; set; }
        public virtual DbSet<Ausentismos> Ausentismos { get; set; }
        public virtual DbSet<vConceptos> vConceptos { get; set; }
        public virtual DbSet<vIncidencias> vIncidencias { get; set; }
        public virtual DbSet<vIncidencias_Consolidadas> vIncidencias_Consolidadas { get; set; }
        public virtual DbSet<Incidencias> Incidencias { get; set; }
        public virtual DbSet<Cat_TipoPeriodo> Cat_TipoPeriodo { get; set; }
    
        public virtual ObjectResult<sp_ReciboTradicionalDeducciones_Result> sp_ReciboTradicionalDeducciones(Nullable<int> idPeriodo, Nullable<int> idEmpleado)
        {
            var idPeriodoParameter = idPeriodo.HasValue ?
                new ObjectParameter("IdPeriodo", idPeriodo) :
                new ObjectParameter("IdPeriodo", typeof(int));
    
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReciboTradicionalDeducciones_Result>("sp_ReciboTradicionalDeducciones", idPeriodoParameter, idEmpleadoParameter);
        }
    
        public virtual ObjectResult<sp_AcumuladoFaltasAnual_Result> sp_AcumuladoFaltasAnual(Nullable<int> idUnidadNegocio, Nullable<int> año)
        {
            var idUnidadNegocioParameter = idUnidadNegocio.HasValue ?
                new ObjectParameter("IdUnidadNegocio", idUnidadNegocio) :
                new ObjectParameter("IdUnidadNegocio", typeof(int));
    
            var añoParameter = año.HasValue ?
                new ObjectParameter("Año", año) :
                new ObjectParameter("Año", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_AcumuladoFaltasAnual_Result>("sp_AcumuladoFaltasAnual", idUnidadNegocioParameter, añoParameter);
        }
    
        public virtual int sp_DesAcumulaPeriodoNomina(Nullable<int> idPeriodoNomina)
        {
            var idPeriodoNominaParameter = idPeriodoNomina.HasValue ?
                new ObjectParameter("IdPeriodoNomina", idPeriodoNomina) :
                new ObjectParameter("IdPeriodoNomina", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DesAcumulaPeriodoNomina", idPeriodoNominaParameter);
        }
    
        public virtual int sp_AcumulaPeriodoNomina(Nullable<int> idPeriodoNomina, Nullable<int> idUsuario, Nullable<System.DateTime> fechaDispersion)
        {
            var idPeriodoNominaParameter = idPeriodoNomina.HasValue ?
                new ObjectParameter("IdPeriodoNomina", idPeriodoNomina) :
                new ObjectParameter("IdPeriodoNomina", typeof(int));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var fechaDispersionParameter = fechaDispersion.HasValue ?
                new ObjectParameter("FechaDispersion", fechaDispersion) :
                new ObjectParameter("FechaDispersion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AcumulaPeriodoNomina", idPeriodoNominaParameter, idUsuarioParameter, fechaDispersionParameter);
        }
    
        public virtual ObjectResult<sp_ReportesHotelesSunset_Result> sp_ReportesHotelesSunset(Nullable<int> idPeriodoNomina)
        {
            var idPeriodoNominaParameter = idPeriodoNomina.HasValue ?
                new ObjectParameter("IdPeriodoNomina", idPeriodoNomina) :
                new ObjectParameter("IdPeriodoNomina", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReportesHotelesSunset_Result>("sp_ReportesHotelesSunset", idPeriodoNominaParameter);
        }
    
        public virtual ObjectResult<sp_PDFSunset_Result> sp_PDFSunset(Nullable<int> idPeriodoNomina)
        {
            var idPeriodoNominaParameter = idPeriodoNomina.HasValue ?
                new ObjectParameter("IdPeriodoNomina", idPeriodoNomina) :
                new ObjectParameter("IdPeriodoNomina", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_PDFSunset_Result>("sp_PDFSunset", idPeriodoNominaParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> sp_DeduccionesEspeciales(Nullable<int> idUnidadnegocio, Nullable<int> idPeriodoNomina, Nullable<int> idEmpleado, Nullable<int> idPuesto, Nullable<decimal> compensacionPuesto, Nullable<decimal> diasLaborados, Nullable<decimal> faltas, Nullable<decimal> sDIMSS, Nullable<int> idCaptura, Nullable<int> idCliente, Nullable<int> idCentroCostos)
        {
            var idUnidadnegocioParameter = idUnidadnegocio.HasValue ?
                new ObjectParameter("IdUnidadnegocio", idUnidadnegocio) :
                new ObjectParameter("IdUnidadnegocio", typeof(int));
    
            var idPeriodoNominaParameter = idPeriodoNomina.HasValue ?
                new ObjectParameter("IdPeriodoNomina", idPeriodoNomina) :
                new ObjectParameter("IdPeriodoNomina", typeof(int));
    
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            var idPuestoParameter = idPuesto.HasValue ?
                new ObjectParameter("IdPuesto", idPuesto) :
                new ObjectParameter("IdPuesto", typeof(int));
    
            var compensacionPuestoParameter = compensacionPuesto.HasValue ?
                new ObjectParameter("CompensacionPuesto", compensacionPuesto) :
                new ObjectParameter("CompensacionPuesto", typeof(decimal));
    
            var diasLaboradosParameter = diasLaborados.HasValue ?
                new ObjectParameter("DiasLaborados", diasLaborados) :
                new ObjectParameter("DiasLaborados", typeof(decimal));
    
            var faltasParameter = faltas.HasValue ?
                new ObjectParameter("Faltas", faltas) :
                new ObjectParameter("Faltas", typeof(decimal));
    
            var sDIMSSParameter = sDIMSS.HasValue ?
                new ObjectParameter("SDIMSS", sDIMSS) :
                new ObjectParameter("SDIMSS", typeof(decimal));
    
            var idCapturaParameter = idCaptura.HasValue ?
                new ObjectParameter("IdCaptura", idCaptura) :
                new ObjectParameter("IdCaptura", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            var idCentroCostosParameter = idCentroCostos.HasValue ?
                new ObjectParameter("IdCentroCostos", idCentroCostos) :
                new ObjectParameter("IdCentroCostos", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("sp_DeduccionesEspeciales", idUnidadnegocioParameter, idPeriodoNominaParameter, idEmpleadoParameter, idPuestoParameter, compensacionPuestoParameter, diasLaboradosParameter, faltasParameter, sDIMSSParameter, idCapturaParameter, idClienteParameter, idCentroCostosParameter);
        }
    
        public virtual int SP_CambioSueldos(Nullable<int> idCaptura, Nullable<int> idUnidadNegocio, Nullable<int> idempleado, Nullable<int> idCliente, Nullable<System.DateTime> fechaMovimiento, Nullable<decimal> sDIMS_Nuevo, Nullable<decimal> sDI_Nuevo, Nullable<decimal> sDIDiario, string observaciones)
        {
            var idCapturaParameter = idCaptura.HasValue ?
                new ObjectParameter("IdCaptura", idCaptura) :
                new ObjectParameter("IdCaptura", typeof(int));
    
            var idUnidadNegocioParameter = idUnidadNegocio.HasValue ?
                new ObjectParameter("IdUnidadNegocio", idUnidadNegocio) :
                new ObjectParameter("IdUnidadNegocio", typeof(int));
    
            var idempleadoParameter = idempleado.HasValue ?
                new ObjectParameter("idempleado", idempleado) :
                new ObjectParameter("idempleado", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            var fechaMovimientoParameter = fechaMovimiento.HasValue ?
                new ObjectParameter("fechaMovimiento", fechaMovimiento) :
                new ObjectParameter("fechaMovimiento", typeof(System.DateTime));
    
            var sDIMS_NuevoParameter = sDIMS_Nuevo.HasValue ?
                new ObjectParameter("SDIMS_Nuevo", sDIMS_Nuevo) :
                new ObjectParameter("SDIMS_Nuevo", typeof(decimal));
    
            var sDI_NuevoParameter = sDI_Nuevo.HasValue ?
                new ObjectParameter("SDI_Nuevo", sDI_Nuevo) :
                new ObjectParameter("SDI_Nuevo", typeof(decimal));
    
            var sDIDiarioParameter = sDIDiario.HasValue ?
                new ObjectParameter("SDIDiario", sDIDiario) :
                new ObjectParameter("SDIDiario", typeof(decimal));
    
            var observacionesParameter = observaciones != null ?
                new ObjectParameter("Observaciones", observaciones) :
                new ObjectParameter("Observaciones", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CambioSueldos", idCapturaParameter, idUnidadNegocioParameter, idempleadoParameter, idClienteParameter, fechaMovimientoParameter, sDIMS_NuevoParameter, sDI_NuevoParameter, sDIDiarioParameter, observacionesParameter);
        }
    
        public virtual ObjectResult<sp_ReciboEsquemaPercepciones_Result> sp_ReciboEsquemaPercepciones(Nullable<int> idPeriodo, Nullable<int> idEmpleado)
        {
            var idPeriodoParameter = idPeriodo.HasValue ?
                new ObjectParameter("IdPeriodo", idPeriodo) :
                new ObjectParameter("IdPeriodo", typeof(int));
    
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReciboEsquemaPercepciones_Result>("sp_ReciboEsquemaPercepciones", idPeriodoParameter, idEmpleadoParameter);
        }
    
        public virtual ObjectResult<sp_ReciboEsquemaDeducciones_Result> sp_ReciboEsquemaDeducciones(Nullable<int> idPeriodo, Nullable<int> idEmpleado)
        {
            var idPeriodoParameter = idPeriodo.HasValue ?
                new ObjectParameter("IdPeriodo", idPeriodo) :
                new ObjectParameter("IdPeriodo", typeof(int));
    
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReciboEsquemaDeducciones_Result>("sp_ReciboEsquemaDeducciones", idPeriodoParameter, idEmpleadoParameter);
        }
    
        public virtual ObjectResult<sp_ReciboRealPercepciones_Result> sp_ReciboRealPercepciones(Nullable<int> idPeriodo, Nullable<int> idEmpleado)
        {
            var idPeriodoParameter = idPeriodo.HasValue ?
                new ObjectParameter("IdPeriodo", idPeriodo) :
                new ObjectParameter("IdPeriodo", typeof(int));
    
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReciboRealPercepciones_Result>("sp_ReciboRealPercepciones", idPeriodoParameter, idEmpleadoParameter);
        }
    
        public virtual ObjectResult<sp_ReciboRealDeducciones_Result> sp_ReciboRealDeducciones(Nullable<int> idPeriodo, Nullable<int> idEmpleado)
        {
            var idPeriodoParameter = idPeriodo.HasValue ?
                new ObjectParameter("IdPeriodo", idPeriodo) :
                new ObjectParameter("IdPeriodo", typeof(int));
    
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReciboRealDeducciones_Result>("sp_ReciboRealDeducciones", idPeriodoParameter, idEmpleadoParameter);
        }
    
        public virtual ObjectResult<sp_PDFSunset1_Result> sp_PDFSunset1(Nullable<int> idPeriodoNomina)
        {
            var idPeriodoNominaParameter = idPeriodoNomina.HasValue ?
                new ObjectParameter("IdPeriodoNomina", idPeriodoNomina) :
                new ObjectParameter("IdPeriodoNomina", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_PDFSunset1_Result>("sp_PDFSunset1", idPeriodoNominaParameter);
        }
    
        public virtual int sp_CambioPeriodoFiniquito(Nullable<int> idPeriodoNomina, Nullable<int> idEmpleado, Nullable<int> idNuevoPeriodoNomina)
        {
            var idPeriodoNominaParameter = idPeriodoNomina.HasValue ?
                new ObjectParameter("IdPeriodoNomina", idPeriodoNomina) :
                new ObjectParameter("IdPeriodoNomina", typeof(int));
    
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            var idNuevoPeriodoNominaParameter = idNuevoPeriodoNomina.HasValue ?
                new ObjectParameter("IdNuevoPeriodoNomina", idNuevoPeriodoNomina) :
                new ObjectParameter("IdNuevoPeriodoNomina", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CambioPeriodoFiniquito", idPeriodoNominaParameter, idEmpleadoParameter, idNuevoPeriodoNominaParameter);
        }
    
        public virtual ObjectResult<sp_Premios_Compensaciones_Result> sp_Premios_Compensaciones(Nullable<int> idUnidadnegocio, Nullable<int> idPeriodoNomina, Nullable<int> idEmpleado, Nullable<int> idPuesto, Nullable<decimal> compensacionPuesto, Nullable<decimal> diasLaborados, Nullable<decimal> faltas, Nullable<decimal> sDIMSS, Nullable<int> idCaptura, Nullable<int> idCliente, Nullable<int> idCentroCostos)
        {
            var idUnidadnegocioParameter = idUnidadnegocio.HasValue ?
                new ObjectParameter("IdUnidadnegocio", idUnidadnegocio) :
                new ObjectParameter("IdUnidadnegocio", typeof(int));
    
            var idPeriodoNominaParameter = idPeriodoNomina.HasValue ?
                new ObjectParameter("IdPeriodoNomina", idPeriodoNomina) :
                new ObjectParameter("IdPeriodoNomina", typeof(int));
    
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            var idPuestoParameter = idPuesto.HasValue ?
                new ObjectParameter("IdPuesto", idPuesto) :
                new ObjectParameter("IdPuesto", typeof(int));
    
            var compensacionPuestoParameter = compensacionPuesto.HasValue ?
                new ObjectParameter("CompensacionPuesto", compensacionPuesto) :
                new ObjectParameter("CompensacionPuesto", typeof(decimal));
    
            var diasLaboradosParameter = diasLaborados.HasValue ?
                new ObjectParameter("DiasLaborados", diasLaborados) :
                new ObjectParameter("DiasLaborados", typeof(decimal));
    
            var faltasParameter = faltas.HasValue ?
                new ObjectParameter("Faltas", faltas) :
                new ObjectParameter("Faltas", typeof(decimal));
    
            var sDIMSSParameter = sDIMSS.HasValue ?
                new ObjectParameter("SDIMSS", sDIMSS) :
                new ObjectParameter("SDIMSS", typeof(decimal));
    
            var idCapturaParameter = idCaptura.HasValue ?
                new ObjectParameter("IdCaptura", idCaptura) :
                new ObjectParameter("IdCaptura", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            var idCentroCostosParameter = idCentroCostos.HasValue ?
                new ObjectParameter("IdCentroCostos", idCentroCostos) :
                new ObjectParameter("IdCentroCostos", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Premios_Compensaciones_Result>("sp_Premios_Compensaciones", idUnidadnegocioParameter, idPeriodoNominaParameter, idEmpleadoParameter, idPuestoParameter, compensacionPuestoParameter, diasLaboradosParameter, faltasParameter, sDIMSSParameter, idCapturaParameter, idClienteParameter, idCentroCostosParameter);
        }
    
        public virtual int sp_Crea_Pass_LaNube(Nullable<int> idEmpleado)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Crea_Pass_LaNube", idEmpleadoParameter);
        }
    
        public virtual ObjectResult<sp_EmpleadosAjusteAnual_Result> sp_EmpleadosAjusteAnual(Nullable<int> idUnidadNegocio, Nullable<int> year)
        {
            var idUnidadNegocioParameter = idUnidadNegocio.HasValue ?
                new ObjectParameter("IdUnidadNegocio", idUnidadNegocio) :
                new ObjectParameter("IdUnidadNegocio", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_EmpleadosAjusteAnual_Result>("sp_EmpleadosAjusteAnual", idUnidadNegocioParameter, yearParameter);
        }
    
        public virtual ObjectResult<sp_NOMINA_IncidenciasFijasAgrupadas_Result> sp_NOMINA_IncidenciasFijasAgrupadas(Nullable<int> idUnidadNegocio)
        {
            var idUnidadNegocioParameter = idUnidadNegocio.HasValue ?
                new ObjectParameter("IdUnidadNegocio", idUnidadNegocio) :
                new ObjectParameter("IdUnidadNegocio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_NOMINA_IncidenciasFijasAgrupadas_Result>("sp_NOMINA_IncidenciasFijasAgrupadas", idUnidadNegocioParameter);
        }
    
        public virtual ObjectResult<sp_RegresaAusentismos_Result> sp_RegresaAusentismos(Nullable<int> idPeriodoNomina)
        {
            var idPeriodoNominaParameter = idPeriodoNomina.HasValue ?
                new ObjectParameter("IdPeriodoNomina", idPeriodoNomina) :
                new ObjectParameter("IdPeriodoNomina", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RegresaAusentismos_Result>("sp_RegresaAusentismos", idPeriodoNominaParameter);
        }
    
        public virtual ObjectResult<sp_RegresaIncidenciasCalculoIndividual_Result> sp_RegresaIncidenciasCalculoIndividual(Nullable<int> idEmpleado, Nullable<int> idPeriodoNomina, Nullable<int> idCliente)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            var idPeriodoNominaParameter = idPeriodoNomina.HasValue ?
                new ObjectParameter("IdPeriodoNomina", idPeriodoNomina) :
                new ObjectParameter("IdPeriodoNomina", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RegresaIncidenciasCalculoIndividual_Result>("sp_RegresaIncidenciasCalculoIndividual", idEmpleadoParameter, idPeriodoNominaParameter, idClienteParameter);
        }
    }
}
