using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [Table("Notas")]
    public class Notas
    {
        [Key]
        public int NotaID { get; set; }
        public int AlumnoID { get; set; }
        public int CursoID { get; set; }
        public int Nota { get; set; }
    }
}
