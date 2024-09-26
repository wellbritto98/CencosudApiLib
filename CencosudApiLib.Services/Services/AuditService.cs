using CencosudApiLib.Models;

using CencosudApiLib.Repository.Interfaces;
using CencosudApiLib.Services.Generic;
using CencosudApiLib.Services.Interfaces;

namespace CencosudApiLib.Services.Services
{
    public class AuditService : GenericService<Audit>, IAuditService
    {
        private readonly IAuditRepository _AuditRepository;

        public AuditService(IAuditRepository AuditRepository) : base(AuditRepository)
        {
            _AuditRepository = AuditRepository;
        }
    }
}