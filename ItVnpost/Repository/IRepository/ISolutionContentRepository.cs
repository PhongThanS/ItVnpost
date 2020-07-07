using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface ISolutionContentRepository: IRepository<SolutionContent>
    {
        void Update(SolutionContent sc);
        void Remove(object id);
    }
}
