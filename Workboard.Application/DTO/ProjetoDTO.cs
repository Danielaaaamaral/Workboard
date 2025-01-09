using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Domain.Entities;

namespace Workboard.Application.DTO
{
    public class ProjetoDTO
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtaCadastro { get; set; }
        public string Titulo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
