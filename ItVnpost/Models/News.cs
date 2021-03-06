﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItVnpost.Models
{
    public class News
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        //Mô tả bản ghi
        public string Title { get; set; }
        public string Image { get; set; }
        [DataType(DataType.MultilineText)]
        public string Detail { get; set; }
        public string Author { get; set; }
        public int ViewCount { get; set; }
        public Guid? UserIdCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid? UserIdModified { get; set; }
        public DateTime? DateModified { get; set; }
        public string Alias { get; set; }
        public bool IsHidden { get; set; }

        public NewsCategory NewsCategory { get; set; }
        public Menu Menu { get; set; }
    }
}
