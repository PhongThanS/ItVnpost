using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface IProjectCategoryRepository : IRepository<ProjectCategory>
    {
        void Update(ProjectCategory category);
        void Remove(object id);
    }
}
