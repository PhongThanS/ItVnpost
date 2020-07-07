using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class NewsRepository : Repository<News>, INewsRepository
    {
        private readonly ApplicationDbContext _db;
        public NewsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Remove(object id)
        {
            var news = _db.News.Find(id);
            news.IsHidden = true;
        }

        public void Update(News news)
        {
            var newsold = _db.News.Find(news.Id);
            newsold.Name = news.Name;
            newsold.Title = news.Title;
            newsold.Image = news.Image;
            newsold.Detail = news.Detail;
            newsold.UserIdModified = news.UserIdModified;
            newsold.Alias = Helper.ConvertAliasVN(news.Name);
            newsold.Author = news.Author;
            newsold.CategoryId = news.CategoryId;
            newsold.MenuId = news.MenuId;
        }

        public void UpdateViewCount(News news)
        {
            var newsold = _db.News.Find(news.Id);
            newsold.ViewCount = news.ViewCount + 1;
        }
    }
}
