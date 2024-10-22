using CencosudApiLib.Data.Dtos;
using CencosudApiLib.Models;
using CencosudApiLib.Services.Generic;
using CencosudProjectLib.Models;

namespace CencosudApiLib.Services.Interfaces
{
    public interface IProjectService : IGenericService<Project>
    {
        Task<List<ReadApiInstanceDto>> GetApiInstances(int projectId);
    }
}
