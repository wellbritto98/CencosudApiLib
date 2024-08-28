using AutoMapper;
using CencosudApiLib.Data.Dtos.Auth;
using CencosudApiLib.Models.Auth;

namespace CencosudApiLib.Data.Dtos.AutoMapperProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisterUserDto, User>();
        CreateMap<LoginUserDto, User>();

    }

}