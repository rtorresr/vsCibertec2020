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
    public class GenreRepository : GeneryRepository<Genre>, IGenreRepository
    {
        public GenreRepository(DbContext context): base(context)
        {
        }
    }
}
