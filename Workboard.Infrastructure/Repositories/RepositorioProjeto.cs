using Microsoft.EntityFrameworkCore;
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
   
    public class RepositorioProjeto : RepositorioBase<Projeto>, IRepositorioProjeto
    {
        private readonly SqlContext _context;

        public RepositorioProjeto(SqlContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Projeto>> GetByUserIdAsync(int userId)
        {
            return await _context.Projeto
             .Where(p => p.IdUsuario == userId)
             .Include(p => p.Tarefa)
             .ToListAsync();
        }
    }
}
