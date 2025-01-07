using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Workboard.Domain.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Workboard.Infrastructure.Configurations
{
    public class ComentarioConfiguration : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.IdTarefa)
              .IsRequired();

            builder.Property(c => c.IdUsuario)
             .IsRequired();

            builder.Property(c => c.Texto)
             .IsRequired();

            builder.HasOne(c => c.Tarefa)
                   .WithMany(t => t.Comentarios)
                   .HasForeignKey(c => c.IdTarefa)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Usuario)
                   .WithMany(u => u.Comentarios)
                   .HasForeignKey(c => c.IdUsuario)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(c => c.IdTarefa);
            builder.HasIndex(c => c.IdUsuario);
        }
    }
}
