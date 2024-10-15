using AutoMapper;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Web.Controllers.GenericController;
using CencosudApiLib.Services.Interfaces;
using CencosudApiLib.Models;
using CencosudApiLib.Data.Dtos;

namespace CencosudApiLib.Web.Controllers;

public class ApiQueryParams{
    public int ApiId { get; set; }
}
public class ApiController : GenericController<Api, InsertApiDto, ReadApiDto, UpdateApiDto, ApiQueryParams>
{
    public ApiController(IApiService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

}