using AutoMapper;
using CencosudApiLib.Models;
using CencosudProjectLib.Data.Dtos;
using CencosudProjectLib.Models;

namespace CencosudApiLib.Data.Dtos.AutoMapperProfiles;

public class ProjectProfile : Profile
{
    public ProjectProfile()
    {
        CreateMap<Project, InsertProjectDto>().ReverseMap();
        CreateMap<Project, ReadProjectDto>().ReverseMap();
        CreateMap<Project, UpdateProjectDto>().ReverseMap();
    }

}