using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("Matricula")]
    public class Matricula
    {
        [Key]
        public int MatriculaID { get; set; }
        public DateTime Fecha { get; set; }
        public int GradoID { get; set; }
        public int SeccionID { get; set; }
        public int AlumnoID { get; set; }
    }
}
