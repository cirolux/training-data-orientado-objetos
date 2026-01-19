using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Orientado_Objetos
{
    class Cliente
    {
        static Dictionary<string, string> Nomes = new Dictionary<string, string>(); // Chave: CPF, Valor: Nome
        static Dictionary<string, List<int>> Contas = new Dictionary<string, List<int>>(); // Chave: CPF, Valor: Lista de números de contas

        public static void Cadastrar(string cpf, string nome)
        {
            Nomes.Add(cpf, nome);

            Contas.Add(cpf, new List<int>());
        }

        public static bool Cadastrado(string cpf)
        {
            return Nomes.ContainsKey(cpf);
        }

        public static void CadastrarNovaContaBancaria(string cpf, int numeroConta)
        {
            Contas[cpf].Add(numeroConta);
        }

        public static string ObterNome(string cpf)
        {
            return Nomes[cpf];
        }

        public static int ObterQuantidadeClientesCadastrados()
        {
            return Nomes.Count;
        }

        public static List<string> ObterCpfsClientesCadastrados()
        {
            return new List<string>(Nomes.Keys);
        }

        public static List<int> ObterContas(string cpf)
        {
            return Contas[cpf];
        }
    }
}
