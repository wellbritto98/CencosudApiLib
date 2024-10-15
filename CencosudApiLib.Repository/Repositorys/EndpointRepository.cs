using CencosudApiLib.Data;
using CencosudApiLib.Models;
using CencosudApiLib.Repository.GenericRepository;
using CencosudApiLib.Repository.Interfaces;

namespace CencosudApiLib.Repository.Repositorys;

public class EndpointRepository : GenericRepository<Endpoint>, IEndpointRepository
{
    public EndpointRepository(DataContext context) : base(context)
    {
    }
}