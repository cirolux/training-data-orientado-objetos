using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Orientado_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o sistema bancário...");

            // Menu de operações
            while (true)
            {
                Console.WriteLine("\n1 - Cadastrar novo cliente");
                Console.WriteLine("2 - Cadastrar conta para cliente");
                Console.WriteLine("3 - Listar clientes");
                Console.WriteLine("4 - Consultar saldo de conta");
                Console.WriteLine("5 - Efetuar depósito");
                Console.WriteLine("6 - Efetuar saque");
                Console.WriteLine("7 - Efetuar transferência");
                Console.WriteLine("S - Sair");
                Console.Write("Selecione a ação: ");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao == "S")
                    break;

                switch (opcao)
                {
                    case "1":
                        Banco.CadastrarNovoCliente();

                        break;
                    case "2":
                        Banco.CadastrarNovaContaBancaria();

                        break;
                    case "3":
                        Banco.ListarClientesEContasBancarias();

                        break;
                    case "4":
                        Banco.ConsultarSaldoContaBancaria();

                        break;
                    case "5":
                        Banco.RealizarDepositoContaBancaria();

                        break;
                    case "6":
                        Banco.RealizarSaqueContaBancaria();

                        break;
                    case "7":
                        Banco.RealizarTransferenciaContasBancarias();

                        break;
                    default:
                        Console.WriteLine("\nOpção inválida.");

                        break;
                }
            }

            Console.WriteLine("\nEncerrando o sistema bancário...");
        }
    }
}
