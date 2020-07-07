using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class FooterRepository : Repository<Footer>, IFooterRepository
    {
        private readonly ApplicationDbContext _db;
        public FooterRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Footer footer)
        {
            var objFromDB = _db.Footer.FirstOrDefault(s => s.Id == footer.Id);
            objFromDB.Name = footer.Name;
            objFromDB.Title = footer.Title;
            objFromDB.Address = footer.Address;
            objFromDB.Phone = footer.Phone;
            objFromDB.Email = footer.Email;
            objFromDB.HrefPage = footer.HrefPage;
            objFromDB.HrefEmail = footer.HrefEmail;
            objFromDB.HrefFacebook = footer.HrefFacebook;
            objFromDB.Image = footer.Image;
            objFromDB.Color = footer.Color;
            objFromDB.ColorHover = footer.ColorHover;
            objFromDB.BackgroundColor = footer.BackgroundColor;
        }
    }
}
