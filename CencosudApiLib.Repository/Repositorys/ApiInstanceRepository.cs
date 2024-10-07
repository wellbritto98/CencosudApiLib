using CencosudApiLib.Data;
using CencosudApiLib.Models;
using CencosudApiLib.Repository.GenericRepository;
using CencosudApiLib.Repository.Interfaces;

namespace CencosudApiLib.Repository.Repositorys;

public class ApiInstanceRepository : GenericRepository<ApiInstance>, IApiInstanceRepository
{
    public ApiInstanceRepository(DataContext context) : base(context)
    {
    }
}