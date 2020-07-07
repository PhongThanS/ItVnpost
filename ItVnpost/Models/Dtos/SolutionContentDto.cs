using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItVnpost.Models.Dtos
{
    public class SolutionContentDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Tên không được để trống!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Tiêu đề không được để trống!")]
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        [DataType(DataType.MultilineText)]
        public string Detail { get; set; }
        public string PathFile { get; set; }
        public Guid? UserIdCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid? UserIdModified { get; set; }
        public DateTime? DateModified { get; set; }
        public string Alias { get; set; }
        public bool IsHidden { get; set; }
        public SolutionCategory SolutionCategory { get; set; }
        public ICollection<SolutionPicture> SolutionPictures { get; set; }
    }
}
