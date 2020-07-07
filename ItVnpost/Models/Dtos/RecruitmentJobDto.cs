using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItVnpost.Models.Dtos
{
	public class RecruitmentJobDto
    {
        public int Id { get; set; }
        public int? MenuId { get; set; }
        public int CareerId { get; set; }
        public string Title { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string ImageJob { get; set; }
        public string UserContact { get; set; }
        public int? PhoneContact { get; set; }
        public string EmailContact { get; set; }
        public string AddressContact { get; set; }
        public Guid? UserIdCreated { get; set; }
        public Guid? UserIdModified { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateModified { get; set; }
        public bool IsDisplay { get; set; }
        public RecruitmentCareers RecruitmentCareers { get; set; }
        public Menu Menu { get; set; }
    }
}
