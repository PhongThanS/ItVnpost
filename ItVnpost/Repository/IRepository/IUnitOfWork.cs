using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        //commond
        IMenuRepository Menu { get; }
        IMenuAdjustmentRepository MenuAdjustment { get; }
        ILayoutRepository Layout { get; }
        IHomePageBanner HomePageBanner { get; }
        IHomePageRepository HomePage { get; }
        ICultureSectionRepository CultureSection { get; }
        ICulturePostRepository CulturePost { get; }
        ICulturePictureRepository CulturePicture { get; }
        ICultureLayoutRepository CultureLayout { get; }
        ICultureAlbumRepository CultureAlbum { get; }
        IRecruitmentBannerRepository RecruitmentBanner { get; }
        IRecruitmentCareersRepository RecruitmentCareers { get; }
        IRecruitmentJobRepository RecruitmentJob { get; }
        IProjectRepository Project { get; }
        IProjectCategoryRepository ProjectCategory { get; }
        IVisionMissionRepository VisionMission { get; }
        IFooterRepository Footer { get; }
        IFooterAdjustmentRepository FooterAdjustment { get; }
        IPartnerRespository Partners { get; }
        IPartnerTypeRespository PartnerTypes { get; }
        INewsRepository News { get; }
        INewsCategoryRepository NewsCategory { get; }
        ISolutionCategoryRepository SolutionCategory { get; }
        ISolutionContentRepository SolutionContent { get; }
        ISolutionPictureRepository SolutionPicture { get; }
        IAppUserRepository AppUser { get; }
        IColorPageRepository ColorPage { get; }

        //commond
        void Save();
    }
}
