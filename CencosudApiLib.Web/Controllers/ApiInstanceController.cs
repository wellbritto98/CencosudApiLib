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

public class ApiInstanceController : GenericController<ApiInstance, InsertApiInstanceDto, ReadApiInstanceDto, UpdateApiInstanceDto>
{
    public ApiInstanceController(IApiInstanceService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

        [HttpGet("Get/{projectId}/{apiId}")]
    [SwaggerOperation(Summary = "Retorna um item pelo ID.",
        Description = "Esse endpoint permite a busca de um item no banco de dados através de sua chave primária, fornecida em formato JSON. " +
        "ID do item no formato JSON. O JSON deve conter as chaves primárias necessárias da entidade no seguinte formato:" +
        "{ \"Chave1\": \"Valor1\",\r\n\"Chave2\": \"Valor2\" }")]
    [ProducesResponseType(StatusCodes.Status200OK)]  // Removido o uso de tipos genéricos nos atributos
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [SwaggerRequestExample(typeof(string), typeof(ExampleId))]
    public async Task<ActionResult<ApiInstance>> Get(int projectId, int apiId)
    {
        try
        {
            var entity = await _service.GetByIdAsync(projectId, apiId);
            if (entity == null) return NotFound();

            return Ok(_mapper.Map<ApiInstance>(entity));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}