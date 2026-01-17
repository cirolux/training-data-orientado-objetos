using OrientacaoObjetos.Fretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    class EntregaExpressa : Frete
    {
        public string RegiaoDeOrigem { get; }
        public string RegiaoDeDestino { get; }

        public EntregaExpressa(decimal peso, string regiaoOrigem, string regiaoDestino) : base(peso)
        {
            RegiaoDeOrigem = regiaoOrigem;
            RegiaoDeDestino = regiaoDestino;
        }

        public override decimal CalcularFrete()
        {
            decimal valor = Peso * 7m;

            decimal taxa = RegiaoDeOrigem != RegiaoDeDestino ? 10m : 0m;

            return valor + taxa;
        }
    }
}
