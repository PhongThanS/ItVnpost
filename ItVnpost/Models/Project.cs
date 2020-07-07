using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItVnpost.Models
{
	public class Project
	{
		public int Id { get; set; }
		public int MenuId { get; set; }
		public int CategoryId { get; set; }
		[Required(ErrorMessage = "Tên bài viết không được để trống!")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Tiêu đề bài viết không được để trống!")]
		public string Description { get; set; }
		public string Thumbnail { get; set; }
		public string Content { get; set; }
		public int ViewCount { get; set; }
		public string Alias { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime? DateModified { get; set; }
		public Guid? UserIdCreated { get; set; }
		public Guid? UserIdModified { get; set; }
		public bool IsHidden { get; set; }
		public ProjectCategory ProjectCategory { get; set; }
		public Menu Menu { get; set; }

	}
}
