using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard.Domain.Entities
{
    public class Comentario
    {
        public int Id { get; set; }
        public int IdTarefa { get; set; }
        public int IdUsuario { get; set; }
        public string Texto { get; set; }
        public Tarefa Tarefa { get; set; }
        public Usuario Usuario { get; set; }
        public Comentario() { }

        public Comentario(int id, int idTarefa, string texto)
        {
            Id = id;
            IdTarefa = idTarefa;
            Texto = texto;
        }
    }
}
