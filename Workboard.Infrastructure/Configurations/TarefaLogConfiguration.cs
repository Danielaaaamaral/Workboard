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
    public class TarefaLogConfiguration : IEntityTypeConfiguration<TarefaLog>
    {
        public void Configure(EntityTypeBuilder<TarefaLog> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(c=>c.IdUsuario).IsRequired();
            builder.Property(c => c.IdTarefa).IsRequired();
            builder.Property(c=>c.Status).IsRequired();
            builder.Property(c=>c.DtaAlteracao).IsRequired();

            builder.HasOne(h => h.Tarefa)
              .WithMany(t => t.TarefaLog)
              .HasForeignKey(h => h.IdTarefa)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(h => h.Usuario)
          .WithMany(t => t.TarefaLog)
          .HasForeignKey(h => h.IdTarefa)
          .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
