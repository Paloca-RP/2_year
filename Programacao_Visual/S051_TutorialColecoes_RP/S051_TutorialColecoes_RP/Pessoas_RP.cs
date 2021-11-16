using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S051_TutorialColecoes_RP
{
    class Pessoas_RP : List<Pessoa_RP>
    {
        public override string ToString()
        {
            string str = "";
            foreach (Pessoa_RP p in this)
            {
                str += p + "\n";
            }

            return str;
        }
    }
}
