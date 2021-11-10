using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT1_RicardoPalhoca
{
    class Livro_RP : Publicacao_RP
    {
        private string autor_RP;
        //explito
        public string Autor_RP
        {
            get { return autor_RP; }
            set { autor_RP = value; }
        }

        public Livro_RP( string autor_RP, string titulo_RP) : base (titulo_RP)
        {
            this.Titulo_RP = titulo_RP;
            this.Autor_RP = autor_RP;            
        }

        public Livro_RP() : this ("Sem Titulo", " Sem Autor")
        {
        }
        
        override public string ToString()
        {
            return base.Titulo_RP + " - " + Autor_RP + "\n";
        }


    }
}
