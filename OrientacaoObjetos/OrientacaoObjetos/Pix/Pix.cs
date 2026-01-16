using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    public abstract class Pix
    {
        protected string _idOriginador;
        protected string _idDestinatario;
        protected double _valor;

        public abstract string Executar();

        public void ImprimirComprovante()
        {
            Console.WriteLine($"Pix de R$ {_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.");
        }
    }
}
