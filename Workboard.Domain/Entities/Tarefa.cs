using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard.Domain.Entities
{
    public class Tarefa
    {
        public int Id { get; set; }
        public int IdProjeto { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DtaVencimento { get; set; }
        public DateTime DtaCadastro { get; set; }
        public status Status { get; set; }
        public prioridade Prioridade { get; set; }
        public Projeto Projeto { get; set; }
        public ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
        public ICollection<TarefaLog> TarefaLog { get; set; } = new List<TarefaLog>();

        public Tarefa(int id, int idProjeto, string titulo, string descricao, DateTime dtaVencimento, DateTime dtaCadastro, status status, prioridade prioridade)
        {
            Id = id;
            IdProjeto = idProjeto;
            Titulo = titulo;
            Descricao = descricao;
            DtaVencimento = dtaVencimento;
            DtaCadastro = dtaCadastro;
            Status = status;
            Prioridade = prioridade;
        }

        public enum status
        {
            PENDENTE,
            ANDAMENTO,
            CONCLUIDA

        }
        public enum prioridade { 
            BAIXA,MEDIA,ALTA
        }
    }
}
