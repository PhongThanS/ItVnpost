using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        private readonly ApplicationDbContext _db;
        public MenuRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Menu menu)
        {
            var objFromDB = _db.Menu.FirstOrDefault(s => s.Id == menu.Id);
            objFromDB.ParentId = menu.ParentId;
            objFromDB.Name = menu.Name;
            objFromDB.Href = menu.Href;
            objFromDB.OrderPosition = menu.OrderPosition;
            objFromDB.IsDisplayHome = menu.IsDisplayHome;
            objFromDB.LayoutId = menu.LayoutId;
            objFromDB.MenuIcon = menu.MenuIcon;
            objFromDB.IsHidden = menu.IsHidden;
            objFromDB.DateModified = menu.DateModified;
            objFromDB.UserIdModified = menu.UserIdModified;
            _db.SaveChanges();
        }
    }
}
