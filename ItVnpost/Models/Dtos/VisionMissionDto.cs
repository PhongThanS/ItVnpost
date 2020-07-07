using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ItVnpost.Models.Dtos
{
    public class VisionMissionDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Tên bài viết không được để trống!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Tiêu đề bài viết không được để trống!")]
        public string Title { get; set; }
        public int MenuId { get; set; }
        [Required(ErrorMessage = "Nội dung viết không được để trống!")]
        public string Detail { get; set; }
        public bool IsDisplayed { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid UserIdCreated { get; set; }
        public Guid? UserIdModified { get; set; }
        public bool IsHidden { get; set; }
        public string Alias { get; set; }
        public Menu Menu { get; set; }
    }
}
