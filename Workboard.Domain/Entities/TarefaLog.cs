using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard.Domain.Entities
{
    public class TarefaLog
    {
        public Guid Id { get; set; }
        public Guid IdTarefa { get; set; }
        public Guid IdUsuario{ get; set; }
        public status Status { get; set; }
        public DateTime DtaAlteracao { get; set; }
        public  Usuario Usuario { get; set; }
        public Tarefa Tarefa { get; set; }

        public TarefaLog(Guid id, Guid idTareda, Guid idUsuario, status status, DateTime dtaAlteracao)
        {
            Id = id;
            IdTarefa = idTareda;
            IdUsuario = idUsuario;
            Status = status;
            DtaAlteracao = dtaAlteracao;
        }

        public enum status
        {
            PENDENTE,
            ANDAMENTO,
            CONCLUIDA

        }
    }
}
