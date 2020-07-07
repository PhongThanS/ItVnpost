using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class CulturePostRepository : Repository<CulturePost>, ICulturePostRepository
    {
        private readonly ApplicationDbContext _db;

        public CulturePostRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }
        public void RemoveCulturePost(object id)
        {
            var cs = _db.CulturePost.Find(id);
            cs.IsHidden = true;
        }

        public void Update(CulturePost culturePost)
        {
            var objFromDb = _db.CulturePost.FirstOrDefault(s => s.Id == culturePost.Id);

            objFromDb.DateModified = DateTime.Now;
            objFromDb.Name = culturePost.Name;
            objFromDb.Thumbnail = culturePost.Thumbnail;
            objFromDb.IframeVideos = culturePost.IframeVideos;
            objFromDb.Detail = culturePost.Detail;
            objFromDb.Alias = Helper.ConvertAliasVN(culturePost.Name);
            objFromDb.UserIdModified = culturePost.UserIdModified;
        }
    }
}
