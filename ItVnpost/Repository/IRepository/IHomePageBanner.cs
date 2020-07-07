using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface IHomePageBanner :IRepository<HomePageBanner>
    {
        void Update(HomePageBanner homePageBanner);
    }
}
