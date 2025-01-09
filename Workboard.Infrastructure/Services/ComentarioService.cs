using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Domain.Entities;
using Workboard.Domain.Repositories;
using Workboard.Domain.Services;

namespace Workboard.Infrastructure.Services
{
    public class ComentarioService : ServiceBase<Comentario>, IComentarioService
    {
        public readonly IRepositorioComentario _repositorioComentario;
        public ComentarioService(IRepositorioComentario repositorio) : base(repositorio)
        {
            _repositorioComentario = repositorio;
        }
    }
}
