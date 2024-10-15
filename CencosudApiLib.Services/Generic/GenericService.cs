﻿using System.Threading.Tasks;
using System.Collections.Generic;
using CencosudApiLib.Repository.GenericRepository;
using CencosudApiLib.Models.Base;

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

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
        public async Task<T> GetByIdAsync(int key1, int key2)
        {
            return await _repository.GetByIdAsync(key1, key2);
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

        public async Task DeleteAsync(params object[] keyValues)
        {
            await _repository.DeleteAsync(keyValues);
        }
    }
}
