using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Models.Dtos
{
    public class SolutionPictureDto
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public string Thumbnail { get; set; }
        public Guid? UserIdCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid? UserIdModified { get; set; }
        public DateTime? DateModified { get; set; }
        public SolutionContent SolutionContent { get; set; }
    }
}
