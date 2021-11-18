using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_RicardoPalhoca
{
    public class Cliente_RP
    {
        public string Nome_RP { get; set; }
        public CartaoDebito_RP Cartao_RP { get; set; }

        public Cliente_RP(string nome_RP, CartaoDebito_RP cartao_RP)
        { 
            Nome_RP = nome_RP;
            Cartao_RP = cartao_RP;
        }
        public Cliente_RP() : this("Sem Nome", new CartaoDebito_RP())
        {
        }

        public override string ToString()
        {
            return Nome_RP + " \n" + Cartao_RP;
        }
    }
}
