using AutoMapper;
using CencosudApiLib.Models;

namespace CencosudApiLib.Data.Dtos.AutoMapperProfiles;

public class ApiInstanceProfile : Profile
{
    public ApiInstanceProfile()
    {
        CreateMap<ApiInstance, InsertApiInstanceDto>();
        CreateMap<ApiInstance, ReadApiInstanceDto>()
            .ForMember(dest => dest.Project, opt => opt.MapFrom(src => src.Project))
            .ForMember(dest => dest.Api, opt => opt.MapFrom(src => src.Api))
            .ReverseMap();
        CreateMap<ApiInstance, UpdateApiInstanceDto>();
    }

}