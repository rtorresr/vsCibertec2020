using Chinook.Data;
using Chinook.Entities;
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
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            var artista = new ArtistDA();
            lbCantRegistros.Text = artista.Count().ToString();
            dgvListado.DataSource = artista.GetsSP($"%{TbFiltroName.Text}%");
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var insertarArt = new InsertarArtist();
            insertarArt.Show();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var artist = (Artist)dgvListado.Rows[e.RowIndex].DataBoundItem;
            var frm = new InsertarArtist();
            frm.artista = artist;
            frm.ShowDialog();
        }
    }
}
