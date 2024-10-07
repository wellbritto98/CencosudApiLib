using CencosudApiLib.Models;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Services.Generic;
using CencosudApiLib.Services.Interfaces;
using CencosudProjectLib.Models;

namespace CencosudApiLib.Services.Services
{
    public class ApiInstanceService : GenericService<ApiInstance>, IApiInstanceService
    {
        private readonly IApiInstanceRepository _ApiInstanceRepository;

        public ApiInstanceService(IApiInstanceRepository ApiInstanceRepository) : base(ApiInstanceRepository)
        {
            _ApiInstanceRepository = ApiInstanceRepository;
        }
    }
}
