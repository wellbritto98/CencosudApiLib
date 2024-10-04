using AutoMapper;
using CencosudApiLib.Models;

namespace CencosudApiLib.Data.Dtos.AutoMapperProfiles;

public class ApiProfile : Profile
{
    public ApiProfile()
    {
        CreateMap<Api, InsertApiDto>().ReverseMap();
        CreateMap<Api, ReadApiDto>().ReverseMap();
        CreateMap<Api, UpdateApiDto>().ReverseMap();
    }

}