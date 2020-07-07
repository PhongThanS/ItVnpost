using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItVnpost.Models
{
    public class CultureSection
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên khối không được để trống!")]
        public string Name { get; set; }
        public int MenuId { get; set; }
        public int CultureLayoutId { get; set; }
        public bool IsDisplay { get; set; }
        [Range(1,50,ErrorMessage ="Hãy nhập giá trị trong khoảng [1-50].")]
        public int? OrderPosition { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid? UserIdCreated { get; set; }
        public Guid? UserIdModified { get; set; }
        public bool IsHidden { get; set; }
        public string Alias { get; set; }

        public CultureLayout CultureLayout { get; set; }
        public Menu Menu { get; set; }
        public AppUser AppUser { get; set; }
        public ICollection<CulturePicture> CulturePicturess { get; set; }
        public ICollection<CultureAlbum> CultureAlbums { get; set; }
    }
}
