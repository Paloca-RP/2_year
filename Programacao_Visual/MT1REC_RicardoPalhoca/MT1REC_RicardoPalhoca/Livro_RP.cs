using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT1REC_RicardoPalhoca
{
    class Livro_RP
    {
        public string Titulo_RP { get; set; }
        public int Stock_RP { get; set; }

        public Auto_RP Autor_RP { get; set; }

        public Livro_RP(int stock_RP, string titulo_RP, Auto_RP autor_RP)
        {
            this.Titulo_RP = titulo_RP;
            this.Autor_RP = autor_RP;
            this.Stock_RP = stock_RP;
            
        }

        public Livro_RP() : this(0, "Sem Título", new Auto_RP())
        {
        }
        public Livro_RP(Auto_RP autor) : this(0, "Sem Título", autor)
        {
        }
        public override string ToString()
        {
            return Stock_RP + " \t" + Titulo_RP + " \n" + Autor_RP;
        }
    }
}
