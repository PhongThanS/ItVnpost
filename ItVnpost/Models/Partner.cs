using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItVnpost.Models
{
    public class Partner
    {
        public int Id { get; set; }
        public int PartnerTypeId { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public bool IsShow { get; set; }
        [Range(1, 50, ErrorMessage = "Hãy nhập giá trị trong khoảng [1-50].")]
        public int? Order { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid? UserIdCreated { get; set; }
        public Guid? UserIdModified { get; set; }
        public bool IsHidden { get; set; }
        public PartnerType PartnerType { get; set; }
        public AppUser AppUser { get; set; }
    }
}

