using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard.Domain.Entities
{
    public class TarefaLog
    {
        public int Id { get; set; }
        public int IdTarefa { get; set; }
        public int IdUsuario{ get; set; }
        public status Status { get; set; }
        public DateTime DtaAlteracao { get; set; }
        public  Usuario Usuario { get; set; }
        public Tarefa Tarefa { get; set; }

        public TarefaLog(int id, int idTareda, int idUsuario, status status, DateTime dtaAlteracao)
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
