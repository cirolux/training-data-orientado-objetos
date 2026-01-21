using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Orientado_Objetos
{
    public class ContaCorrente : ContaBancaria
    {
        public override int TipoConta => 1;
        public override string Descricao => "Conta Corrente";

        public ContaCorrente(int numero, decimal saldoInicial) : base(numero, saldoInicial)
        { }
    }
}
