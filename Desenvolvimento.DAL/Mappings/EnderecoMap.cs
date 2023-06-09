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
    public class EnderecoMap
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("ENDERECO");

            builder.HasKey(e => e.IdEndereco);

            builder.Property(e => e.IdEndereco)
                .HasColumnName("IDENDERECO");

            builder.Property(e => e.Logradouro)
               .HasColumnName("LOGRADOURO")
               .HasMaxLength(80)
               .IsRequired();

            builder.Property(e => e.Complemento)
               .HasColumnName("COMPLEMENTO")
               .HasMaxLength(95)
               .IsRequired();

            builder.Property(e => e.Bairro)
               .HasColumnName("BAIRRO")
               .HasMaxLength(40)
               .IsRequired();

            builder.Property(e => e.Cidade)
               .HasColumnName("CIDADE")
               .HasMaxLength(40)
               .IsRequired();

            builder.HasOne(e => e.Pessoa)
               .WithOne(p => p.Endereco);
        }
    }
}
