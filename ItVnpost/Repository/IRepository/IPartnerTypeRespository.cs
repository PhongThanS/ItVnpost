using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface IPartnerTypeRespository : IRepository<PartnerType>
    {
        void Update(PartnerType partnertypes); 
        void Remove(object id);
    }
}
