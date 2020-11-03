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
            this._context = new ColegioModel();
            CreateRepositories();
        }

        public AppUnitOfWork(DbContext context)
        {
            this._context = context;
            CreateRepositories();
        }

        public IAlumnoRepository AlumnoRepository { get; set; }
        public INotasRepository NotasRepository { get; set; }
        public IMatriculaRepository MatriculaRepository { get; set; }

        private void CreateRepositories()
        {
            this.AlumnoRepository = new AlumnoRepository(this._context);
            this.NotasRepository = new NotasRepository(this._context);
            this.MatriculaRepository = new MatriculaRepository(this._context);
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
