using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface IVisionMissionRepository : IRepository<VisionMission>
    {
        void Update(VisionMission VisionMission);
        void Remove(object id);
    }
}
