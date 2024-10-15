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
public class ApiInstanceQueryParams{
    public int ProjectId { get; set; }
    public int ApiId { get; set; }
}
public class ApiInstanceController : GenericController<ApiInstance, InsertApiInstanceDto, ReadApiInstanceDto, UpdateApiInstanceDto, ApiInstanceQueryParams>
{
    public ApiInstanceController(IApiInstanceService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }




}