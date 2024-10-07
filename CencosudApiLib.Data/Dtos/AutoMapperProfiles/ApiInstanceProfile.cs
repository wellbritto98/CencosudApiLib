using AutoMapper;
using CencosudApiLib.Models;

namespace CencosudApiLib.Data.Dtos.AutoMapperProfiles;

public class ApiInstanceProfile : Profile
{
    public ApiInstanceProfile()
    {
        CreateMap<ApiInstance, InsertApiInstanceDto>().ReverseMap();
        CreateMap<ApiInstance, ReadApiInstanceDto>().ReverseMap();
        CreateMap<ApiInstance, UpdateApiInstanceDto>().ReverseMap();
    }

}