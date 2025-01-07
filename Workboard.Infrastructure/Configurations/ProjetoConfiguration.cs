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
    public class ProjetoConfiguration : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(c=>c.IdUsuario).IsRequired();
            builder.Property(c=>c.DtaCadastro).IsRequired();
            builder.Property(c=>c.Titulo).IsRequired().HasMaxLength(150);

            builder.HasOne(p => p.Usuario)
            .WithMany(u => u.Projeto)
            .HasForeignKey(p => p.IdUsuario)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.Tarefa)
                   .WithOne(t => t.Projeto)
                   .HasForeignKey(t => t.IdProjeto)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
