using AutoMapper;
using CencosudApiLib.Data.Dtos;
using CencosudApiLib.Models.Base;

namespace CencosudApiLib.Data.Dtos.AutoMapperProfiles;

public class BaseProfile : Profile
{

    public BaseProfile()
    {
        CreateMap<BaseEntity, BaseDto>().ReverseMap();
    }

}