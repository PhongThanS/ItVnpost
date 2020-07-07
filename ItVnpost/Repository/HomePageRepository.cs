using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class HomePageRepository : Repository<HomePage>, IHomePageRepository
    {
        private readonly ApplicationDbContext _db;
        public HomePageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Save(HomePage homePage)
        {
            var objFromDB = _db.HomePages.FirstOrDefault(s => s.Id == homePage.Id);

            _db.SaveChanges();
        }

        public void UpdateHomeSection(HomePage homePage)
        {
            var objFromDB = _db.HomePages.FirstOrDefault(x => x.Id == homePage.Id);
            objFromDB.IsDisplay = homePage.IsDisplay;
            objFromDB.OrderPosition = homePage.OrderPosition;
            objFromDB.MenuId = homePage.MenuId;
            objFromDB.SectionName = homePage.SectionName;

            _db.SaveChanges();
        }

        public void UpdateHomeSectionWithMenuId(HomePage homePage)
        {
            var objFromDB = _db.HomePages.FirstOrDefault(x => x.MenuId == homePage.MenuId);
            objFromDB.IsDisplay = homePage.IsDisplay;
            objFromDB.OrderPosition = homePage.OrderPosition;
            objFromDB.MenuId = homePage.MenuId;
            objFromDB.SectionName = homePage.SectionName;

            _db.SaveChanges();
        }
    }
}
