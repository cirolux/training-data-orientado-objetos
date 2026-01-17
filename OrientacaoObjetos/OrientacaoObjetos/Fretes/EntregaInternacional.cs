using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Fretes
{
    class EntregaInternacional : Frete
    {
        public string PaisOrigem { get; set; }
        public string PaisDestino { get; set; }

        public EntregaInternacional(decimal peso, string paisOrigem, string paisDestino) : base(peso)
        {
            PaisOrigem = paisOrigem;
            PaisDestino = paisDestino;
        }

        public override decimal CalcularFrete()
        {
            decimal valor = Peso * 12m;

            decimal taxaInt = PaisOrigem != PaisDestino ? 40m : 0m;

            decimal taxaEUA = PaisOrigem == "Estados Unidos" || PaisDestino == "Estados Unidos" ? 20m : 0m;

            return valor + taxaInt + taxaEUA;
        }
    }
}