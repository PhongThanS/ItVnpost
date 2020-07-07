using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface IFooterAdjustmentRepository : IRepository<FooterAdjustment>
    {
        void Update(FooterAdjustment footerAdjustment);
    }
}
