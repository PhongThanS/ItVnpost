using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class FooterAdjustmentRepository : Repository<FooterAdjustment>, IFooterAdjustmentRepository
    {
        private readonly ApplicationDbContext _db;
        public FooterAdjustmentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(FooterAdjustment footerAdjustment)
        {
            var objFromDB = _db.FooterAdjustment.FirstOrDefault(s => s.Id == footerAdjustment.Id);


            _db.SaveChanges();
        }
    }
}
