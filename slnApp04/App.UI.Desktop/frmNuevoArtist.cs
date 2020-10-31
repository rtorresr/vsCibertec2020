using App.Data;
using App.Data.Repositories;
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
    public partial class frmNuevoArtist : Form
    {
        public Artist artist { get; set; }
        public frmNuevoArtist()
        {            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void MostrarDatos()
        {
            if (this.IsEdit())
            {
                //var entidad = new ArtistDA().Get(this.artist.ArtistId);
                //var entidad = new ArtistDA().GetAll(this.artist.ArtistId);
                var uw = new AppUnitOfWork();
                var entidad = uw.ArtistRepository.GetById(this.artist.ArtistId);
                if (entidad != null)
                {
                    tbNombre.Text = entidad.Name;
                }                
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var artist = new Artist();
            artist.Name = tbNombre.Text;

            //var da = new ArtistDA();
            var uw = new AppUnitOfWork();
            if (this.IsEdit())
            {
                artist.ArtistId = this.artist.ArtistId;
                uw.ArtistRepository.Update(artist);
            } else
            {
                uw.ArtistRepository.Add(artist);
            }
            uw.Complete();
            this.Close();
        }

        private bool IsEdit()
        {
            if (this.artist != null)
            {
                return true;
            }
            return false;
        }

        private void frmNuevoArtist_Load(object sender, EventArgs e)
        {
            this.MostrarDatos();
        }
    }
}
