using AutoMapper;
using CencosudApiLib.Models;

namespace CencosudApiLib.Data.Dtos.AutoMapperProfiles;

public class EndpointProfile : Profile
{
    public EndpointProfile()
    {
        CreateMap<Endpoint, InsertEndpointDto>().ReverseMap();
        CreateMap<Endpoint, ReadEndpointDto>().ReverseMap();
        CreateMap<Endpoint, UpdateEndpointDto>().ReverseMap();
    }

}