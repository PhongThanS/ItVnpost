using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItVnpost.Models
{
    public class ProjectCategory
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public string Name { get; set; }
        public bool IsDisplay { get; set; }
        [Range(1, 50, ErrorMessage = "Hãy nhập giá trị trong khoảng [1-50].")]
        public int? OrderPosition { get; set; }
        public Guid? UserIdCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid? UserIdModified { get; set; }
        public DateTime? DateModified { get; set; }
        public string Alias { get; set; }
        public bool IsHidden { get; set; }
        public ICollection<Project> Projects { get; set; }
        public Menu Menu { get; set; }
    }
}
