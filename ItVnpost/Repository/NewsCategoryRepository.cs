using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class NewsCategoryRepository : Repository<NewsCategory>, INewsCategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public NewsCategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Remove(object id)
        {
            var newsCategory = _db.NewsCategories.Find(id);
            newsCategory.IsHidden = true;
        }

        public void Update(NewsCategory newsCategory)
        {
            var ncsold = _db.NewsCategories.Find(newsCategory.Id);
            ncsold.Name = newsCategory.Name;
            ncsold.UserIdModified = newsCategory.UserIdModified;
            ncsold.DateModified = DateTime.Now;
            ncsold.Alias = Helper.ConvertAliasVN(newsCategory.Name);
            ncsold.MenuId = newsCategory.MenuId;
            ncsold.IsDisplay = newsCategory.IsDisplay;
            ncsold.OrderPosition = newsCategory.OrderPosition;
        }
    }
}
