using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Domain.Entities;

namespace Workboard.Domain.Services
{
    public interface ITarefaService:IServiceBase<Tarefa>
    {
        Task<IEnumerable<Tarefa>> TarefaGetByIdProjeto(int id);
         Task<IEnumerable<Tarefa>> Relatorio(DateTime sinceDate);



    }
}
