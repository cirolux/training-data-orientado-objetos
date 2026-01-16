using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    public class PixPessoaFisicaJuridica : Pix
    {
        public PixPessoaFisicaJuridica(string cpfOriginador, string cnpjDestinatario, double valor)
        {
            _idOriginador = cpfOriginador;
            _idDestinatario = cnpjDestinatario;
            _valor = valor;
        }

        public override string Executar()
        {
            if (!ValidadorCPF.IsValid(_idOriginador))
                return "Originador inválido!";
            if (!ValidadorCNPJ.IsValid(_idDestinatario))
                return "Destinatário inválido!";
            if (_valor <= 0)
                return "Valor do pix deve ser positivo!";

            return $"Pix de R$ {_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.";
        }
    }
}
