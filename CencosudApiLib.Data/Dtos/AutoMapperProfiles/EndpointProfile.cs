using AutoMapper;
using CencosudApiLib.Models;

namespace CencosudApiLib.Data.Dtos.AutoMapperProfiles;

public class EndpointProfile : Profile
{
    public EndpointProfile()
    {
        CreateMap<Endpoint, InsertEndpointDto>();
        CreateMap<Endpoint, ReadEndpointDto>()
            .ForMember(dest => dest.Api, opt => opt.MapFrom(src => src.Api))
            .ReverseMap();
        CreateMap<Endpoint, UpdateEndpointDto>();
    }

}