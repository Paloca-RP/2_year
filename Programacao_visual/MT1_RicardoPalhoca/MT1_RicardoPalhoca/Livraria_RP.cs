using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT1_RicardoPalhoca
{
    class Livraria_RP : List<Publicacao_RP>
    {
        public string Nome_RP { get; set; }

        public Livraria_RP(string nome_RP)
        {
            this.Nome_RP = nome_RP;
        }

        public override string ToString()
        {
            string str = this.Nome_RP + "\n";

            foreach(Publicacao_RP pub in this)
            {
                str += pub.ToString() + "\n";
            }
            return str;
        }
    }
}
