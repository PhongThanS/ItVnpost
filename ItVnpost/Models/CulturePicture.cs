using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Models
{
    public class CulturePicture
    {
        public int Id { get; set; }
        public int? CultureSectionId { get; set; }
        public int? CulturePostId { get; set; }
        public int? CultureAlbumId { get; set; }
        //public string Content { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
        //public int OrderPosition { get; set; }
        public bool IsHighlights { get; set; }
        public DateTime DateCreated { get; set; }
        //public DateTime? DateModified { get; set; }
        public Guid? UserIdCreated { get; set; }
        //public Guid? UserIdModified { get; set; }

        public CultureSection CultureSection { get; set; }
        public CulturePost CulturePost { get; set; }
        public CultureAlbum CultureAlbum { get; set; }
        public AppUser AppUser { get; set; }
    }
}
