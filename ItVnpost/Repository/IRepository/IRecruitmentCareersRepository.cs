using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
	public interface IRecruitmentCareersRepository: IRepository<RecruitmentCareers>
	{
		//void Add(object careers);
		void Update(RecruitmentCareers careers);
		void Remove(object id);
		//RecruitmentCareers GetByID(int id);
	}
}
