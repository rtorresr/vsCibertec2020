using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.Desktop
{
    public partial class formMenuPrincipal : Form
    {
        public formMenuPrincipal()
        {
            InitializeComponent();
        }

        private void artistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new formCustomer();
            frm.Show();
        }

        private void artistaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Show();
        }

        private void customerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var frm = new formCustomer();
            frm.Show();
        }
    }
}
