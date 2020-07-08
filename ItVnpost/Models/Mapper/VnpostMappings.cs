using System;
using AutoMapper;
using ItVnpost.Models.Dtos;

namespace ItVnpost.Models.Mapper
{
    public class VnpostMappings : Profile
    {
        public VnpostMappings()
        {
            CreateMap<AppUser, AppUserDto>().ReverseMap();
            CreateMap<News, NewsDto>().ReverseMap();
            CreateMap<NewsCategory, NewsCategoryDto>().ReverseMap();
        }
    }
}
