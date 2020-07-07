using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Models
{
	public class RecruitmentCareers
	{
		public int Id { get; set; }
		public string NameCareer { get; set; }
		public int? MenuId { get; set; }
		public Guid? UserIdCreated { get; set; }
		public Guid? UserIdModified { get; set; }
		public DateTime DateCreate { get; set; }
		public DateTime DateModified { get; set; }
		public bool IsDisplay { get; set; }
		public ICollection<RecruitmentJob> RecruitmentJobs{ get; set; }
	}
}
