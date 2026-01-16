using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Fretes
{
    public abstract class Frete
    {
        protected int _numeroPedido;
        protected double _peso;

        public abstract double CalcularFrete();
    }
}
