using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT1_REC_RicardoPalhoca
{
    class Aluno_RP
    {
        private string nome_RP;
        public String Nome_RP
        {
            get { return nome_RP; }
            set { nome_RP = value; }
        }

        private string codigo_RP;
        public String Codigo_RP
        {
            get { return codigo_RP; }
            set { codigo_RP = value; }
        }

        private bool inscrito_RP;
        public bool Inscrito_RP
        {
            get { return inscrito_RP; }
            set { inscrito_RP = value; }
        }

        public Aluno_RP(String nome_RP, String codigo_RP, bool inscrito_RP)
        {
            this.Nome_RP = nome_RP;
            this.Codigo_RP = codigo_RP;
            this.Inscrito_RP = inscrito_RP;
        }

        public Aluno_RP() : this ("Sem nome", "0", false)
        {
        }
        public Aluno_RP(String nome_RP) : this (nome_RP,"Sem Codigo", false) 
        {
        }

        override public string ToString()
        {
            return base.ToString() + " - " + Codigo_RP + " - " + Inscrito_RP;
        }

    }
}
