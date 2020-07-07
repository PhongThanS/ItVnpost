using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Models.Dtos
{
    public class AppUserDto : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public ICollection<CultureLayout> Cultures { get; set; }
        public ICollection<CultureSection> CultureSections { get; set; }
        public ICollection<CulturePicture> CulturePictures { get; set; }
        public ICollection<CulturePost> CulturePosts { get; set; }
        public ICollection<CultureAlbum> CultureAlbums { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public ICollection<Partner> Partners{ get; set; }
        public ICollection<PartnerType> PartnerTypes { get; set; }
    }
}
