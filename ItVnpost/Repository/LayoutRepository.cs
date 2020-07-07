using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class LayoutRepository : Repository<Layout>, ILayoutRepository
    {
        private readonly ApplicationDbContext _db;
        public LayoutRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Layout layout)
        {
            var objFromDB = _db.Layout.FirstOrDefault(s => s.Id == layout.Id);


            _db.SaveChanges();
        }
    }
}
