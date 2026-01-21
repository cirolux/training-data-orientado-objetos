using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Orientado_Objetos
{
    class Cliente
    {
        public string CPF { get; }
        public string Nome { get; }

        List<ContaBancaria> _contasBancarias;

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;

            _contasBancarias = new List<ContaBancaria>();
        }

        public List<ContaBancaria> ObtemConta(int numero)
        {
            return _contasBancarias;
        }

        public int NumeroConta(int numero)
        {
            return numero++;
        }
    }
}
