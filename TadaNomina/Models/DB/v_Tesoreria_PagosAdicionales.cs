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
    
    public partial class v_Tesoreria_PagosAdicionales
    {
        public int IdPagoAdicional { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdUnidadNegocio { get; set; }
        public string Archivo { get; set; }
        public string ObservacionesNomina { get; set; }
        public string ObservacionesTesoreria { get; set; }
        public Nullable<int> IdEstatus { get; set; }
        public Nullable<int> IdCaptura { get; set; }
        public Nullable<System.DateTime> FechaCaptura { get; set; }
        public Nullable<int> IdRechaza { get; set; }
        public Nullable<System.DateTime> FechaRechaza { get; set; }
        public Nullable<int> IdFinaliza { get; set; }
        public Nullable<System.DateTime> FechaFinaliza { get; set; }
        public string Cliente { get; set; }
        public string UnidadNegocio { get; set; }
        public string UsuarioCaptura { get; set; }
        public string UsuarioRechaza { get; set; }
        public string UsuarioFinaliza { get; set; }
        public string estatus { get; set; }
    }
}
