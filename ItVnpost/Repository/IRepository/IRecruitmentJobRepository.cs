using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
	public interface IRecruitmentJobRepository: IRepository<RecruitmentJob>
	{
		//void Add(object job);
		void Update(RecruitmentJob job);
		void Remove(object id);
		//RecruitmentJob GetByID(int id);
	}
}
