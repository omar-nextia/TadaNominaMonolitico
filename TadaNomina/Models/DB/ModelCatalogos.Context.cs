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
    
    public partial class TadaNominaEntities : DbContext
    {
        public TadaNominaEntities()
            : base("name=TadaNominaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<vDepartamentos> vDepartamentos { get; set; }
        public virtual DbSet<Cat_AgrupadorConceptos> Cat_AgrupadorConceptos { get; set; }
        public virtual DbSet<Cat_Departamentos> Cat_Departamentos { get; set; }
        public virtual DbSet<Cat_CentroCostos> Cat_CentroCostos { get; set; }
        public virtual DbSet<Prestaciones> Prestaciones { get; set; }
        public virtual DbSet<vPrestaciones> vPrestaciones { get; set; }
        public virtual DbSet<SubsidioEmpleoSat> SubsidioEmpleoSat { get; set; }
        public virtual DbSet<ActividadEconomica> ActividadEconomica { get; set; }
        public virtual DbSet<ImpuestoSat> ImpuestoSat { get; set; }
        public virtual DbSet<Cat_TipoNomina> Cat_TipoNomina { get; set; }
        public virtual DbSet<FactorIntegracion> FactorIntegracion { get; set; }
        public virtual DbSet<ConfiguracionFechasCalculos> ConfiguracionFechasCalculos { get; set; }
        public virtual DbSet<Cat_Comunicados> Cat_Comunicados { get; set; }
        public virtual DbSet<vComunicados> vComunicados { get; set; }
        public virtual DbSet<Cat_Puestos> Cat_Puestos { get; set; }
        public virtual DbSet<Cat_Bancos> Cat_Bancos { get; set; }
        public virtual DbSet<Cat_RegistroPatronal> Cat_RegistroPatronal { get; set; }
        public virtual DbSet<Cat_TipoAusentismo> Cat_TipoAusentismo { get; set; }
        public virtual DbSet<Cat_TipoIncapacidad> Cat_TipoIncapacidad { get; set; }
        public virtual DbSet<vTipoAusentismo> vTipoAusentismo { get; set; }
        public virtual DbSet<ConfiguracionConceptosFiniquito> ConfiguracionConceptosFiniquito { get; set; }
        public virtual DbSet<vConfiguracionConceptosFiniquitos> vConfiguracionConceptosFiniquitos { get; set; }
        public virtual DbSet<Cat_Areas> Cat_Areas { get; set; }
        public virtual DbSet<Sindicatos> Sindicatos { get; set; }
        public virtual DbSet<Cat_EntidadFederativa> Cat_EntidadFederativa { get; set; }
        public virtual DbSet<Cliente_EmpresaEspecializada> Cliente_EmpresaEspecializada { get; set; }
        public virtual DbSet<Cat_ConceptosChecador> Cat_ConceptosChecador { get; set; }
        public virtual DbSet<Cat_ErroresIMSS> Cat_ErroresIMSS { get; set; }
        public virtual DbSet<EmpleadoInformacionComplementaria> EmpleadoInformacionComplementaria { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<MovimientosIMSS> MovimientosIMSS { get; set; }
        public virtual DbSet<v_IMSS_MovimientosCESS> v_IMSS_MovimientosCESS { get; set; }
        public virtual DbSet<vEmpleadosIMSS_NA> vEmpleadosIMSS_NA { get; set; }
        public virtual DbSet<Cat_Jornadas> Cat_Jornadas { get; set; }
        public virtual DbSet<DepartamentoPuesto> DepartamentoPuesto { get; set; }
        public virtual DbSet<Cat_Sucursales> Cat_Sucursales { get; set; }
        public virtual DbSet<Cat_HonorariosFacturas> Cat_HonorariosFacturas { get; set; }
        public virtual DbSet<vUnidadesNegocio> vUnidadesNegocio { get; set; }
        public virtual DbSet<Cat_Clientes> Cat_Clientes { get; set; }
        public virtual DbSet<Cat_ConceptosNomina> Cat_ConceptosNomina { get; set; }
        public virtual DbSet<vConceptos> vConceptos { get; set; }
        public virtual DbSet<Cat_UnidadNegocio> Cat_UnidadNegocio { get; set; }
    
        public virtual ObjectResult<sp_IMSS_MOVIMIENTOSIMSS_CLIENTES_NO_ADMINISTRADOS_Result> sp_IMSS_MOVIMIENTOSIMSS_CLIENTES_NO_ADMINISTRADOS(Nullable<int> idCliente, Nullable<System.DateTime> fechaInicial, Nullable<System.DateTime> fechaFinal)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            var fechaInicialParameter = fechaInicial.HasValue ?
                new ObjectParameter("FechaInicial", fechaInicial) :
                new ObjectParameter("FechaInicial", typeof(System.DateTime));
    
            var fechaFinalParameter = fechaFinal.HasValue ?
                new ObjectParameter("FechaFinal", fechaFinal) :
                new ObjectParameter("FechaFinal", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_IMSS_MOVIMIENTOSIMSS_CLIENTES_NO_ADMINISTRADOS_Result>("sp_IMSS_MOVIMIENTOSIMSS_CLIENTES_NO_ADMINISTRADOS", idClienteParameter, fechaInicialParameter, fechaFinalParameter);
        }
    }
}
