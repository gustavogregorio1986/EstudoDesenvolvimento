using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desenvolvimento.Dominio.Dominio
{
    public class Carro
    {
        private Guid _idCarro;

        private string? _marca;

        private string? _origem;

        private string? _destino;

        private string? _nomreMotorista;

        private string? _telefone;
        private Pessoa? _pessoa;

        public Guid IdCarro { get => _idCarro; set => _idCarro = value; }

        public string? Marca { get => _marca; set => _marca = value; }

        public string? Origem { get => _origem; set => _origem = value; }

        public string? Destino { get => _destino; set => _destino = value; }

        public string? NomeMotortista { get => _nomreMotorista; set => _nomreMotorista = value; }

        public string? Telefone { get => _telefone; set => _telefone = value; }

        public Pessoa? Pessoa { get => _pessoa; set => _pessoa = value; }
    }
}
