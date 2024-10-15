using CencosudApiLib.Data;
using CencosudApiLib.Models;
using CencosudApiLib.Repository.GenericRepository;
using CencosudApiLib.Repository.Interfaces;

namespace CencosudApiLib.Repository.Repositorys;

public class ComponentRepository : GenericRepository<Component>, IComponentRepository
{
    public ComponentRepository(DataContext context) : base(context)
    {
    }
}