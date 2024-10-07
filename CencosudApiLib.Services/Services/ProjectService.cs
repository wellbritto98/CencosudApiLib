using CencosudApiLib.Models;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Services.Generic;
using CencosudApiLib.Services.Interfaces;
using CencosudProjectLib.Models;

namespace CencosudApiLib.Services.Services
{
    public class ProjectService : GenericService<Project>, IProjectService
    {
        private readonly IProjectRepository _ProjectRepository;

        public ProjectService(IProjectRepository ProjectRepository) : base(ProjectRepository)
        {
            _ProjectRepository = ProjectRepository;
        }
    }
}
