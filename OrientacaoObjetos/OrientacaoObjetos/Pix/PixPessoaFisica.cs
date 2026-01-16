using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    public class PixPessoaFisica : Pix
    {
        public PixPessoaFisica(string cpfOriginador, string cpfDestinatario, double valor)
        {
            _idOriginador = cpfOriginador;
            _idDestinatario = cpfDestinatario;
            _valor = valor;
        }

        public override string Executar()
        {
            if (!ValidadorCPF.IsValid(_idOriginador))
                return "Originador inválido!";
            if (!ValidadorCPF.IsValid(_idDestinatario))
                return "Destinatário inválido!";
            if (_valor <= 0)
                return "Valor do pix deve ser positivo!";

            return $"Pix de R$ {_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.";
        }
    }
}
