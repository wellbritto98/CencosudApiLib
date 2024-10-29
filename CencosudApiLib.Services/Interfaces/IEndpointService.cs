using CencosudApiLib.Data.Dtos;
using CencosudApiLib.Models;
using CencosudApiLib.Services.Generic;

namespace CencosudApiLib.Services.Interfaces
{
    public interface IEndpointService : IGenericService<Endpoint>
    {
        Task<List<ReadComponentInstanceDto>> GetEndpointComponents(int endpointId);
    }
}
