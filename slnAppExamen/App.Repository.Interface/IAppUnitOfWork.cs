using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Interface
{
    public interface IAppUnitOfWork : IDisposable
    {
        IAlumnoRepository AlumnoRepository { get; set; }
        INotasRepository NotasRepository { get; set; }
        IMatriculaRepository MatriculaRepository { get; set; }

        int Complete();
    }
}
