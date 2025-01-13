using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Domain.Repositories;
using Workboard.Domain.Services;

namespace Workboard.Infrastructure.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositorioBase<TEntity> _repository;

        protected ServiceBase(IRepositorioBase<TEntity> repositorio)
        {
            _repository = repositorio;
        }

        public async Task Add(TEntity obj)
        {
           await _repository.Add(obj);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Remove(TEntity obj)
        {
           await _repository.Remove(obj);
        }

        public async Task Update(TEntity obj)
        {
            await _repository.Update(obj);
        }
    }
}
