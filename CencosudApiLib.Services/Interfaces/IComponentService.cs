using CencosudApiLib.Data.Dtos;
using CencosudApiLib.Models;
using CencosudApiLib.Services.Generic;

namespace CencosudApiLib.Services.Interfaces
{
    public interface IComponentService : IGenericService<Component>
    {
        Task<ComponentUtilizationDto> GetComponentUtilizationAsync(int componentId);
    }
}
