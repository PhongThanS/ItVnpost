using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface ILayoutRepository :  IRepository<Layout>
    {
        void Update(Layout layout);
    }
}
