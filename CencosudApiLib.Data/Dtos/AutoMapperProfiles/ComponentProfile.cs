

using AutoMapper;
using CencosudApiLib.Models;


namespace CencosudApiLib.Data.Dtos.AutoMapperProfiles;

public class CommponentProfile : Profile
{
    public CommponentProfile()
    {
        CreateMap<CencosudApiLib.Models.Component, InsertComponentDto>().ReverseMap();
        CreateMap<CencosudApiLib.Models.Component, ReadComponentDto>().ReverseMap();
        CreateMap<CencosudApiLib.Models.Component, UpdateComponentDto>().ReverseMap();
    }

}