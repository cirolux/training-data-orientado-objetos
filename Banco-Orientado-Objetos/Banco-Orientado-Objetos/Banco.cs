using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Orientado_Objetos
{
    class Banco
    {
        static int NumeroConta = 1;

        public static void CadastrarNovoCliente()
        {
            Console.WriteLine("\nDigite o CPF do cliente (ou 'S' para sair):");
            string inputCPF = Console.ReadLine();

            if (inputCPF.ToUpper() == "S")
                return;

            if (Cliente.Cadastrado(inputCPF))
            {
                Console.WriteLine("Cliente com esse CPF já está cadastrado.");

                return;
            }

            Console.WriteLine($"Digite o nome do cliente (ou 'S' para sair):");
            string inputNome = Console.ReadLine();

            if (inputNome.ToUpper() == "S")
                return;

            Cliente.Cadastrar(inputCPF, inputNome);

            Console.WriteLine($"Cliente '{Cliente.ObterNome(inputCPF)}' cadastrado com sucesso!");
        }

        public static void CadastrarNovaContaBancaria()
        {
            Console.WriteLine("\nDigite o CPF do cliente (ou 'S' para sair):");
            string inputCPF = Console.ReadLine();

            if (inputCPF.ToUpper() == "S")
                return;

            if (!Cliente.Cadastrado(inputCPF))
            {
                Console.WriteLine("Cliente não encontrado.");

                return;
            }

            Console.WriteLine("Digite o número respectivo ao tipo de conta, sendo 1 para 'Poupança' e 2 para 'Corrente' (ou 'S' para sair):");
            string inputTipo = Console.ReadLine();

            if (inputTipo.ToUpper() == "S")
                return;

            if (!int.TryParse(inputTipo, out int tipo))
            {
                Console.WriteLine("Tipo de conta inválido.");

                return;
            }

            if (!ContaBancaria.TipoValido(tipo))
            {
                Console.WriteLine("Tipo de conta inválido.");

                return;
            }

            Console.WriteLine("Digite o saldo inicial (R$):");
            string inputSaldo = Console.ReadLine();

            if (!double.TryParse(inputSaldo, out double saldo))
            {
                Console.WriteLine("Saldo inválido. Conta iniciará com saldo R$ 0,00.");

                saldo = 0;
            }

            ContaBancaria.Cadastrar(NumeroConta, inputCPF, tipo, saldo);

            Console.WriteLine($"Conta {NumeroConta} criada para o cliente {Cliente.ObterNome(inputCPF)} com sucesso! Saldo de {ContaBancaria.ObterSaldo(NumeroConta)}.");

            NumeroConta++;
        }

        public static void ListarClientesEContasBancarias()
        {
            if (Cliente.ObterQuantidadeClientesCadastrados() == 0)
            {
                Console.WriteLine("Não há clientes cadastrados.");

                return;
            }

            Console.WriteLine("\nLista de clientes:");

            List<string> cpfs = Cliente.ObterCpfsClientesCadastrados();
            for (int i = 0; i < cpfs.Count; i++)
            {
                string cpf = cpfs[i];

                Console.WriteLine($"\n{Cliente.ObterNome(cpf)} ({cpf}):");

                List<int> contas = Cliente.ObterContas(cpf);

                if (contas.Count == 0)
                {
                    Console.WriteLine($">>> Nenhuma conta cadastrada.");

                    continue;
                }

                for (int j = 0; j < contas.Count; j++)
                {
                    int numeroConta = contas[j];

                    Console.WriteLine($">>> Conta {ContaBancaria.ObterTipo(numeroConta).ToLower()} número {numeroConta}: {ContaBancaria.ObterSaldo(numeroConta)}.");
                }
            }
        }

        public static void ConsultarSaldoContaBancaria()
        {
            Console.WriteLine("\nDigite o número da conta (ou 'S' para sair):");
            string inputNumeroConta = Console.ReadLine();

            if (inputNumeroConta.ToUpper() == "S")
                return;

            if (!int.TryParse(inputNumeroConta, out int numeroConta))
            {
                Console.WriteLine("Conta não encontrada.");

                return;
            }

            if (!ContaBancaria.Cadastrada(numeroConta))
            {
                Console.WriteLine("Conta não encontrada.");

                return;
            }

            Console.WriteLine($"Saldo da conta número {numeroConta}: {ContaBancaria.ObterSaldo(numeroConta)}.");

            // Um desafio adicional pra instigar caso haja tempo para tal: E se precisar descobrir o cliente dono da conta pra imprimir junto na mensagem?

            /*
             *   string cpfDono = null;
             *
             *   List<string> cpfs = Cliente.ObterCpfsClientesCadastrados();
             *
             *   for (int i = 0; i < cpfs.Count; i++) // Percorre linearmente todos os CPFs e respectivas contas até achar (ou não) - Algoritmo O(n)
             *   {
             *       string cpf = cpfs[i];
             *       
             *       List<int> contas = Cliente.ObterContas(cpf);
             *
             *       for (int j = 0; j < contas.Count; j++)
             *       {
             *           if (contas[j] == numeroConta)
             *           {
             *               cpfDono = cpf;
             *
             *               break;
             *           }
             *       }
             *       
             *       if (cpfDono != null)
             *           break;
             *   }
            */
        }

        public static void RealizarDepositoContaBancaria()
        {
            Console.WriteLine("\nDigite o número da conta (ou 'S' para sair):");
            string inputNumeroConta = Console.ReadLine();

            if (inputNumeroConta.ToUpper() == "S")
                return;

            if (!int.TryParse(inputNumeroConta, out int numeroConta))
            {
                Console.WriteLine("Conta não encontrada.");

                return;
            }

            if (!ContaBancaria.Cadastrada(numeroConta))
            {
                Console.WriteLine("Conta não encontrada.");

                return;
            }

            Console.WriteLine("Digite o valor do depósito (R$):");
            string inputDeposito = Console.ReadLine();

            if (!double.TryParse(inputDeposito, out double deposito))
            {
                Console.WriteLine("Valor inválido.");

                return;
            }

            if (deposito <= 0)
            {
                Console.WriteLine("Valor inválido.");

                return;
            }

            ContaBancaria.Depositar(numeroConta, deposito);

            Console.WriteLine($"Depósito de R$ {deposito:F2} realizado com sucesso na conta {numeroConta}! Saldo de {ContaBancaria.ObterSaldo(numeroConta)}.");
        }

        public static void RealizarSaqueContaBancaria()
        {
            Console.WriteLine("\nDigite o número da conta (ou 'S' para sair):");
            string inputNumeroConta = Console.ReadLine();

            if (inputNumeroConta.ToUpper() == "S")
                return;

            if (!int.TryParse(inputNumeroConta, out int numeroConta))
            {
                Console.WriteLine("Conta não encontrada.");

                return;
            }

            if (!ContaBancaria.Cadastrada(numeroConta))
            {
                Console.WriteLine("Conta não encontrada.");

                return;
            }

            Console.WriteLine("Digite o valor do saque (R$):");
            string inputSaque = Console.ReadLine();

            if (!double.TryParse(inputSaque, out double saque))
            {
                Console.WriteLine("Valor inválido.");

                return;
            }

            if (saque <= 0)
            {
                Console.WriteLine("Valor inválido.");

                return;
            }

            bool saqueBemSucedido = ContaBancaria.Sacar(numeroConta, saque);

            if (!saqueBemSucedido)
            {
                Console.WriteLine($"Saque de R$ {saque:F2} NÃO foi realizado devido a saldo insuficiente na conta {numeroConta}! Saldo de {ContaBancaria.ObterSaldo(numeroConta)}.");

                return;
            }

            Console.WriteLine($"Saque de R$ {saque:F2} realizado com sucesso na conta {numeroConta}! Saldo de {ContaBancaria.ObterSaldo(numeroConta)}.");
        }

        public static void RealizarTransferenciaContasBancarias()
        {
            Console.WriteLine("\nDigite o número da conta originária (ou 'S' para sair):");
            string inputNumeroContaOriginaria = Console.ReadLine();

            if (inputNumeroContaOriginaria.ToUpper() == "S")
                return;

            if (!int.TryParse(inputNumeroContaOriginaria, out int numeroContaOriginaria))
            {
                Console.WriteLine("Conta não encontrada.");

                return;
            }

            if (!ContaBancaria.Cadastrada(numeroContaOriginaria))
            {
                Console.WriteLine("Conta não encontrada.");

                return;
            }

            Console.WriteLine("\nDigite o número da conta destinatária (ou 'S' para sair):");
            string inputNumeroContaDestinataria = Console.ReadLine();

            if (inputNumeroContaDestinataria.ToUpper() == "S")
                return;

            if (!int.TryParse(inputNumeroContaDestinataria, out int numeroContaDestinataria))
            {
                Console.WriteLine("Conta não encontrada.");

                return;
            }

            if (!ContaBancaria.Cadastrada(numeroContaDestinataria))
            {
                Console.WriteLine("Conta não encontrada.");

                return;
            }

            Console.WriteLine("Digite o valor da transferência (R$):");
            string inputTransferencia = Console.ReadLine();

            if (!double.TryParse(inputTransferencia, out double transferencia))
            {
                Console.WriteLine("Valor inválido.");

                return;
            }

            if (transferencia <= 0)
            {
                Console.WriteLine("Valor inválido.");

                return;
            }

            bool saqueBemSucedido = ContaBancaria.Sacar(numeroContaOriginaria, transferencia);

            if (!saqueBemSucedido)
            {
                Console.WriteLine($"Transferência de R$ {transferencia:F2} NÃO foi realizada devido a saldo insuficiente na conta originária {numeroContaOriginaria}! Saldo de {ContaBancaria.ObterSaldo(numeroContaOriginaria)}.");

                return;
            }

            ContaBancaria.Depositar(numeroContaDestinataria, transferencia);

            Console.WriteLine($"Transferência de R$ {transferencia:F2} realizada com sucesso da conta originária {numeroContaOriginaria} para a conta destinatária {numeroContaDestinataria}!");
        }
    }
}
