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
    public class PessoaMap
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("PESSOA");

            builder.HasKey(p => p.IdPessoa);

            builder.Property(p => p.IdPessoa)
                .HasColumnName("IDPESSOA");

            builder.Property(p => p.NomePessoa)
                .HasColumnName("NOMEPESSOA")
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(p => p.EmailPessoa)
                .HasColumnName("EMAILPESOA")
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(p => p.Sexo)
                .HasColumnName("SEXO")
                .HasMaxLength(1)
                .IsRequired();
        }
    }
}
