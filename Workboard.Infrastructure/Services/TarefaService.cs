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

        public IEnumerable<Tarefa> TarefaGetByIdProjeto(int id)
        {
           return _repositorioTarefa.TarefaGetByIdProjeto(id);
        }
    }
}
