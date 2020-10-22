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
    public partial class frmArtist : Form
    {
        public frmArtist()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var da = new ArtistDA();
            //dvgListado.DataSource = da.
            lbCant.Text = da.Count().ToString();
            dvgListado.DataSource = da.Gets(tbFilterName.Text);
            dvgListado.Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = new frmNuevoArtist();
            form.Show();
        }

        private void dvgListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var artista = (Artist)dvgListado.Rows[e.RowIndex].DataBoundItem;
            //mostrando el formulario de edicion de artista
            var form = new frmNuevoArtist();
            form.artist = artista;
            
            form.Show();
        }       
    }
}
