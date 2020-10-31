using App.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repositories
{
    public class AppUnitOfWork : IAppUnitOfWork
    {
        private readonly DbContext _context;

        public AppUnitOfWork()
        {
            this._context = new ChinookModel();
            CreateRepositories();
        }

        public AppUnitOfWork(DbContext context)
        {
            this._context = context;
            CreateRepositories();
        }

        public IArtistRepository ArtistRepository { get; set; }
        public ICustomerRepository CustomerRepository { get; set; }
        public ITrackRepository TrackRepository { get; set; }

        private void CreateRepositories()
        {
            this.ArtistRepository = new ArtistRepository(this._context);
            this.CustomerRepository = new CustomerRepository(this._context);
            this.TrackRepository = new TrackRepository(this._context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
