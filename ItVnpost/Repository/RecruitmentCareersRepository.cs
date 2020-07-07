using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
	public class RecruitmentCareersRepository : Repository<RecruitmentCareers>, IRecruitmentCareersRepository
	{
		private readonly ApplicationDbContext _db;
		public RecruitmentCareersRepository(ApplicationDbContext db):base(db)
		{
			_db = db;
		}

		public void Remove(object id)
		{
			var career = _db.RecruitmentCareers.Find(id);
			career.IsDisplay = true;
			_db.Entry(career).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
		}

		public void Update(RecruitmentCareers career)
		{
			var objcareer = _db.RecruitmentCareers.FirstOrDefault(x => x.Id == career.Id);

			objcareer.NameCareer = career.NameCareer;
			objcareer.IsDisplay = career.IsDisplay;

			objcareer.UserIdModified = career.UserIdModified;
			objcareer.DateModified = DateTime.Now;
			_db.Entry(objcareer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
		}

	}
}
