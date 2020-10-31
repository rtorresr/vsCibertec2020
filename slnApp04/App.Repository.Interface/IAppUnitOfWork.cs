using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Interface
{
    public interface IAppUnitOfWork : IDisposable
    {
        IArtistRepository ArtistRepository { get; set; }
        ICustomerRepository CustomerRepository { get; set; }
        ITrackRepository TrackRepository { get; set; }

        int Complete();
    }
}
