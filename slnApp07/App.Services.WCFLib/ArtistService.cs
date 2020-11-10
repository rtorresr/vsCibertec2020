using App.Data.Repositories;
using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace App.Services.WCFLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ArtistService : IArtistService
    {
        public List<Artist> GetArtists()
        {
            var uw = new AppUnitOfWork();
            var retorno = uw.ArtistRepository.GetAll();
            uw.Dispose();

            return retorno;
        }

        public bool InsertArtist(Artist entity)
        {
            var uw = new AppUnitOfWork();
            uw.ArtistRepository.Add(entity);
            var retorno = uw.Complete();
            uw.Dispose();
            if (retorno > 0)
            {
                return true;
            } else
            {
                return false;
            }
            
        }
    }
}
