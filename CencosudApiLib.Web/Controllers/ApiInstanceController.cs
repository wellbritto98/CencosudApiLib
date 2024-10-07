using AutoMapper;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Web.Controllers.GenericController;
using CencosudApiLib.Services.Interfaces;
using CencosudApiLib.Models;
using CencosudApiLib.Data.Dtos;

namespace CencosudApiLib.Web.Controllers;

public class ApiInstanceController : GenericController<ApiInstance, InsertApiInstanceDto, ReadApiInstanceDto, UpdateApiInstanceDto>
{
    public ApiInstanceController(IApiInstanceService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

}