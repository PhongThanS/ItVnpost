﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItVnpost.Models.Dtos
{
    public class CultureAlbumDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SectionId { get; set; }
        public bool IsDisplay { get; set; }
        [Range(1, 50, ErrorMessage = "Hãy nhập giá trị trong khoảng [1-50].")]
        public int? OrderPosition { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid? UserIdCreated { get; set; }
        public Guid? UserIdModified { get; set; }
        public bool IsHidden { get; set; }
        public string Alias { get; set; }

        public CultureSection CultureSection { get; set; }
        public AppUser AppUser { get; set; }
        public ICollection<CulturePicture> CulturePictures { get; set; }
    }
}
