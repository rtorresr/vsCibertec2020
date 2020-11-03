using App.Data;
using App.Data.Repositories;
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
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            var alumno = new AlumnoDA();
            dvgListado.DataSource = alumno.GetAllADO($"%{tbFiltro.Text}%");
            dvgListado.Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var formularioAlumno = new formularioAlumno();
            formularioAlumno.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uw = new AppUnitOfWork();

            dvgListado.DataSource = uw.AlumnoRepository.GetAll(f => f.Nombres.Contains(tbFiltro.Text));
            dvgListado.Refresh();
        }
    }
}
