using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface IColorPageRepository : IRepository<ColorPage>
    {
        void Update(ColorPage colorPage);
    }
}
