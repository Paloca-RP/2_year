using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT1REC_RicardoPalhoca
{
    class Livraria_RP : List<Livro_RP>
    {
        public string Nome_RP { get; set; }

        public override string ToString()
        {
            string str = this.Nome_RP + "\n";

            foreach (Livro_RP pub in this)
            {
                str += pub.ToString() + "\n";
            }
            return str;
        }
    }
}
