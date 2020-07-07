using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;
using ItVnpost.Utility.Customs.Helper;

namespace ItVnpost.Repository
{
    public class CultureAlbumRepository : Repository<CultureAlbum>, ICultureAlbumRepository
    {
        private readonly ApplicationDbContext _db;
        public CultureAlbumRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        public void Remove(object id)
        {
            var cs = _db.CultureAlbums.Find(id);
            cs.IsHidden = true;
        }

        public void Update(CultureAlbum cultureAlbum)
        {
            var objFromDB = _db.CultureAlbums.FirstOrDefault(s => s.Id == cultureAlbum.Id);

            objFromDB.Name = cultureAlbum.Name;
            objFromDB.SectionId = cultureAlbum.SectionId;
            objFromDB.Alias = Helper.ConvertAliasVN(cultureAlbum.Name);
            objFromDB.DateModified = DateTime.Now;
            objFromDB.IsDisplay = cultureAlbum.IsDisplay;
            objFromDB.OrderPosition = cultureAlbum.OrderPosition;
            objFromDB.UserIdModified = cultureAlbum.UserIdModified;
        }
    }
}
