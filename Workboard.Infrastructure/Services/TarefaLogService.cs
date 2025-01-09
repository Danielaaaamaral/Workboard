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
  
    public class TarefaLogService : ServiceBase<TarefaLog>, ITarefaLogService
    {
        public readonly IRepositorioTarefaLog _repositorioTarefaLog;
        public TarefaLogService(IRepositorioTarefaLog repositorio) : base(repositorio)
        {
            _repositorioTarefaLog = repositorio;
        }
    }
}
