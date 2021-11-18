using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_RicardoPalhoca
{
    public class ClienteComCredito_RP :  Cliente_RP
    {
        public decimal CreditoDisponivel_RP { get; set; }

        public ClienteComCredito_RP(decimal creditoDisponivel_RP, string nome_RP, CartaoDebito_RP cartao_RP) : base ( nome_RP, cartao_RP)
        {
            CreditoDisponivel_RP = creditoDisponivel_RP;
        }

        public ClienteComCredito_RP() : this(0, "Sem Nome", new CartaoDebito_RP())
        {
        }
        public override string ToString()
        {
            return Nome_RP + "\n" + Cartao_RP + "\tCre: " + CreditoDisponivel_RP + "\n";
        }
    }
}
