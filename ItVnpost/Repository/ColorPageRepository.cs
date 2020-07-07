using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class ColorPageRepository : Repository<ColorPage>, IColorPageRepository
    {
        private readonly ApplicationDbContext _db;
        public ColorPageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(ColorPage colorPage)
        {
            var obj = _db.ColorPages.FirstOrDefault(x => x.Id == colorPage.Id);
            obj.MenuId = colorPage.MenuId;
            obj.Color = colorPage.Color;
            obj.ColorHover = colorPage.ColorHover;
            obj.Image = colorPage.Image;
        }
    }
}
