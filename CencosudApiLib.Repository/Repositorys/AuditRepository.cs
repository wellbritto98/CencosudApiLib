using CencosudApiLib.Data;
using CencosudApiLib.Models;
using CencosudApiLib.Repository.GenericRepository;
using CencosudApiLib.Repository.Interfaces;

namespace CencosudApiLib.Repository.Repositorys;

public class AuditRepository : GenericRepository<Audit>, IAuditRepository
{
    public AuditRepository(DataContext context) : base(context)
    {
    }
}