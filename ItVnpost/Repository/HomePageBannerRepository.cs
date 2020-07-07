using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class HomePageBannerRepository : Repository<HomePageBanner>, IHomePageBanner
    {
        private readonly ApplicationDbContext _db;
        public HomePageBannerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(HomePageBanner homePageBanner)
        {
            var objFromDB = _db.HomePageBanners.FirstOrDefault(s => s.Id == homePageBanner.Id);
            objFromDB.Content = homePageBanner.Content;
            objFromDB.Href = homePageBanner.Href;
            objFromDB.Description = homePageBanner.Description;
            objFromDB.OrderPosition = homePageBanner.OrderPosition;
            objFromDB.IsDisplay = homePageBanner.IsDisplay;
            _db.SaveChanges();
        }
    }
}
