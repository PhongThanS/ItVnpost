using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItVnpost.Models
{
    public class Footer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string HrefPage { get; set; }
        public string HrefFacebook { get; set; }
        public string HrefEmail { get; set; }
        public string Image { get; set; }
        public string Color { get; set; }
        public string ColorHover { get; set; }
        public string BackgroundColor { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid? UserIdCreated { get; set; }
        public Guid? UserIdModified { get; set; }

        public AppUser AppUser { get; set; }
    }
}
