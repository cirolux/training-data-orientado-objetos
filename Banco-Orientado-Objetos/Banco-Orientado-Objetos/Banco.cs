using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Orientado_Objetos
{
    class Banco
    {
        private int _numeroConta = 1;

        Dictionary<int, string> _contaCpf;
        List<Cliente> _listaClientes;

        public Banco()
        {
            _listaClientes = new List<Cliente>();
            _contaCpf = new Dictionary<int, string>();
        }

        public List<Cliente> ObtemListaCliente()
        {
            return _listaClientes;
        }

        public Cliente ObtemCliente(string cpf)
        {
            for (int i = 0; i < _listaClientes.Count; i++)
            {
                if (_listaClientes[i].CPF == cpf)
                {
                    return _listaClientes[i];
                }
            }
            return null;
        }

        public bool ClientesNoCadastro(string cpf)
        {
            return _contaCpf.ContainsValue(cpf);
        }

        public void CadastrarCliente()
        {
            Console.WriteLine("Digite o nome do cliente para cadastrá-lo");
            string eNome = Console.ReadLine();

            Console.WriteLine("Agora o CPF");
            string eCpf = Console.ReadLine();

            if (this.ClientesNoCadastro(eCpf))
            {
                Console.WriteLine("Cliente já cadastrado");

                return;
            }

            Cliente novoC = new Cliente(eNome, eCpf);

            _listaClientes.Add(novoC);

            Console.WriteLine($"Cliente {novoC} cadastrado com sucesso");
        }

        public ContaBancaria ObterConta(int numero)
        {
            Cliente cliente = ObtemCliente(_contaCpf[_numeroConta]);
            return cliente.ObtemConta(numero);
        }

        public bool ContaCadastrada(int numero)
        {
            return _contaCpf.ContainsKey(_numeroConta);
        }

        public void CadastrarConta()
        {
            Console.WriteLine("Digite o CPF do cliente para criar uma conta");
            string eCpf = Console.ReadLine();

            Cliente cliente = ObtemCliente(eCpf);

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado");
            }

            Console.WriteLine("Digite o tipo da conta 1 corrente 2 poupança: ");
            int tipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o saldo inicial: ");
            decimal saldoIni = decimal.Parse(Console.ReadLine());

            if (tipoConta == 1)
            {
                ContaCorrente contaCorrente = new ContaCorrente(_numeroConta, saldoIni);
            }
            else if (tipoConta == 2)
            {
                ContaPoupanca contaPoupanca = new ContaPoupanca(_numeroConta, saldoIni);
            }

            _contaCpf.Add(_numeroConta, eCpf);
        }
    }
}
