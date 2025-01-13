using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard.Domain.Entities
{
    public class Projeto
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtaCadastro { get; set; }
        public string Titulo { get; set; }
        public Usuario Usuario  { get; set; }
        public ICollection<Tarefa> Tarefa { get; } = new List<Tarefa>();

        public Projeto(int id, int idUsuario, DateTime dtaCadastro, string titulo)
        {
            Id = id;
            IdUsuario = idUsuario;
            DtaCadastro = dtaCadastro;
            Titulo = titulo;
        }
    }
}
