using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Domain.Entities;
using Workboard.Infrastructure.Configurations;

namespace Workboard.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Projeto> Projeto { get; set; }
        public DbSet<Tarefa> Tarefa { get; set; }
        public DbSet<TarefaLog> TarefaLog { get; set; }
        public DbSet<Comentario> Comentario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProjetoConfiguration());
            modelBuilder.ApplyConfiguration(new TarefaConfiguration());
            modelBuilder.ApplyConfiguration(new TarefaLogConfiguration());
            modelBuilder.ApplyConfiguration(new ComentarioConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
