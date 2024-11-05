using CencosudApiLib.Data.Dtos;
using CencosudApiLib.Models;
using CencosudApiLib.Repository.GenericRepository;

namespace CencosudApiLib.Repository.Interfaces;

public interface IComponentRepository : IGenericRepository<Component>
{
Task<ComponentUtilizationDto> GetComponentUtilization(int componentId);
}