using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S051_TutorialColecoes_RP
{
    class Livraria_RP : List<Livro_RP>
    {
        public override string ToString()
        {
            string str = "";
            foreach (Livro_RP p in this)
            {
                str += p + "\n";
            }

            return str;
        }
    }
}
