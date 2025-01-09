using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Domain.Entities;
using Workboard.Domain.Repositories;
using Workboard.Domain.Services;

namespace Workboard.Infrastructure.Services
{
    public class ProjetoService : ServiceBase<Projeto>, IProjetoService
    {
        public readonly IRepositorioProjeto _repositorioProjeto;
        public ProjetoService(IRepositorioProjeto repositorio) : base(repositorio)
        {
            _repositorioProjeto = repositorio;
        }

        public IEnumerable<Projeto> GetByUserIdAsync(int userId)
        {
            return  _repositorioProjeto.GetByUserIdAsync(userId);
        }
    }
}
