using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_RicardoPalhoca
{
    public class CartaoDebito_RP
    {
        public string Numero_RP { get; set; }
        public decimal Saldo_RP { get; set; }

        public CartaoDebito_RP(string numero_RP, decimal saldo_RP)
        {
            Numero_RP = numero_RP;
            Saldo_RP = saldo_RP;
        }

        public CartaoDebito_RP() : this("00000000000", 0)
        {
        }

        public override string ToString()
        {
            return Numero_RP + "\t" + Saldo_RP;
        }
    }
}
