using App.Data;
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
    public partial class frmTrack : Form
    {
        public frmTrack()
        {
            InitializeComponent();
        }

        private void frmTrack_Load(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            var da = new TrackDA();
            var result = da.GetTrackByName(tbFiltro.Text);

            //dvgListado.DataSource = da.
            lbCantidad.Text = result.Count().ToString();
            dvgListado.DataSource = result;
            dvgListado.Refresh();
        }
    }
}
