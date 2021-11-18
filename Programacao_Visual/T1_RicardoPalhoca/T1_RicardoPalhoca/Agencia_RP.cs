using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_RicardoPalhoca
{
    public class Agencia_RP 
    {
        public string Nome_RP { get; set; }

        public List<ClienteComCredito_RP> Clientes_RP { get; set; }

        public Agencia_RP(string nome)
        {
            this.Nome_RP = nome;
            this.Clientes_RP = new List<ClienteComCredito_RP>();
        }

        public override string ToString()
        {
            string clientes = "";
            foreach (ClienteComCredito_RP cliente in Clientes_RP)
                clientes += cliente.ToString() + "\n";
            return "*******************\n***** " + this.Nome_RP + "\n*******************\n Clientes: \n" + clientes;
        }
    }
}