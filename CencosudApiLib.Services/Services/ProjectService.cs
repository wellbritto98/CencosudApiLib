using AutoMapper;
using CencosudApiLib.Data.Dtos;
using CencosudApiLib.Models;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Services.Generic;
using CencosudApiLib.Services.Interfaces;
using CencosudProjectLib.Models;
using Microsoft.EntityFrameworkCore;

namespace CencosudApiLib.Services.Services
{
    public class ProjectService : GenericService<Project>, IProjectService
    {
        private readonly IProjectRepository _ProjectRepository;
        private readonly IApiInstanceRepository _apiInstanceRepository;
        private readonly IMapper _mapper;

        public ProjectService(IProjectRepository ProjectRepository, IApiInstanceRepository apiInstanceRepository, IMapper mapper) : base(ProjectRepository)
        {
            _ProjectRepository = ProjectRepository;
            _apiInstanceRepository = apiInstanceRepository;
            _mapper = mapper;
        }

        public async Task<List<ReadApiInstanceDto>> GetApiInstances(int projectId)
        {
            var apiInstances = await _apiInstanceRepository.FindAsync(query =>
                query.Where(e => e.ProjectId == projectId)
                    .Include(e => e.Project)
                    .Include(e => e.Api)
            );

            // Map apiInstances to ReadApiInstanceDto using AutoMapper
            var apiInstanceDtos = _mapper.Map<List<ReadApiInstanceDto>>(apiInstances);

            return apiInstanceDtos;
        }
    }
}