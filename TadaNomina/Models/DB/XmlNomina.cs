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
    
    public partial class XmlNomina
    {
        public int IdXml { get; set; }
        public Nullable<int> IdPeriodoNomina { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public Nullable<int> IdRegistroPatronal { get; set; }
        public string XML { get; set; }
        public string Leyenda { get; set; }
        public Nullable<System.Guid> Guid { get; set; }
        public Nullable<int> IdEstatus { get; set; }
        public Nullable<int> IdCaptura { get; set; }
        public Nullable<System.DateTime> FechaCaptura { get; set; }
        public Nullable<int> IdModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public string UsoXML { get; set; }
        public string FoliosUUIDRelacionados { get; set; }
    }
}
