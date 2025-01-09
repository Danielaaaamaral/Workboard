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
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        public readonly IRepositorioUsuario _repositorioUsuario;
        public UsuarioService(IRepositorioUsuario repositorio) : base(repositorio)
        {
            _repositorioUsuario = repositorio;
        }
    }
}
