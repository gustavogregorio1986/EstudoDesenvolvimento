using Desenvolvimento.Dominio.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desenvolvimento.DAL.Mappings
{
    public class CarroMap
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.ToTable("PAGAMENTO");

            builder.HasKey(c => c.IdCarro);

            builder.Property(p => p.IdCarro)
                .HasColumnName("IDCARRO");

            builder.Property(p => p.Marca)
              .HasColumnName("MARCA")
              .HasMaxLength(40)
              .IsRequired();

            builder.Property(p => p.Origem)
              .HasColumnName("ORIGEM")
              .HasMaxLength(60)
              .IsRequired();

            builder.Property(p => p.Destino)
              .HasColumnName("DESTINO")
              .HasMaxLength(60)
              .IsRequired();

            builder.Property(p => p.NomeMotortista)
              .HasColumnName("NOMEMOTERISTA")
              .HasMaxLength(80)
              .IsRequired();

            builder.Property(p => p.Telefone)
              .HasColumnName("TELEFONE")
              .HasMaxLength(10)
              .IsRequired();

            builder.HasOne(c => c.Pessoa)
                .WithOne(p => p.Carro)
        }
    }
}
