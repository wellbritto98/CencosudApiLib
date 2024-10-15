using CencosudApiLib.Models;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Services.Generic;
using CencosudApiLib.Services.Interfaces;

namespace CencosudApiLib.Services.Services
{
    public class EndpointService : GenericService<Endpoint>, IEndpointService
    {
        private readonly IEndpointRepository _EndpointRepository;

        public EndpointService(IEndpointRepository EndpointRepository) : base(EndpointRepository)
        {
            _EndpointRepository = EndpointRepository;
        }
    }
}
