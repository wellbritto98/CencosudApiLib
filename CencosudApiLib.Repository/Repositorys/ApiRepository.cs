using CencosudApiLib.Data;
using CencosudApiLib.Models;
using CencosudApiLib.Repository.GenericRepository;
using CencosudApiLib.Repository.Interfaces;

namespace CencosudApiLib.Repository.Repositorys;

public class ApiRepository : GenericRepository<Api>, IApiRepository
{
    public ApiRepository(DataContext context) : base(context)
    {
    }
}