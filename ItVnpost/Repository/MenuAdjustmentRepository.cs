using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace ItVnpost.Repository
{
    public class MenuAdjustmentRepository : Repository<MenuAdjustment>, IMenuAdjustmentRepository
    {
        private readonly ApplicationDbContext _db;
        public MenuAdjustmentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(MenuAdjustment menuAdjustment)
        {
            MenuAdjustment objFromDB = _db.MenuAdjustment.FirstOrDefault(x => x.Id == menuAdjustment.Id);
            if (string.IsNullOrEmpty(menuAdjustment.Value))
            {
                objFromDB.Value = "";
            }
            else
            {
                objFromDB.Value = Regex.Replace(menuAdjustment.Value.Trim(), @"\s+", " ");
            }
            _db.SaveChanges();
        }
    }
}
