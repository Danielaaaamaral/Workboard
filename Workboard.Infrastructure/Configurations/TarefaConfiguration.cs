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
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(c=>c.IdProjeto)
                .IsRequired();
            builder.Property(c => c.Titulo)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(c => c.Descricao)
                .IsRequired();
            builder.Property(c=>c.DtaCadastro)
                .IsRequired();
            builder.Property(c=>c.Status)
                .IsRequired()
                .HasConversion<string>();
            builder.Property(c=>c.Prioridade)
                .IsRequired()
                .HasConversion<string>();
            builder.Property(c=>c.DtaVencimento)
                .IsRequired();

            builder.HasOne(t => t.Projeto)
              .WithMany(p => p.Tarefa)
              .HasForeignKey(t => t.IdProjeto)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(t => t.Comentarios)
                   .WithOne(c => c.Tarefa)
                   .HasForeignKey(c => c.IdTarefa)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
