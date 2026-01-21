using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Orientado_Objetos
{
    public abstract class ContaBancaria
    {
        public abstract int TipoConta { get; }
        public abstract string Descricao { get; }
        private decimal _saldo;
        public string Saldo => $"R${_saldo:F2}";

        public int Numero {  get; }

        protected ContaBancaria(int numero, decimal saldoInicial)
        {
            Numero = numero;
            _saldo = saldoInicial;
        }

        public bool Sacar(decimal saldo, decimal valor)
        {
            if (valor < _saldo)
            {
                Console.WriteLine("Saldo Insuficiente");
            }
            _saldo -= valor;

            return true;
        }

        public void Depositar(decimal _saldo, decimal valor)
        {
            _saldo += valor;
        }
    }
}
