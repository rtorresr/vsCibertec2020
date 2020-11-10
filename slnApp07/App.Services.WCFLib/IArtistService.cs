using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.WCFLib
{
    [ServiceContract]
    public interface IArtistService
    {
        [OperationContract]
        List<Artist> GetArtists();

        [OperationContract]
        bool InsertArtist(Artist entity);
    }
}
