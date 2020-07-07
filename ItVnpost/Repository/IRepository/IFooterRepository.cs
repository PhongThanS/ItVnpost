using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface IFooterRepository : IRepository<Footer>
    {
        void Update(Footer Footer);
    }
}
