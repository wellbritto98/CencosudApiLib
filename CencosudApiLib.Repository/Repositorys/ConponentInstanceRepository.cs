using CencosudApiLib.Data;
using CencosudApiLib.Models;
using CencosudApiLib.Repository.GenericRepository;
using CencosudApiLib.Repository.Interfaces;

namespace CencosudApiLib.Repository.Repositorys;

public class ComponentInstanceRepository : GenericRepository<ComponentInstance>, IComponentInstanceRepository
{
    public ComponentInstanceRepository(DataContext context) : base(context)
    {
    }
}