using CencosudApiLib.Models;
using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Services.Generic;
using CencosudApiLib.Services.Interfaces;

namespace CencosudApiLib.Services.Services
{
    public class ComponentService : GenericService<Component>, IComponentService
    {
        private readonly IComponentRepository _componentRepository;

        public ComponentService(IComponentRepository componentRepository) : base(componentRepository)
        {
            _componentRepository = componentRepository;
        }
    }
}
