using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;
using ItVnpost.Utility.Customs.Helper;

namespace ItVnpost.Repository
{
	public class ProjectRepository : Repository<Project>, IProjectRepository
	{

		private readonly ApplicationDbContext _db;
		public ProjectRepository(ApplicationDbContext db) : base(db)
		{			
			_db = db;
		}
		public void Update(Project project)
		{
				var obj = _db.Project.FirstOrDefault(x => x.Id == project.Id);
				obj.MenuId = project.MenuId;
				obj.Name = project.Name;
				obj.Alias = Helper.ConvertAliasVN(project.Name);
				obj.Description = project.Description;
				obj.Thumbnail = project.Thumbnail == null ? obj.Thumbnail : project.Thumbnail;
				obj.DateModified = DateTime.Now;
				obj.UserIdModified = project.UserIdModified;
		}
		public void Remove(object id)
		{
			var news = _db.Project.Find(id);
			news.IsHidden = true;
		}

		public void UpdateViewCount(Project project)
		{
			var obj = _db.Project.FirstOrDefault(x => x.Id == project.Id);
			obj.ViewCount = project.ViewCount + 1;
		}
	}
}
