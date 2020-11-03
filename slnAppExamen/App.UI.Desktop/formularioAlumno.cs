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
    public partial class formularioAlumno : Form
    {
        public formularioAlumno()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var alumno = new AlumnoDA();
            var id = alumno.InsertADO(new Entities.Alumno() { 
                Nombres = tbNombres.Text,
                Apellidos = tbApellidos.Text,
                Direccion = tbDireccion.Text,
                Sexo = tbSexo.Text,
                FechaNacimiento = dtFecha.Value
            });
            lbId.Text = id.ToString();
        }
    }
}
