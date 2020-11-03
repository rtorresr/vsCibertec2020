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
    public partial class formularioNotas : Form
    {
        public formularioNotas()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var notas = new NotasDA();
            var id = notas.InsertDp(new Entities.Notas()
            {
                AlumnoID = Convert.ToInt32(tbAlumnoId.Text),
                CursoID = Convert.ToInt32(tbCursoId.Text),
                Nota = Convert.ToInt32(tbNota.Text)
            });
            lbId.Text = id.ToString();
        }
    }
}
