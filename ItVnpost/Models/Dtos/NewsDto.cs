using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItVnpost.Models.Dtos
{
    public class NewsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string SoftTitle
        {
            get
            {
                return Title == null ? "" : (Title.Length > 100 ? (Title.Substring(0, 80) + "...") : Title);
            }
        }
        public string Image { get; set; }
        public DateTime DateCreated { get; set; }
        public string DateDMY
        {
            get
            {
                return DateCreated.ToString("dd/MM/yyyy");
            }
        }

        public int Size { get; set; }
    }
}
