using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard.Domain.Entities
{
    public class Projeto
    {
        public Guid Id { get; set; }
        public Guid IdUsuario { get; set; }
        public DateTime DtaCadastro { get; set; }
        public string Titulo { get; set; }
        public Usuario Usuario  { get; set; }
        public ICollection<Tarefa> Tarefa { get; } = new List<Tarefa>();

        public Projeto(Guid id, Guid idUsuario, DateTime dtaCadastro, string titulo, Usuario usuario)
        {
            Id = id;
            IdUsuario = idUsuario;
            DtaCadastro = dtaCadastro;
            Titulo = titulo;
            Usuario = usuario;
        }
    }
}
