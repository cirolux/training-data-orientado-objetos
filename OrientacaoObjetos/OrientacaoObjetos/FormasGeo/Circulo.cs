using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    public class Circulo : FormasGeometricas
    {
        public double Raio;

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * (Raio * Raio);
        }

        public override double CalcularPerimetro()
        {
            return Math.PI * Raio * 2;
        }
    }
}
