﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.Base
{
    public class Documento
    {
        public string Tipo { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public virtual decimal CalcularTotal() {
            return Total;
        }
    }
}
