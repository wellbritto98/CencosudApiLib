using System.Threading.Tasks;
using System.Collections.Generic;
using CencosudApiLib.Models.Base;

namespace CencosudApiLib.Services.Generic
{
    public interface IGenericService<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(params object[] keyValues);
        Task<IEnumerable<T>> FindAsync(string json);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(params object[] keyValues);
    }
}
