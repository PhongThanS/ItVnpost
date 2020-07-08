using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
        bool IsUniqueUser(string username);
        AppUser Authenticate(string username, string password);
        AppUser Register(string username, string password);
    }
}
