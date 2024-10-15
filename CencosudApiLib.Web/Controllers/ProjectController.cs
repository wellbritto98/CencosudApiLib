using AutoMapper;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Web.Controllers.GenericController;
using CencosudApiLib.Services.Interfaces;
using CencosudApiLib.Models;
using CencosudApiLib.Data.Dtos;
using CencosudProjectLib.Models;
using CencosudProjectLib.Data.Dtos;

namespace CencosudApiLib.Web.Controllers;
public class ProjectQueryParams{
    public int ProjectId { get; set; }
}
public class ProjectController : GenericController<Project, InsertProjectDto, ReadProjectDto, UpdateProjectDto, ProjectQueryParams>
{
    public ProjectController(IProjectService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

}