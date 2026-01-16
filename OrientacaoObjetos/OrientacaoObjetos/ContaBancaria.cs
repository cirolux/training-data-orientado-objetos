using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    public class ContaBancaria
    {
        private static int contadorContas = 10000;

        public int Numero { get; }
        public string Cpf { get;}
        public string Nome { get; }
        public double Saldo { get ; private set; }

        public ContaBancaria(string cpf, string nome)
        {
            Numero = contadorContas++;
            Cpf = cpf;
            Nome = nome;
            Saldo = 0;
        }

        public void DepositarValor(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            } else
            {
                Console.WriteLine("O valor precisa ser maior do que zero");
            }

            return;
        }

        public bool SacarValor(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque inválido.");

                return false;
            }

            if (Saldo < valor)
            {
                Console.WriteLine("Valor de saque inválido.");

                return false;
            }

            Saldo -= valor;

            return true;
        }
    }
}
