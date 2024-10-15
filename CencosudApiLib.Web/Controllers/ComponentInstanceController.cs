using AutoMapper;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Web.Controllers.GenericController;
using CencosudApiLib.Services.Interfaces;
using CencosudApiLib.Models;
using CencosudApiLib.Data.Dtos;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;

namespace CencosudApiLib.Web.Controllers;
public class ComponentInstanceQueryParams{
    public int EndpointId { get; set; }
    public int ComponentId { get; set; }
}
public class ComponentInstanceController : GenericController<ComponentInstance, InsertComponentInstanceDto, ReadComponentInstanceDto, UpdateComponentInstanceDto, ComponentInstanceQueryParams>
{
    public ComponentInstanceController(IComponentInstanceService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }



}