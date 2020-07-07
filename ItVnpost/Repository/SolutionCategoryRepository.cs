using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class SolutionCategoryRepository : Repository<SolutionCategory>, ISolutionCategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public SolutionCategoryRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
        public void Remove(object id)
        {
            var sc = _db.SolutionCategories.Find(id);
            sc.IsHidden = true;
        }

        public void Update(SolutionCategory sc)
        {
            var scsold = _db.SolutionCategories.Find(sc.Id);
            scsold.Name = sc.Name;
            scsold.Title = sc.Title;
            scsold.Thumbnail = sc.Thumbnail;
            scsold.UserIdModified = sc.UserIdModified;
            scsold.Alias = Helper.ConvertAliasVN(sc.Name);
            scsold.MenuId = sc.MenuId;
        }
    }
}
