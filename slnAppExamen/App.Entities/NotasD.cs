using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class NotasD
    {
        public int Nota { get; set; }
        public string Curso { get; set; }
        public string Grado { get; set; }
        public string Alumno { get; set; }
    }
}
