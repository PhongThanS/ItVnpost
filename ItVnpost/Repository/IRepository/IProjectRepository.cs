using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
	public interface IProjectRepository : IRepository<Project>
	{
		void Update(Project project);
		void UpdateViewCount(Project project);
		void Remove(object id);
	}
}
