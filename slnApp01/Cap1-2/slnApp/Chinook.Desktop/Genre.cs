using Chinook.Data;
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
    public partial class Genre : Form
    {
        public Genre()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var genre = new GenreDA();
            LbCant.Text = genre.Count().ToString();
            DgvListar.DataSource = genre.Gets();
        }
    }
}
