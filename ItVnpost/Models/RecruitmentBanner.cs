using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItVnpost.Models
{
	public class RecruitmentBanner
	{
		[Key]
		public int Id { get; set; }
		public string TitleBanner { get; set; }
		public string ImageRecruitment { get; set; }
		public int? MenuId { get; set; }
		public int? OrderPosition { get; set; }
		public bool IsDisplay { get; set; }
		public Guid? UserIdCreated { get; set; }
		public Guid? UserIdModified { get; set; }
		public DateTime DateCreate { get; set; }
		public DateTime DateModified { get; set; }
	}
}
