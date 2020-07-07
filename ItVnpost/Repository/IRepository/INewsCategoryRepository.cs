using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface INewsCategoryRepository : IRepository<NewsCategory>
    {
        void Update(NewsCategory newsCategory);
        void Remove(object id);
    }
}
