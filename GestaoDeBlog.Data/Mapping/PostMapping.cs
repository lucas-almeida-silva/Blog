using GestaoDeBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoDeBlog.Data.Mapping
{
    public class PostMapping : IEntityTypeConfiguration<Post>
    {

        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.PostId);

            builder.Property(x => x.PostId)
                .HasColumnType("int");

            builder.Property(x => x.Titulo)
               .IsRequired()
               .HasColumnType("varchar(50)");

            builder.Property(x => x.Autor)
               .IsRequired()
               .HasColumnType("varchar(30)");

            builder.Property(x => x.Url)
              .IsRequired()
              .HasColumnType("datetime");

            builder.Property(x => x.Url)
              .IsRequired()
              .HasColumnType("varchar(80)");

            builder.Property(x => x.Conteudo)
              .IsRequired()
              .HasColumnType("text");

            builder.Property(x => x.Ativo)
               .IsRequired()
               .HasColumnType("bit");

            builder.Property(x => x.Excluido)
               .IsRequired()
               .HasColumnType("bit");
        }
    }
}
