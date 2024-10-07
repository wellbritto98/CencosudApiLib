using CencosudApiLib.Data;
using CencosudApiLib.Models;
using CencosudApiLib.Repository.GenericRepository;
using CencosudApiLib.Repository.Interfaces;
using CencosudProjectLib.Models;

namespace CencosudApiLib.Repository.Repositorys;

public class ProjectRepository : GenericRepository<Project>, IProjectRepository
{
    public ProjectRepository(DataContext context) : base(context)
    {
    }
}