﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Models
{
    public class Layout
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ControllerName { get; set; }

        public ICollection<Menu> Menus { get; set; }
        public ICollection<Footer> Footers { get; set; }
    }
}
