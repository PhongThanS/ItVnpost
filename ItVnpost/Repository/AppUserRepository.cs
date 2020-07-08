using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using ItVnpost.Utility.App;
using Microsoft.Extensions.Options;
using System.Linq;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace ItVnpost.Repository
{
    public class AppUserRepository : Repository<AppUser>, IAppUserRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly AppSettings _appSettings;
        public AppUserRepository(ApplicationDbContext db, IOptions<AppSettings> appSettings) : base(db)
        {
            _db = db;
            _appSettings = appSettings.Value;
        }

        public AppUser Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool IsUniqueUser(string username)
        {
            throw new NotImplementedException();
        }

        public AppUser Register(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
