using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S051_TutorialColecoes_RP
{
    class Retangulos_RP : List<Retangulo_RP>
    {
        public override string ToString()
        {
            string str = "";
            foreach (Retangulo_RP p in this)
            {
                str += p + "\n";
            }

            return str;
        }
    }
}
