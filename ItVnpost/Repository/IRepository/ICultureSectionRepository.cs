using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface ICultureSectionRepository : IRepository<CultureSection>
    {
        void Update(CultureSection CultureSection);
        void RemoveCultureSection(object id);
    }
}
