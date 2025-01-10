﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Domain.Entities;

namespace Workboard.Domain.Services
{
    public interface ITarefaService:IServiceBase<Tarefa>
    {
        public IEnumerable<Tarefa> TarefaGetByIdProjeto(int id);
       

    }
}
