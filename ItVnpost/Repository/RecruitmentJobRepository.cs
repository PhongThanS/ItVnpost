using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
	public class RecruitmentJobRepository:Repository<RecruitmentJob>, IRecruitmentJobRepository
	{
		private readonly ApplicationDbContext _db;
		public RecruitmentJobRepository(ApplicationDbContext db) :base(db)
		{
			_db = db;
		}

		//public void Add(object job)
		//{
		//	_db.Add(job);
		//	_db.SaveChanges();
		//}

		public void Remove(object id)
		{
			var jobs = _db.RecruitmentJobs.Find(id);
			jobs.IsDisplay = true;
		}

		public void Update(RecruitmentJob job)
		{
			var jobold = _db.RecruitmentJobs.FirstOrDefault(s => s.Id == job.Id);
			jobold.Title = job.Title;
			jobold.Description = job.Description;
			jobold.IsDisplay = job.IsDisplay;
			jobold.UserIdModified = job.UserIdModified;
			jobold.DateModified = DateTime.Now;
		}
		//public RecruitmentJob GetByID(int id)
		//{
		//	var obj = _db.RecruitmentJobs.Find(id);
		//	return obj;
		//}
	}
}
