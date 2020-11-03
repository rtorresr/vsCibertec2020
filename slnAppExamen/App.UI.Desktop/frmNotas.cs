﻿using App.Data;
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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var notas = new NotasDA();
            dvgListado.DataSource = notas.GetAllSPDp($"%{tbGrado.Text}%", $"%{tbCurso.Text}%");
            dvgListado.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formulario = new formularioNotas();
            formulario.Show();
        }
    }
}
