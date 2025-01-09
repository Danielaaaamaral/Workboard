using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Workboard.Domain.Entities.Tarefa;

namespace Workboard.Application.DTO
{
    public class TarefaDTO
    {
        public int Id { get; set; }
        public int IdProjeto { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DtaVencimento { get; set; }
        public DateTime DtaCadastro { get; set; }
        public status Status { get; set; }
        public prioridade Prioridade { get; set; }
        public List<ComentarioDTO> Comentarios { get; set; }
        public List<TarefaLogDTO> logTarefa { get; set; }
    }
}
