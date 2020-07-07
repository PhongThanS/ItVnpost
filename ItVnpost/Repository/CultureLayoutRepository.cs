using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
    public class CultureLayoutRepository : Repository<CultureLayout>, ICultureLayoutRepository
    {
        private readonly ApplicationDbContext _db;
        public CultureLayoutRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
