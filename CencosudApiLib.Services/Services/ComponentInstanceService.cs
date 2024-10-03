using CencosudApiLib.Models;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Services.Generic;
using CencosudApiLib.Services.Interfaces;

namespace CencosudApiLib.Services.Services
{
    public class ComponentInstanceService : GenericService<ComponentInstance>, IComponentInstanceService
    {
        private readonly IComponentInstanceRepository _componentInstanceRepository;

        public ComponentInstanceService(IComponentInstanceRepository componentInstanceRepository) : base(componentInstanceRepository)
        {
            _componentInstanceRepository = componentInstanceRepository;
        }
    }
}
