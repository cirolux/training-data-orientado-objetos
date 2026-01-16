using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OrientacaoObjetos.Notificador;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaJohn = new ContaBancaria("148.578.595-25", "John Doe");

            Console.WriteLine($"Conta {contaJohn.Numero} em nome de {contaJohn.Nome}: Saldo de {contaJohn.Saldo}.");

            contaJohn.DepositarValor(100);

            Console.WriteLine($"Saque de R$ 30,00 {(contaJohn.SacarValor(30) ? "bem sucedido!" : "Não foi concluído.")}"); // Bem sucedido

            Console.WriteLine($"Saque de R$ 100,00 {(contaJohn.SacarValor(100) ? "bem sucedido!" : "não foi concluído.")}"); // Não concluído

            Console.WriteLine($"Conta {contaJohn.Numero} em nome de {contaJohn.Nome}: Saldo de {contaJohn.Saldo}.");
        }
    }
}
