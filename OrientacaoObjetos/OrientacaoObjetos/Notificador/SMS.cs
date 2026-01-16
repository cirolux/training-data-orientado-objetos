using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    public class SMS : INotificacoes
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
