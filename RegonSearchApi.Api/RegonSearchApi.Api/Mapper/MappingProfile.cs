using AutoMapper;
using RegonSearchApi.DAO.ViewModel;
using RegonSearchApi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegonSearchApi.Api.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CompanyTbl, CompanyListViewModel>();
            CreateMap<CompanyTbl, CompanyDetailViewModel>()
                .ForMember(dest => dest.Adress, opt => opt.MapFrom(src => src.CompanyDetail.Adress))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.CompanyDetail.City.CityName))
                .ForMember(dest => dest.Voivodeship, opt => opt.MapFrom(src => src.CompanyDetail.City.Voivodeship.NameVoivodeship));
        }
    }
}
