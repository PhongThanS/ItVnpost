using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class ProjectCategoryRepository : Repository<ProjectCategory>, IProjectCategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public ProjectCategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Remove(object id)
        {
            var category = _db.ProjectCategories.Find(id);
            category.IsHidden = true;
        }

        public void Update(ProjectCategory category)
        {
            var ncsold = _db.ProjectCategories.Find(category.Id);
            ncsold.Name = category.Name;
            ncsold.UserIdModified = category.UserIdModified;
            ncsold.DateModified = DateTime.Now;
            ncsold.Alias = Helper.ConvertAliasVN(category.Name);
            ncsold.MenuId = category.MenuId;
            ncsold.IsDisplay = category.IsDisplay;
            ncsold.OrderPosition = category.OrderPosition;
        }
    }
}
