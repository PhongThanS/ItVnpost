using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class CulturePictureRepository : Repository<CulturePicture>, ICulturePictureRepository
    {
        private readonly ApplicationDbContext _db;

        public CulturePictureRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void RemoveculturePicture(object id)
        {
            _db.CulturePicture.Remove(Get(id));
            _db.SaveChanges();
        }
    }
}
