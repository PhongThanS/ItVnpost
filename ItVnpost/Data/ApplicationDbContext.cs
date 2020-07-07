using ItVnpost.Data.Configurations;
using ItVnpost.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ItVnpost.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfiguration(new Config c gi day);
            //chamvt's table configuration
            builder.ApplyConfiguration(new RecruitmentBannerConfiguration());
            builder.ApplyConfiguration(new RecruitmentJobConfiguration());
            builder.ApplyConfiguration(new RecruitmentCareersConfiguration());
           
            //Apply general table configurationV

            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new HomePageConfiguration());
            builder.ApplyConfiguration(new HomePageBannerConfiguration());
            builder.ApplyConfiguration(new MenuConfiguration());
            builder.ApplyConfiguration(new MenuAdjustmentConfiguration());
            builder.ApplyConfiguration(new LayoutConfiguration());
            builder.ApplyConfiguration(new CultureLayoutConfiguration());
            builder.ApplyConfiguration(new CulturePictureConfiguration());
            builder.ApplyConfiguration(new CultureSectionConfiguration());
            builder.ApplyConfiguration(new CulturePostConfiguration());
            builder.ApplyConfiguration(new ProjectConfiguration());
            builder.ApplyConfiguration(new ProjectCategoryConfiguration());
            builder.ApplyConfiguration(new PartnerConfiguration());
            builder.ApplyConfiguration(new PartnerTypeConfiguration());
            builder.ApplyConfiguration(new SolutionCategoryConfiguration());
            builder.ApplyConfiguration(new SolutionContentConfiguration());
            builder.ApplyConfiguration(new SolutionPictureConfiguration());
            builder.ApplyConfiguration(new NewsConfiguration());
            builder.ApplyConfiguration(new NewsCategoryConfiguration());
            builder.ApplyConfiguration(new FooterConfiguration());
            builder.ApplyConfiguration(new FooterConfiguration());
            builder.ApplyConfiguration(new VisionMissionConfiguration());
            builder.ApplyConfiguration(new FooterAdjustmentConfiguration());
            builder.ApplyConfiguration(new ColorPageConfiguration());

            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaim");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRole").HasKey(x => new {x.UserId, x.RoleId });
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogin").HasKey(x =>x.UserId);
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaim");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserToken").HasKey(x => x.UserId);
            //base.OnModelCreating(builder);
        }
        //hainv table
        public DbSet<SolutionPicture> SolutionPictures { get; set; }
        public DbSet<SolutionCategory> SolutionCategories { get; set; }
        public DbSet<SolutionContent> SolutionContents { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<ColorPage> ColorPages { get; set; }

        //general table
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<HomePageBanner> HomePageBanners { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuAdjustment> MenuAdjustment { get; set; }
        public DbSet<Layout> Layout { get; set; }
        public DbSet<CultureLayout> CultureLayout { get; set; }
        public DbSet<CulturePost> CulturePost { get; set; }
        public DbSet<CultureSection> CultureSection { get; set; }
        public DbSet<CulturePicture> CulturePicture { get; set; }
        public DbSet<CultureAlbum> CultureAlbums { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public DbSet<VisionMission> VisionMission { get; set; }
        public DbSet<Footer> Footer { get; set; }
        public DbSet<FooterAdjustment> FooterAdjustment { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<PartnerType> PartnerType { get; set; }
        public DbSet<RecruitmentJob> RecruitmentJobs { get; set; }
        public DbSet<RecruitmentBanner> RecruitmentBanners { get; set; }
        public DbSet<RecruitmentCareers> RecruitmentCareers { get; set; }
        
    }
}
