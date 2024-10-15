using AutoMapper;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Web.Controllers.GenericController;
using CencosudApiLib.Services.Interfaces;
using CencosudApiLib.Models;
using CencosudApiLib.Data.Dtos;

namespace CencosudApiLib.Web.Controllers;

public class ComponentQueryParams{
    public int Id { get; set; }
}
public class ComponentController : GenericController<Component, InsertComponentDto, ReadComponentDto, UpdateComponentDto, ComponentQueryParams>
{
    public ComponentController(IComponentService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

}