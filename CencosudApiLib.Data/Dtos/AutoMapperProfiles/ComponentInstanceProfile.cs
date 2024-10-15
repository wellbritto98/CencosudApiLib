using AutoMapper;
using CencosudApiLib.Models;

namespace CencosudApiLib.Data.Dtos.AutoMapperProfiles;

public class ComponentInstanceProfile : Profile
{
    public ComponentInstanceProfile()
    {
        CreateMap<ComponentInstance, InsertComponentInstanceDto>();
        CreateMap<ComponentInstance, ReadComponentInstanceDto>()
            .ForMember(dest => dest.Component, opt => opt.MapFrom(src => src.Component))
            .ForMember(dest => dest.Endpoint, opt => opt.MapFrom(src => src.Endpoint))
            .ReverseMap();
        CreateMap<ComponentInstance, UpdateComponentInstanceDto>();
    }

}