using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Orientado_Objetos
{
    public class ContaPoupanca : ContaBancaria
    {
        public override int TipoConta => 2;
        public override string Descricao => "Conta Poupança";

        public ContaPoupanca(int numero, decimal saldoInicial) : base (numero, saldoInicial)
        { }
    }
}
