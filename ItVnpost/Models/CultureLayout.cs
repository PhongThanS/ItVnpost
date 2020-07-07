using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Models
{
    public class CultureLayout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid? UserIdCreated { get; set; }
        public Guid? UserIdModified { get; set; }

        public ICollection<CultureSection> CultureSections { get; set; }
        public AppUser AppUser { get; set; }
    }
}
