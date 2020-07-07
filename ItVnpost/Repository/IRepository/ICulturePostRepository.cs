using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface ICulturePostRepository : IRepository<CulturePost>
    {
        void Update(CulturePost CulturePost);
        void RemoveCulturePost(object id);
    }
}
