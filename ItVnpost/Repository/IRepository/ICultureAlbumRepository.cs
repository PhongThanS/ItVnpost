using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface ICultureAlbumRepository : IRepository<CultureAlbum>
    {
        void Update(CultureAlbum cultureAlbum);
        void Remove(object id);
    }
}
