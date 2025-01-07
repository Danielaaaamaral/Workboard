using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard.Domain.Entities
{
    public  class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtaCadastro { get; set; }
        public tipoUsuario TipoUsuario { get; set; }
        public ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
        public ICollection<Projeto> Projeto { get; set; } = new List<Projeto>();
        public ICollection<TarefaLog> TarefaLog { get; set; } = new List<TarefaLog>();


        public Usuario(Guid id, string nome, DateTime dtaCadastro, tipoUsuario tipoUsuario)
        {
            Id = id;
            Nome = nome;
            DtaCadastro = dtaCadastro;
            TipoUsuario = tipoUsuario;
        }
    }
    public enum tipoUsuario
    {
        Usuario,
        Gerente
    }
}
