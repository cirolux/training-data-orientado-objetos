using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    public class Retangulo : FormasGeometricas
    {
        public double Base;
        public double Altura;

        public Retangulo(double basilar, double altura)
        {
            Base = basilar;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return (Base *2) + (Altura * 2);
        }
    }
}
