using App.Data;
using App.Entities;
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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var da = new CustomerDA();
            lbCant.Text = da.Count().ToString();
            dvgListado.DataSource = da.Gets(tbFiltro.Text);
            dvgListado.Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmNuevoCustomer();
            frm.Show();
        }

        private void dvgListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var customer = (Customer)dvgListado.Rows[e.RowIndex].DataBoundItem;
            var frm = new frmNuevoCustomer();
            frm.customer = customer;

            frm.Show();
        }
    }
}
