using Microsoft.EntityFrameworkCore;
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
    public class TarefaService : ServiceBase<Tarefa>, ITarefaService
    {
        public readonly IRepositorioTarefa _repositorioTarefa;
        public TarefaService(IRepositorioTarefa repositorio) : base(repositorio)
        {
            _repositorioTarefa = repositorio;
        }

        public async Task<IEnumerable<Tarefa>> Relatorio(DateTime sinceDate)
        {
             return await _repositorioTarefa.Relatorio(sinceDate);
        }

        public async Task<IEnumerable<Tarefa>> TarefaGetByIdProjeto(int id)
        {
           return await _repositorioTarefa.TarefaGetByIdProjeto(id);
        }

    }
}
