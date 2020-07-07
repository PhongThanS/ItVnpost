using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Models.Dtos
{
    public class MenuDto
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }
        public int? OrderPosition { get; set; }
        public bool IsDisplayHome { get; set; }
        public int LayoutId { get; set; }
        public string MenuIcon { get; set; }
        public bool IsHidden { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid? UserIdCreated { get; set; }
        public Guid? UserIdModified { get; set; }


        public Layout Layout { get; set; }
        public AppUser AppUser { get; set; }
        public HomePage HomePage { get; set; }
        public ICollection<ColorPage> ColorPages { get; set; }
        public ICollection<VisionMission> VisionMissions { get; set; }
        public ICollection<News> News { get; set; }
        public ICollection<NewsCategory> NewsCategories { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<ProjectCategory> ProjectCategories { get; set; }
        public ICollection<SolutionCategory> SolutionCategories { get; set; }
        public ICollection<RecruitmentJob> RecruitmentJobs { get; set; }
        public ICollection<CultureSection> CultureSections { get; set; }
    }
}
