﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Models
{
    public class ColorPage
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public string Color { get; set; }
        public string ColorHover { get; set; }
        public string Image { get; set; }
        public Menu Menu { get; set; }
    }
}
