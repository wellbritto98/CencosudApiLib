using AutoMapper;
using CencosudApiLib.Models;

namespace CencosudApiLib.Data.Dtos.AutoMapperProfiles;

public class ComponentInstanceProfile : Profile
{
    public ComponentInstanceProfile()
    {
        CreateMap<ComponentInstance, InsertComponentInstanceDto>().ReverseMap();
        CreateMap<ComponentInstance, ReadComponentInstanceDto>().ReverseMap();
        CreateMap<ComponentInstance, UpdateComponentInstanceDto>().ReverseMap();
    }

}