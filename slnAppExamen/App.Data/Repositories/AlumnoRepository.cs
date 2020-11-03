using App.Entities;
using App.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repositories
{
    public class AlumnoRepository : GeneryRepository<Alumno>, IAlumnoRepository
    {
        public AlumnoRepository(DbContext context) : base(context)
        {
        }
    }
}
