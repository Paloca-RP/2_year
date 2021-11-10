using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT1_RicardoPalhoca
{
    class Publicacao_RP
    {
        private string titulo_RP;

        public string Titulo_RP
        {
            get { return titulo_RP; }
            set { titulo_RP = value; }
        }

        public Publicacao_RP(String titulo_RP)
        {
            this.Titulo_RP = titulo_RP;
        }

        public Publicacao_RP() : this("Sem Titulo")
        {
        }

        override public String ToString()
        {
            return Titulo_RP + "\n";
        }

    }
}
