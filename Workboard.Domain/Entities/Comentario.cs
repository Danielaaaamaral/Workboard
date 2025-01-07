using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard.Domain.Entities
{
    public class Comentario
    {
        public Guid Id { get; set; }
        public Guid IdTarefa { get; set; }
        public Guid IdUsuario { get; set; }
        public string Texto { get; set; }
        public Tarefa Tarefa { get; set; }
        public Usuario Usuario { get; set; }
        public Comentario() { }

        public Comentario(Guid id, Guid idTarefa, string texto)
        {
            Id = id;
            IdTarefa = idTarefa;
            Texto = texto;
        }
    }
}
