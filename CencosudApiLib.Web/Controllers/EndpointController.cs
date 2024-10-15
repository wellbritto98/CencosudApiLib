using AutoMapper;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Web.Controllers.GenericController;
using CencosudApiLib.Services.Interfaces;
using CencosudApiLib.Models;
using CencosudApiLib.Data.Dtos;
using Endpoint = CencosudApiLib.Models.Endpoint;

namespace CencosudApiLib.Web.Controllers;

public class EndpointController : GenericController<Endpoint, InsertEndpointDto, ReadEndpointDto, UpdateEndpointDto>
{
    public EndpointController(IEndpointService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

}