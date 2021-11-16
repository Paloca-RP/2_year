using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT1REC_RicardoPalhoca
{
    class Auto_RP
    {
        private string nome_RP;
        public string Nome_RP
        {
            get { return nome_RP; }
            set { nome_RP = value; }
        }

        private string idiomaOriginal_RP;
        public string IdiomaOriginal_RP
        {
            get { return idiomaOriginal_RP; }
            set { idiomaOriginal_RP = value; }
        }

        public Auto_RP(string idiomaOriginal_RP, string nome_RP) 
        {
            IdiomaOriginal_RP = idiomaOriginal_RP;
            this.Nome_RP = nome_RP;
        }

        public Auto_RP() : this("Sem Lingua", " Sem Nome")
        {
        }

        override public string ToString()
        {
            return IdiomaOriginal_RP + "\t " + Nome_RP + "\n";
        }


    }
}
