using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desenvolvimento.Dominio.Dominio
{
    public class Pagamento
    {
        private Guid _idPagamento;
        private decimal? _preco;
        private int? _qtde;
        private Pessoa? _pessoa;

        public Guid IdPagamento { get => _idPagamento; set => _idPagamento = value; }

        public decimal? Preco { get => _preco; set => _preco = value; }

        public int? Qtde { get => _qtde; set => _qtde = value; }

        public Pessoa? Pessoa { get => _pessoa; set => _pessoa = value; }


    }
}
