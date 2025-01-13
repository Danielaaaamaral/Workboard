using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard.Domain.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task Add(TEntity obj);

        Task<TEntity> GetById(int id);

        Task<IEnumerable<TEntity>> GetAll();

        Task Update(TEntity obj);

        Task Remove(TEntity obj);
    }
}
