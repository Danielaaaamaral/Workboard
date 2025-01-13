using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Domain.Entities;

namespace Workboard.Domain.Services
{
    public interface IProjetoService: IServiceBase<Projeto>
    {
       Task<IEnumerable<Projeto>> GetByUserIdAsync(int userId);
    }
}
