using Desenvolvimento.DAL.Mappings;
using Desenvolvimento.Dominio.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desenvolvimento.DAL.Contexts
{
    public class DataContexts : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=movelestudo_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new PessoaMap());
            //modelBuilder.ApplyConfiguration(new PagamentoMap());
            //modelBuilder.ApplyConfiguration(new CarroMap());
            //modelBuilder.ApplyConfiguration(new EnderecoMap());
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }

        public DbSet<Carro> Carros { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }
    }
}
