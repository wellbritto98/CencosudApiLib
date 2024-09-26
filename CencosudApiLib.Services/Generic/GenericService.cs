using System.Threading.Tasks;
using System.Collections.Generic;
using CencosudApiLib.Repository.GenericRepository;
using CencosudApiLib.Models.Base;
using CencosudApiLib.Services.Interfaces;

using CencosudApiLib.Repository.Interfaces;

namespace CencosudApiLib.Services.Generic
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        private readonly IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(params object[] keyValues)
        {
            return await _repository.GetByIdAsync(keyValues);
        }

        public async Task<IEnumerable<T>> FindAsync(string json)
        {
            return await _repository.FindAsync(json);
        }

        public async Task<T> AddAsync(T entity)
        {
            
            return await _repository.AddAsync(entity);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        public async Task<bool> DeleteAsync(params object[] keyValues)
        {
            var result = await _repository.DeleteAsync(keyValues);
            return result;
        }
    }
}
