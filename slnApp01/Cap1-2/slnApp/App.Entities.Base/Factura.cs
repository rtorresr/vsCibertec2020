using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.Base
{
    public class Factura : Documento
    {
        public decimal IGV { get; set; }
        public decimal SubTotal { get; set; }

        public override decimal CalcularTotal()
        {
            var total = (SubTotal * 18) / 100 + SubTotal;
            return total;
        }
    }
}
