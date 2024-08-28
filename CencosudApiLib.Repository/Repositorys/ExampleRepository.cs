using CencosudApiLib.Data;
using CencosudApiLib.Models;
using CencosudApiLib.Repository.GenericRepository;
using CencosudApiLib.Repository.Interfaces;

namespace CencosudApiLib.Repository.Repositorys;

public class ExampleRepository : GenericRepository<ExampleEntity>, IExampleRepository
{
    public ExampleRepository(DataContext context) : base(context)
    {
    }
}