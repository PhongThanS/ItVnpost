using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
	public class RecruitmentBannerRepository :Repository<RecruitmentBanner>,IRecruitmentBannerRepository
	{
		private readonly ApplicationDbContext _db;
		public RecruitmentBannerRepository(ApplicationDbContext db):base(db)
		{
			_db = db;
		}		

		public void Update(RecruitmentBanner recruitmentBanner)
		{
			var bannerold = _db.RecruitmentBanners.FirstOrDefault(s => s.Id == recruitmentBanner.Id);
			bannerold.OrderPosition = recruitmentBanner.OrderPosition;
			bannerold.UserIdModified = recruitmentBanner.UserIdModified;
			bannerold.DateModified = recruitmentBanner.DateModified;
			bannerold.IsDisplay = true;
			_db.SaveChanges();
		}
	}
}
