using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Fretes
{
    class EntregaEconomica : Frete
    {
        public EntregaEconomica(decimal peso) : base(peso)
        { }

        public override decimal CalcularFrete()
        {
            return Peso * 5m;
        }
    }
}
