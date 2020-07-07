using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
	public interface IRecruitmentBannerRepository:IRepository<RecruitmentBanner>
	{
		//void Add(object banner);
		void Update(RecruitmentBanner banner);
	}
}
