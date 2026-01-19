using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Orientado_Objetos
{
    class ContaBancaria
    {
        const string TIPO_CONTA_POUPANCA = "Poupança", TIPO_CONTA_CORRENTE = "Corrente";

        static Dictionary<int, int> Tipos = new Dictionary<int, int>(); // Chave: Número da conta, Valor: ID do Tipo (1 - Poupança, 2 - Corrente)
        static Dictionary<int, double> Saldos = new Dictionary<int, double>(); // Chave: Número da conta, Valor: Saldo

        public static void Cadastrar(int numeroConta, string cpf, int tipo, double saldo)
        {
            Tipos.Add(numeroConta, tipo);

            Saldos.Add(numeroConta, saldo);

            Cliente.CadastrarNovaContaBancaria(cpf, numeroConta);
        }

        public static string ObterTipo(int numeroConta)
        {
            int idTipoConta = Tipos[numeroConta];

            return idTipoConta == 1 ? TIPO_CONTA_POUPANCA : TIPO_CONTA_CORRENTE;
        }

        public static string ObterSaldo(int numeroConta)
        {
            return $"R$ {Saldos[numeroConta]:F2}";
        }

        public static bool TipoValido(int tipo)
        {
            return tipo > 0 && tipo < 3;
        }

        public static bool Cadastrada(int numeroConta)
        {
            return Saldos.ContainsKey(numeroConta);
        }

        public static void Depositar(int numeroConta, double valor)
        {
            Saldos[numeroConta] += valor;
        }

        public static bool Sacar(int numeroConta, double valor)
        {
            if (Saldos[numeroConta] < valor)
                return false;

            Saldos[numeroConta] -= valor;

            return true;
        }
    }
}
