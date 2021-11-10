using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT1_RicardoPalhoca
{
    class Publicacao_RP
    {
        public string Titulo_RP
        {
            get;
            set;
        }
        
        public Publicacao_RP(String titulo_RP)
        {
            this.Titulo_RP = titulo_RP;
        }

        public Publicacao_RP() : this("Sem Titulo")
        {
        }

        override public string ToString()
        {
            return Titulo_RP + "\n";
        }

    }
}
