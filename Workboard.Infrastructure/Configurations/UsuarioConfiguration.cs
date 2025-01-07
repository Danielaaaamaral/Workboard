using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Domain.Entities;

namespace Workboard.Infrastructure.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(c=>c.TipoUsuario).IsRequired();
            builder.Property(c => c.DtaCadastro).IsRequired();
            builder.Property(c => c.Nome).IsRequired();

            builder.HasMany(u => u.Projeto)
              .WithOne(p => p.Usuario)
              .HasForeignKey(p => p.IdUsuario)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(u => u.Comentarios)
                   .WithOne(c => c.Usuario)
                   .HasForeignKey(c => c.IdUsuario)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(u => u.TarefaLog)
                   .WithOne(h => h.Usuario)
                   .HasForeignKey(h => h.IdUsuario)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
