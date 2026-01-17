using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Fretes
{
    public abstract class Frete
    {
        private static int contadorPedidos = 20000;

        public int NumPedido { get;}
        public decimal Peso { get; }

        public Frete(decimal peso)
        {
            NumPedido = contadorPedidos++;
            Peso = peso;
        }

        public abstract decimal CalcularFrete();
    }
}
