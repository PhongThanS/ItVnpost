using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface INewsRepository : IRepository<News>
    {
        void Update(News news);
        void UpdateViewCount(News news);
        void Remove(object id);
    }
}
