using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.Repository;
using Microsoft.Extensions.Options;
using ItVnpost.Utility.App;

namespace ItVnpost.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public IMenuRepository Menu { get; private set; }
        public IMenuAdjustmentRepository MenuAdjustment { get; private set; }
        public ILayoutRepository Layout { get; private set; }

        public IHomePageBanner HomePageBanner { get; private set; }
        public IHomePageRepository HomePage { get; private set; }

        public IProjectRepository Project { get; private set; }
        public IProjectCategoryRepository ProjectCategory { get; private set; }

        public ICultureLayoutRepository CultureLayout { get; private set; }
        public ICultureSectionRepository CultureSection { get; private set; }
        public ICulturePostRepository CulturePost { get; private set; }
        public ICulturePictureRepository CulturePicture { get; private set; }
        public ICultureAlbumRepository CultureAlbum { get; private set; }
        public IRecruitmentBannerRepository RecruitmentBanner { get; private set; }
        public IRecruitmentCareersRepository RecruitmentCareers { get; private set; }
        public IRecruitmentJobRepository RecruitmentJob { get; private set; }


        public INewsRepository News { get; private set; }
        public INewsCategoryRepository NewsCategory { get; private set; }
        public ISolutionCategoryRepository SolutionCategory { get; private set; }
        public IPartnerRespository Partners { get; private set; }
        public IPartnerTypeRespository PartnerTypes { get; private set; }
        public IVisionMissionRepository VisionMission { get; private set; }
        public IFooterRepository Footer { get; private set; }
        public ISolutionContentRepository SolutionContent { get; private set; }
        public ISolutionPictureRepository SolutionPicture { get; private set; }
        public IFooterAdjustmentRepository FooterAdjustment { get; private set; }
        public IAppUserRepository AppUser { get; private set; }
        public IColorPageRepository ColorPage { get; private set; }

        public UnitOfWork(ApplicationDbContext db, IOptions<AppSettings> appSettings)
        {
            _db = db;

            Menu = new MenuRepository(_db);
            MenuAdjustment = new MenuAdjustmentRepository(_db);
            Layout = new LayoutRepository(_db);

            HomePageBanner = new HomePageBannerRepository(_db);
            HomePage = new HomePageRepository(_db);

            Project = new ProjectRepository(_db);
            ProjectCategory = new ProjectCategoryRepository(_db);

            CultureLayout = new CultureLayoutRepository(_db);
            CultureSection = new CultureSectionRepository(_db);
            CulturePost = new CulturePostRepository(_db);
            CulturePicture = new CulturePictureRepository(_db);
            CultureAlbum = new CultureAlbumRepository(_db);

            News = new NewsRepository(_db);
            VisionMission = new VisionMissionRepository(_db);
            Partners = new PartnerRespository(_db);
            PartnerTypes = new PartnerTypeRespository(_db);
            Footer = new FooterRepository(_db);
            Menu = new MenuRepository(_db);
            SolutionContent = new SolutionContentRepository(_db);
            SolutionCategory = new SolutionCategoryRepository(_db);
            SolutionPicture = new SolutionPictureRepository(_db);
            RecruitmentBanner = new RecruitmentBannerRepository(_db);
            RecruitmentCareers = new RecruitmentCareersRepository(_db);
            RecruitmentJob = new RecruitmentJobRepository(_db);

            VisionMission = new VisionMissionRepository(_db);
            Footer = new FooterRepository(_db);
            FooterAdjustment = new FooterAdjustmentRepository(_db);
            AppUser = new AppUserRepository(_db, appSettings);
            NewsCategory = new NewsCategoryRepository(_db);
            ColorPage = new ColorPageRepository(_db);
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
