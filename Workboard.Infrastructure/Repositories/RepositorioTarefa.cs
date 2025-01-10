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
    public class RepositorioTarefa : RepositorioBase<Tarefa>,IRepositorioTarefa
    {
        private readonly SqlContext _context;

        public RepositorioTarefa(SqlContext context)
        {
            _context = context;
        }

        public IEnumerable<Tarefa> TarefaGetByIdProjeto(int id)
        {
           return _context.Tarefa
                .Where(x=>x.IdProjeto == id)
                .Include(x=>x.Comentarios)
                .ThenInclude(x=>x.Usuario)
                .Include(x=>x.TarefaLog)
                .ThenInclude(x=>x.Usuario).ToList();

        }
    }
}
