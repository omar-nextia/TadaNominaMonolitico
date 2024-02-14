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
    
    public partial class TadaTimbradoEntities : DbContext
    {
        public TadaTimbradoEntities()
            : base("name=TadaTimbradoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cat_Token_MasNegocio> Cat_Token_MasNegocio { get; set; }
        public virtual DbSet<LogErrores> LogErrores { get; set; }
        public virtual DbSet<Cat_ConceptosNomina> Cat_ConceptosNomina { get; set; }
        public virtual DbSet<vIncidencias_Consolidadas> vIncidencias_Consolidadas { get; set; }
        public virtual DbSet<Cat_MotivosCancelacionSAT> Cat_MotivosCancelacionSAT { get; set; }
        public virtual DbSet<Cat_RegistroPatronal> Cat_RegistroPatronal { get; set; }
        public virtual DbSet<TimbradoNomina> TimbradoNomina { get; set; }
        public virtual DbSet<XmlNomina> XmlNomina { get; set; }
        public virtual DbSet<vXmlNomina> vXmlNomina { get; set; }
        public virtual DbSet<vTimbradoNomina> vTimbradoNomina { get; set; }
    
        public virtual int sp_InformacionXML_Finiquitos(Nullable<int> idPeriodoNomina)
        {
            var idPeriodoNominaParameter = idPeriodoNomina.HasValue ?
                new ObjectParameter("IdPeriodoNomina", idPeriodoNomina) :
                new ObjectParameter("IdPeriodoNomina", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InformacionXML_Finiquitos", idPeriodoNominaParameter);
        }
    
        public virtual int sp_InformacionXML_Nomina(Nullable<int> idPeriodoNomina)
        {
            var idPeriodoNominaParameter = idPeriodoNomina.HasValue ?
                new ObjectParameter("IdPeriodoNomina", idPeriodoNomina) :
                new ObjectParameter("IdPeriodoNomina", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InformacionXML_Nomina", idPeriodoNominaParameter);
        }
    
        public virtual ObjectResult<sp_InformacionXML_Nomina1_Result> sp_InformacionXML_Nomina1(Nullable<int> idPeriodoNomina)
        {
            var idPeriodoNominaParameter = idPeriodoNomina.HasValue ?
                new ObjectParameter("IdPeriodoNomina", idPeriodoNomina) :
                new ObjectParameter("IdPeriodoNomina", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_InformacionXML_Nomina1_Result>("sp_InformacionXML_Nomina1", idPeriodoNominaParameter);
        }
    
        public virtual ObjectResult<sp_CosteoResumenMensual_Result> sp_CosteoResumenMensual(string idsPeriodoNomina)
        {
            var idsPeriodoNominaParameter = idsPeriodoNomina != null ?
                new ObjectParameter("IdsPeriodoNomina", idsPeriodoNomina) :
                new ObjectParameter("IdsPeriodoNomina", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CosteoResumenMensual_Result>("sp_CosteoResumenMensual", idsPeriodoNominaParameter);
        }
    
        public virtual ObjectResult<sp_CosteoResumenMensualSoloSucursal_Result> sp_CosteoResumenMensualSoloSucursal(string idsPeriodoNomina)
        {
            var idsPeriodoNominaParameter = idsPeriodoNomina != null ?
                new ObjectParameter("IdsPeriodoNomina", idsPeriodoNomina) :
                new ObjectParameter("IdsPeriodoNomina", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CosteoResumenMensualSoloSucursal_Result>("sp_CosteoResumenMensualSoloSucursal", idsPeriodoNominaParameter);
        }
    
        public virtual ObjectResult<sp_CosteoResumenMensualSoloSucursal1_Result> sp_CosteoResumenMensualSoloSucursal1(string idsPeriodoNomina)
        {
            var idsPeriodoNominaParameter = idsPeriodoNomina != null ?
                new ObjectParameter("IdsPeriodoNomina", idsPeriodoNomina) :
                new ObjectParameter("IdsPeriodoNomina", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CosteoResumenMensualSoloSucursal1_Result>("sp_CosteoResumenMensualSoloSucursal1", idsPeriodoNominaParameter);
        }
    
        public virtual int SP_InsertaSaldosCosteo(Nullable<int> idCaptura, Nullable<int> idCliente, Nullable<int> idUnidadnegocio, Nullable<int> idFacturadora, Nullable<decimal> importe)
        {
            var idCapturaParameter = idCaptura.HasValue ?
                new ObjectParameter("IdCaptura", idCaptura) :
                new ObjectParameter("IdCaptura", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            var idUnidadnegocioParameter = idUnidadnegocio.HasValue ?
                new ObjectParameter("IdUnidadnegocio", idUnidadnegocio) :
                new ObjectParameter("IdUnidadnegocio", typeof(int));
    
            var idFacturadoraParameter = idFacturadora.HasValue ?
                new ObjectParameter("IdFacturadora", idFacturadora) :
                new ObjectParameter("IdFacturadora", typeof(int));
    
            var importeParameter = importe.HasValue ?
                new ObjectParameter("Importe", importe) :
                new ObjectParameter("Importe", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertaSaldosCosteo", idCapturaParameter, idClienteParameter, idUnidadnegocioParameter, idFacturadoraParameter, importeParameter);
        }
    
        public virtual int SP_ValidaMontoFacturados(Nullable<int> idCaptura, Nullable<int> idCliente, Nullable<int> idFacturadora, Nullable<int> idcosteo, Nullable<decimal> importe, ObjectParameter texto)
        {
            var idCapturaParameter = idCaptura.HasValue ?
                new ObjectParameter("IdCaptura", idCaptura) :
                new ObjectParameter("IdCaptura", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            var idFacturadoraParameter = idFacturadora.HasValue ?
                new ObjectParameter("IdFacturadora", idFacturadora) :
                new ObjectParameter("IdFacturadora", typeof(int));
    
            var idcosteoParameter = idcosteo.HasValue ?
                new ObjectParameter("idcosteo", idcosteo) :
                new ObjectParameter("idcosteo", typeof(int));
    
            var importeParameter = importe.HasValue ?
                new ObjectParameter("Importe", importe) :
                new ObjectParameter("Importe", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ValidaMontoFacturados", idCapturaParameter, idClienteParameter, idFacturadoraParameter, idcosteoParameter, importeParameter, texto);
        }
    }
}
