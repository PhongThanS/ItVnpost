using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface IMenuRepository : IRepository<Menu>
    {
        void Update(Menu menu);
    }
}
