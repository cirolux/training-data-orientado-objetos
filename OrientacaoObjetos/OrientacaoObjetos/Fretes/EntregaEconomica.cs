using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Fretes
{
    class EntregaEconomica : Frete
    {
        public double Peso;
        public double Preco;

        public EntregaEconomica(double peso)
        {
            Peso = peso;    
        }

        public override double CalcularFrete()
        {
            return Peso * 5.00;
        }
    }
}
