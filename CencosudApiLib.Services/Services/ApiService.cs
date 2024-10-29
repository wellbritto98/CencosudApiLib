using AutoMapper;
using CencosudApiLib.Data.Dtos;
using CencosudApiLib.Models;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Services.Generic;
using CencosudApiLib.Services.Interfaces;

namespace CencosudApiLib.Services.Services
{
    public class ApiService : GenericService<Api>, IApiService
    {
        private readonly IApiRepository _ApiRepository;
        private readonly IEndpointRepository _endpointRepository;
        private readonly IMapper _mapper;

        public ApiService(IApiRepository ApiRepository, IEndpointRepository endpointRepository, IMapper mapper) : base(ApiRepository)
        {
            _ApiRepository = ApiRepository;
            _endpointRepository = endpointRepository;
            _mapper = mapper;
        }

        public async Task<List<ReadEndpointDto>> GetApiEndpoints(int apiId)
        {
            var endpoints = await _endpointRepository.FindAsync(query =>
                query.Where(e => e.ApiId == apiId)
            );

            var endpointDtos = _mapper.Map<List<ReadEndpointDto>>(endpoints);

            return endpointDtos;
        }
    }
}
