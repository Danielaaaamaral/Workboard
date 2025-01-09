using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Domain.Entities;
using Workboard.Domain.Repositories;
using Workboard.Infrastructure.Data;

namespace Workboard.Infrastructure.Repositories
{
 
    public class RepositorioComentario : RepositorioBase<Comentario>, IRepositorioComentario
    {
        private readonly SqlContext _context;

        public RepositorioComentario(SqlContext context)
        {
            _context = context;
        }
    }
}
