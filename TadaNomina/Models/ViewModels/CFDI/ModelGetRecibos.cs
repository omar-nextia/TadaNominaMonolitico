﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TadaNomina.Models.ViewModels.CFDI
{
    public class ModelGetRecibos
    {
        public string xmlB64 { get; set; }
        public string Leyenda { get; set; }
        public string firmaB64 { get; set; }
        public decimal? SMO { get; set; }
    }
}