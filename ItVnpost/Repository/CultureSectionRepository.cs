using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class CultureSectionRepository : Repository<CultureSection>, ICultureSectionRepository
    {
        private readonly ApplicationDbContext _db;

        public CultureSectionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void RemoveCultureSection(object id)
        {
            var cs = _db.CultureSection.Find(id);
            cs.IsHidden = true;
        }

        public void Update(CultureSection cultureSection)
        {
            var objFromDB = _db.CultureSection.FirstOrDefault(s => s.Id == cultureSection.Id);

            objFromDB.Name = cultureSection.Name;
            objFromDB.MenuId = cultureSection.MenuId;
            objFromDB.CultureLayoutId = cultureSection.CultureLayoutId;
            objFromDB.Alias = Helper.ConvertAliasVN(cultureSection.Name);
            objFromDB.DateModified = DateTime.Now;
            objFromDB.IsDisplay = cultureSection.IsDisplay;
            objFromDB.OrderPosition = cultureSection.OrderPosition;
            objFromDB.UserIdModified = cultureSection.UserIdModified;
        }
    }
}
