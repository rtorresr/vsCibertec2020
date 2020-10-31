using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factura = new Factura();
            factura.Serie = "001";
            factura.Numero = "F0001";
            factura.Tipo = "B";
            factura.Fecha = DateTime.Now;
            factura.Total = 118;
            factura.IGV = 18;
            factura.SubTotal = 100;

            var total = factura.CalcularTotal();

            var factura2 = new Factura();
            factura2.Serie = "002";
            factura2.Numero = "F0002";
            factura2.Tipo = "C";
            factura2.Fecha = DateTime.Now;
            factura2.Total = 134;
            factura2.IGV = 13;
            factura2.SubTotal = 147;

            var factura3 = new Factura();
            factura3.Serie = "003";
            factura3.Numero = "F0003";
            factura3.Tipo = "A";
            factura3.Fecha = DateTime.Now;
            factura3.Total = 45;
            factura3.IGV = 4;
            factura3.SubTotal = 50;

            var facturas = new List<Factura>();
            facturas.Add(factura);
            facturas.Add(factura2);
            facturas.Add(factura3);

            var ordenadoElementos = facturas.OrderBy(item => item.Fecha).ToList();
            var ordenadoDescElementos = facturas.OrderByDescending(item => item.Fecha).ToList();
            var filtro = facturas.Where(item => item.Serie == "001").ToList();
        }
    }
}
