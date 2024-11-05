using CencosudApiLib.Data;
using CencosudApiLib.Data.Dtos;
using CencosudApiLib.Models;
using CencosudApiLib.Repository.GenericRepository;
using CencosudApiLib.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CencosudApiLib.Repository.Repositorys;

public class ComponentRepository : GenericRepository<Component>, IComponentRepository
{
    public ComponentRepository(DataContext context) : base(context)
    {
    }
    public async Task<ComponentUtilizationDto> GetComponentUtilization(int componentId)
    {
        // Consulta para obter todos os projetos associados ao componente
        var projects = await _context.Projects
            .Where(p => _context.ApiInstances
                .Any(ai => ai.ProjectId == p.Id &&
                           _context.ComponentInstance.Any(ci => ci.EndpointId == ai.ApiId && ci.ComponentId == componentId)))
            .Select(p => new ReadProjectDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                // Outros campos de ReadProjectDto conforme necessário
            })
            .ToListAsync();

        // Consulta para obter todas as APIs associadas ao componente
        var apis = await _context.Apis
            .Where(a => _context.ApiInstances
                .Any(ai => ai.ApiId == a.Id &&
                           _context.ComponentInstance.Any(ci => ci.EndpointId == ai.ApiId && ci.ComponentId == componentId)))
            .Select(a => new ReadApiDto
            {
                Id = a.Id,
                Name = a.Name,
                Description = a.Description,
                BaseUrl = a.BaseUrl,
                Version = a.Version,
                // Outros campos de ReadApiDto conforme necessário
            })
            .ToListAsync();

        // Consulta para obter todos os endpoints associados ao componente
        var endpoints = await _context.Endpoints
            .Where(e => _context.ComponentInstance.Any(ci => ci.EndpointId == e.Id && ci.ComponentId == componentId))
            .Select(e => new ReadEndpointDto
            {
                Id = e.Id,
                Path = e.Path,
                Method = e.Method,
                Description = e.Description,
                // Outros campos de ReadEndpointDto conforme necessário
            })
            .ToListAsync();

        // Retorna o objeto DTO com os dados carregados
        return new ComponentUtilizationDto
        {
            Projects = projects,
            Apis = apis,
            Endpoints = endpoints
        };
    }


}