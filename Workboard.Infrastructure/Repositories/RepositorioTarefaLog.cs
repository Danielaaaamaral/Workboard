using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Domain.Entities;
using Workboard.Domain.Repositories;
using Workboard.Infrastructure.Data;

namespace Workboard.Infrastructure.Repositories
{
   
    public class RepositorioTarefaLog : RepositorioBase<TarefaLog>, IRepositorioTarefaLog
    {
        private readonly SqlContext _context;

        public RepositorioTarefaLog(SqlContext context)
        {
            _context = context;
        }
    }
}
