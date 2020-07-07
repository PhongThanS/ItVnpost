using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface IHomePageRepository : IRepository<HomePage>
    {
        void Save(HomePage homePage);

        void UpdateHomeSection(HomePage homePage);
        void UpdateHomeSectionWithMenuId(HomePage homePage);
    }
}
