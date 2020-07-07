using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface ICulturePictureRepository : IRepository<CulturePicture>
    {
        void RemoveculturePicture(object id);
    }
}
