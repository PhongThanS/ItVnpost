using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface IMenuAdjustmentRepository : IRepository<MenuAdjustment>
    {
        void Update(MenuAdjustment menuAdjustment);
    }
}
