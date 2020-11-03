using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("Alumno")]
    public class Alumno
    {
        [Key]
        public int AlumnoID { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
