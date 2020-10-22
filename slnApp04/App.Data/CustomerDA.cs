using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class CustomerDA
    {
        private ChinookModel _context;

        public CustomerDA()
        {
            _context = new ChinookModel();
        }

        public int Count()
        {
            return _context.Customer.Count();
        }

        public List<Customer> Gets(string filterName)
        {
            return _context.Customer.Where(e => e.FirstName.Contains(filterName)).ToList();
        }

        public int Insert(Customer entity)
        {
            _context.Customer.Add(entity);
            _context.SaveChanges();
            return entity.CustomerId;
        }

        public bool Update(Customer entity)
        {
            _context.Customer.Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            var result = _context.SaveChanges();
            return result > 0;
        }


        public bool Delete(Customer entity)
        {
            _context.Customer.Attach(entity);
            _context.Customer.Remove(entity);

            var result = _context.SaveChanges();
            return result > 0;
        }
    }
}
