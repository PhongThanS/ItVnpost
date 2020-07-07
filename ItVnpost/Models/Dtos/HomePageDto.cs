using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Models.Dtos
{
    public class HomePageDto
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public int MenuId { get; set; }
        public int OrderPosition { get; set; }
        public bool IsDisplay { get; set; }


        public Menu Menu { get; set; }
    }
}
