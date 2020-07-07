using System;
using AutoMapper;
using ItVnpost.Models.Dtos;

namespace ItVnpost.Models.Mapper
{
    public class VnpostMappings : Profile
    {
        public VnpostMappings()
        {
            CreateMap<AppRole, AppRoleDto>().ReverseMap();
            CreateMap<AppUser, AppUserDto>().ReverseMap();
            CreateMap<ColorPage, ColorPageDto>().ReverseMap();
            CreateMap<CultureAlbum, CultureAlbumDto>().ReverseMap();
            CreateMap<CultureLayout, CultureLayoutDto>().ReverseMap();
            CreateMap<CulturePicture, CulturePictureDto>().ReverseMap();
            CreateMap<CulturePost, CulturePostDto>().ReverseMap();
            CreateMap<CultureSection, CultureSectionDto>().ReverseMap();
            CreateMap<Footer, FooterDto>().ReverseMap();
            CreateMap<FooterAdjustment, FooterAdjustmentDto>().ReverseMap();
            CreateMap<HomePage, HomePageDto>().ReverseMap();
            CreateMap<HomePageBanner, HomePageBannerDto>().ReverseMap();
            CreateMap<Layout, LayoutDto>().ReverseMap();
            CreateMap<Menu, MenuDto>().ReverseMap();
            CreateMap<MenuAdjustment, MenuAdjustmentDto>().ReverseMap();
            CreateMap<News, NewsDto>().ReverseMap();
            CreateMap<NewsCategory, NewsCategoryDto>().ReverseMap();
            CreateMap<Partner, PartnerDto>().ReverseMap();
            CreateMap<PartnerType, PartnerTypeDto>().ReverseMap();
            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<ProjectCategory, ProjectCategoryDto>().ReverseMap();
            CreateMap<RecruitmentBanner, RecruitmentBannerDto>().ReverseMap();
            CreateMap<RecruitmentCareers, RecruitmentCareersDto>().ReverseMap();
            CreateMap<RecruitmentJob, RecruitmentJobDto>().ReverseMap();
            CreateMap<SolutionCategory, SolutionCategoryDto>().ReverseMap();
            CreateMap<SolutionContent, SolutionContentDto>().ReverseMap();
            CreateMap<SolutionPicture, SolutionPictureDto>().ReverseMap();
            CreateMap<VisionMission, VisionMissionDto>().ReverseMap();
        }
    }
}
