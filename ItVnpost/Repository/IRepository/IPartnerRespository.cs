using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface IPartnerRespository : IRepository<Partner>
    {
        void Update(Partner partners);
        void Remove(object id);
	}
}
