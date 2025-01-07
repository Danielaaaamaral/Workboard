using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Domain.Entities;

namespace Workboard.Domain.Repositories
{
    public interface IRepositorioWorkboard : IRepositorioBase<Projeto>, IRepositorioBase<Tarefa>, IRepositorioBase<Usuario>, IRepositorioBase<Comentario>, IRepositorioBase<TarefaLog>
    {
    }
}
