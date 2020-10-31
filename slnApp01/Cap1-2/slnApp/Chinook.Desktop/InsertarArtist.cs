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
    public partial class InsertarArtist : Form
    {
        public Artist artista { get; set; }
        public InsertarArtist()
        {
            InitializeComponent();
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            var artist = new ArtistDA();
            if (this.artista != null)
            {
                artist.UpdateSP(new Entities.Artist() { ArtistId = this.artista.ArtistId, Name = TbNombreNuevo.Text });
            } else
            {
                var id = artist.InsertSPTXLocal(new Entities.Artist() { Name = TbNombreNuevo.Text });
                LbIdResultado.Text = id.ToString();
            }            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InsertarArtist_Load(object sender, EventArgs e)
        {
            if (this.artista != null) {
                TbNombreNuevo.Text = this.artista.Name;
            }            
        }
    }
}
