using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Models.Dtos
{
    public class SolutionCategoryDto
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public Guid? UserIdCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid? UserIdModified { get; set; }
        public DateTime? DateModified { get; set; }
        public string Alias { get; set; }
        public bool IsHidden { get; set; }
        public ICollection<SolutionContent> SolutionContents { get; set; }
        public Menu Menu { get; set; }
    }
}
