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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmAlumno();
            frm.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmNotas();
            frm.Show();
        }
    }
}
