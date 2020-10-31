using App.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{    
    public class ArtistDA
    {
        private ChinookModel _context;

        public ArtistDA()
        {
            _context = new ChinookModel();
        }

        public int Count()
        {
            return _context.Artist.Count();
        }

        public List<Artist> Gets(string filterName)
        {
            return _context.Artist.Where(e => e.Name.Contains(filterName)).ToList();
        }

        public int Insert(Artist entity)
        {
            _context.Artist.Add(entity);
            _context.SaveChanges();
            return entity.ArtistId;
        }

        public bool Update(Artist entity)
        {
            _context.Artist.Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            var result = _context.SaveChanges();
            return result>0;
        }
    }
}
