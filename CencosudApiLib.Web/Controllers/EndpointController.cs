using AutoMapper;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Web.Controllers.GenericController;
using CencosudApiLib.Services.Interfaces;
using CencosudApiLib.Models;
using CencosudApiLib.Data.Dtos;
using Endpoint = CencosudApiLib.Models.Endpoint;
using Microsoft.AspNetCore.Mvc;

namespace CencosudApiLib.Web.Controllers;
public class EndpointQueryParams{
    public int EndpointId { get; set; }
}
public class EndpointController : GenericController<Endpoint, InsertEndpointDto, ReadEndpointDto, UpdateEndpointDto, EndpointQueryParams>
{
    public EndpointController(IEndpointService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

    
    [HttpGet("GetEndpointComponents")]
    public async Task<List<ReadComponentInstanceDto>?> GetEndpointComponents([FromQuery]int endpointId)
    {
        var result = await ((IEndpointService)_service).GetEndpointComponents(endpointId);
        return result;
    }

}