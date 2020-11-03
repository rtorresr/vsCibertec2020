using App.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class ColegioModel : DbContext
    {
        public ColegioModel() : base("name=Colegio")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Alumno> Alumno { get; set; }

        public virtual DbSet<Notas> Notas { get; set; }

        public virtual DbSet<Matricula> Matricula { get; set; }
    }
}
