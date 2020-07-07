using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class SolutionContentRepository : Repository<SolutionContent>, ISolutionContentRepository
    {
        private readonly ApplicationDbContext _db;
        public SolutionContentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Remove(object id)
        {
            var sc = _db.SolutionContents.Find(id);
            sc.IsHidden = true;
        }

        public void Update(SolutionContent sc)
        {
            var scold = _db.SolutionContents.Find(sc.Id);
            scold.CategoryId = sc.CategoryId;
            scold.Name = sc.Name;
            scold.Title = sc.Title;
            scold.Thumbnail = sc.Thumbnail;
            scold.Detail = sc.Detail;
            scold.PathFile = sc.PathFile;
            scold.UserIdCreated = sc.UserIdCreated;
            scold.Alias = Helper.ConvertAliasVN(sc.Name);
        }
    }
}
