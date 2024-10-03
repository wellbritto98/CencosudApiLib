using CencosudApiLib.Models;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Services.Generic;
using CencosudApiLib.Services.Interfaces;

namespace CencosudApiLib.Services.Services
{
    public class ApiService : GenericService<Api>, IApiService
    {
        private readonly IApiRepository _ApiRepository;

        public ApiService(IApiRepository ApiRepository) : base(ApiRepository)
        {
            _ApiRepository = ApiRepository;
        }
    }
}
