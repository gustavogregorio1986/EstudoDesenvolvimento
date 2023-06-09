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
    public class PagamentoMap
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.ToTable("PAGAMENTO");

            builder.HasKey(p => p.IdPagamento);

            builder.Property(p => p.IdPagamento)
                .HasColumnName("IDPAGAMENTO");

            builder.Property(p => p.Preco   )
                .HasColumnName("PRECO")
                .HasMaxLength(4)
                .IsRequired();

            builder.Property(p => p.Qtde)
                .HasColumnName("QTDE")
                .HasMaxLength(4)
                .IsRequired();
        }
    }
}
