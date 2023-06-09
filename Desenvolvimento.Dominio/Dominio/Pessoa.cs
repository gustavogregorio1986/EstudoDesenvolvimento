using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desenvolvimento.Dominio.Dominio
{
    public class Pessoa
    {
        private Guid _idPessoa;
        private string? _nomePessoa;
        private string? _emailPessoa;
        private string? _sexo;
        private string? _cpf;
        private Carro? _carro;
        private Endereco? _endereco;
        private Pagamento? _pagamento;

        public Guid IdPessoa { get => _idPessoa; set => _idPessoa = value; }
        public string? NomePessoa { get => _nomePessoa; set => _nomePessoa = value; }
        public string? EmailPessoa { get => _emailPessoa; set => _emailPessoa = value; }
        public string? Sexo { get => _sexo; set => _sexo = value; }

        public string? Cpf { get => _cpf; set => _cpf = value; }

        public virtual Carro? Carro { get => _carro; set => _carro = value; }

        public virtual Endereco? Endereco { get => _endereco; set => _endereco = value; }

        public virtual Pagamento? Pagamento { get => _pagamento; set => _pagamento = value; }

    }
}
