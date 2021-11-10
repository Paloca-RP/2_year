using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT1_REC_RicardoPalhoca
{
    class Docente_RP : Pessoa
    {
        public string Categoria_RP { get; set; }
        public string Grau_RP { get; set; }

        public Docente_RP(string nome_RP, string numero_RP, short ano_RP, string categoria_RP, string grau_RP) : base(nome_RP, numero_RP, ano_RP)
        {
            Categoria_RP = categoria_RP;
            Grau_RP = grau_RP;
        }

        public Docente_RP() : this("Sem Nome", "Sem Numero", (short)0, "Sem Categoria", "Sem Grau")
        {
        }

        public Docente_RP(string nome_RP, string categoria_RP) : this(nome_RP, "Sem Numero", (short)0, categoria_RP, "Sem Grau")
        {
        }

        override public string ToString()
        {
            return base.ToString() + " - " + Categoria_RP + " - " + Grau_RP;
        }
    }
}
