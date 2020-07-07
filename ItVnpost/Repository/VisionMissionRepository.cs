using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class VisionMissionRepository : Repository<VisionMission>, IVisionMissionRepository
    {
        private readonly ApplicationDbContext _db;
        public VisionMissionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Remove(object id)
        {
            var visionmission = _db.VisionMission.Find(id);
            visionmission.IsHidden = true;
        }

        public void Update(VisionMission visionMission)
        {
            var objFromDB = _db.VisionMission.FirstOrDefault(s => s.Id == visionMission.Id);

            objFromDB.Name = visionMission.Name;
            objFromDB.MenuId = visionMission.MenuId;
            objFromDB.Detail = visionMission.Detail;
            objFromDB.Title = visionMission.Title;
            objFromDB.UserIdModified = visionMission.UserIdModified;
            objFromDB.DateModified = DateTime.Now;
            objFromDB.IsHidden = visionMission.IsHidden;
            objFromDB.IsDisplayed = visionMission.IsDisplayed;
            objFromDB.Alias = ItVnpost.Utility.Customs.Helper.Helper.ConvertAliasVN(visionMission.Name);
        }
    }
}

