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
    
    public partial class Bimestres
    {
        public int IdBimestre { get; set; }
        public Nullable<int> IdMes { get; set; }
        public string Mes { get; set; }
        public Nullable<int> Id_bimestre { get; set; }
        public string DescripcionBimestre { get; set; }
        public Nullable<int> Dias { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string FechaInicioCaptura { get; set; }
        public string FechaFinCaptura { get; set; }
        public string FechaInicioReal { get; set; }
        public string FechaFinReal { get; set; }
    }
}
