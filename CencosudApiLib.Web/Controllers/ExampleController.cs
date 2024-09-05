using AutoMapper;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Web.Controllers.GenericController;
using CencosudApiLib.Services.Interfaces;
using CencosudApiLib.Models;
using CencosudApiLib.Data.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace CencosudApiLib.Web.Controllers;

[Authorize]
public class ExampleController : GenericController<ExampleEntity, InsertExampleDto, ReadExampleDto, UpdateExampleDto>
{
    public ExampleController(IExampleService service, IMapper mapper, IHttpContextAccessor httpContextAccessor, IAuditService auditService, IUserService userService) 
        : base(service, mapper, httpContextAccessor, auditService, userService)
    {
    }
}
