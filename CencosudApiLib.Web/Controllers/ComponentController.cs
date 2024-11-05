using AutoMapper;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Web.Controllers.GenericController;
using CencosudApiLib.Services.Interfaces;
using CencosudApiLib.Models;
using CencosudApiLib.Data.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CencosudApiLib.Web.Controllers;

public class ComponentQueryParams{
    public int Id { get; set; }
}
public class ComponentController : GenericController<Component, InsertComponentDto, ReadComponentDto, UpdateComponentDto, ComponentQueryParams>
{
    public ComponentController(IComponentService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

    [HttpGet("ComponentUtilization")]
    public async Task<ComponentUtilizationDto> GetComponentUtilization([FromQuery]int componentId)
    {
        var result = await ((IComponentService)_service).GetComponentUtilizationAsync(componentId);
        return result;
    }

}