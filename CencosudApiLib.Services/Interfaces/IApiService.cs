using CencosudApiLib.Data.Dtos;
using CencosudApiLib.Models;
using CencosudApiLib.Services.Generic;

namespace CencosudApiLib.Services.Interfaces
{
    public interface IApiService : IGenericService<Api>
    {
        Task<List<ReadEndpointDto>> GetApiEndpoints(int apiId);

    }
}
