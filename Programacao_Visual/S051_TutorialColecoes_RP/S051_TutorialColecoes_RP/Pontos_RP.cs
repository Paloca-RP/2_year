using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S051_TutorialColecoes_RP
{
    class Pontos_RP : List<Ponto_RP>
    {
        public override string ToString()
        {
            string str = "";
            foreach (Ponto_RP p in this)
            {
                str += p + "\n";
            }

            return str;
        }
    }
}
