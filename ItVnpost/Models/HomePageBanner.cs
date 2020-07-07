using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItVnpost.Models
{
   public class HomePageBanner
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Href { get; set; }
        public string Description { get; set; }
        [Range(1, 50, ErrorMessage = "Hãy nhập giá trị trong khoảng [1-50].")]
        public int? OrderPosition { get; set; }
        public bool IsDisplay { get; set; }

    }
}
