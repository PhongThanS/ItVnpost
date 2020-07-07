using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItVnpost.Models
{
    public class CulturePost
    {
        public int Id { get; set; }
        public int CultureSectionId { get; set; }
        public string Name { get; set; }
        public string Thumbnail { get; set; }
        [DataType(DataType.MultilineText)]
        public string Detail { get; set; }
        [DataType(DataType.MultilineText)]
        public string IframeVideos { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid? UserIdCreated { get; set; }
        public Guid? UserIdModified { get; set; }
        public bool IsHidden { get; set; }
        public string Alias { get; set; }

        public CultureSection CultureSection { get; set; }
        public ICollection<CulturePicture> CulturePictures { get; set; }
        public AppUser AppUser { get; set; }
    }
}
