using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Domain.Enum;

namespace Workboard.Domain.Entities
{
    public class TarefaLog
    {
        public int Id { get; set; }
        public int IdTarefa { get; set; }
        public int IdUsuario{ get; set; }
        public Status Status { get; set; }
        public DateTime DtaAlteracao { get; set; }
        public  Usuario Usuario { get; set; }
        public Tarefa Tarefa { get; set; }

        public TarefaLog(int id, int idTareda, int idUsuario, Status status, DateTime dtaAlteracao)
        {
            Id = id;
            IdTarefa = idTareda;
            IdUsuario = idUsuario;
            Status = status;
            DtaAlteracao = dtaAlteracao;
        }

    }
}
