using AutoMapper;
using CencosudApiLib.Data.Dtos;
using CencosudApiLib.Models;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Services.Generic;
using CencosudApiLib.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CencosudApiLib.Services.Services
{
    public class EndpointService : GenericService<Endpoint>, IEndpointService
    {
        private readonly IEndpointRepository _EndpointRepository;
        private readonly IComponentInstanceRepository _componentInstanceRepository;
        private readonly IMapper _mapper;

        public EndpointService(IEndpointRepository EndpointRepository, 
        IComponentInstanceRepository componentInstanceRepository, IMapper mapper
        ) : base(EndpointRepository)
        {
            _componentInstanceRepository = componentInstanceRepository;
            _mapper = mapper;
            _EndpointRepository = EndpointRepository;
        }
        public async Task<List<ReadComponentInstanceDto>> GetEndpointComponents(int endpointId)
        {
            var componentInstances = await _componentInstanceRepository.FindAsync(query =>
                query.Where(e => e.EndpointId == endpointId).Include(e => e.Endpoint).Include(e => e.Component)
            );

            // Map apiInstances to ReadApiInstanceDto using AutoMapper
            var componentInstanceDtos = _mapper.Map<List<ReadComponentInstanceDto>>(componentInstances);

            return componentInstanceDtos;
        }
    }
}
