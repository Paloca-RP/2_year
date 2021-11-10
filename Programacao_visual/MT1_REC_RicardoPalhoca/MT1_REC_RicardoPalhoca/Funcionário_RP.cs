using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT1_REC_RicardoPalhoca
{
    class Funcionário_RP : Pessoa
    {
        public string Seccao_RP { get; set; }

        public Funcionário_RP(string nome_RP, string numero_RP, short ano_RP, string seccao_RP) : base(nome_RP, numero_RP, ano_RP)
        {
            Seccao_RP = seccao_RP;
        }

        public Funcionário_RP() : this("Sem Nome", "Sem Numero", (short)0, "Sem Secção")
        {
        }

        public Funcionário_RP(string nome_RP, string seccao_RP) : this(nome_RP, "Sem Numero", (short)0, seccao_RP)
        {
        }

        override public string ToString()
        {
            return base.ToString() + " - " + Seccao_RP;
        }
    }
}

