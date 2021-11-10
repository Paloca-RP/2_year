using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT1_REC_RicardoPalhoca
{
    class Individou_RP
    {
        private string nome_RP;
        public string Nome_RP
        {
            get { return nome_RP; }
            set { nome_RP = value; }
        }

        private byte mes_RP;
        public byte Mes_RP
        {
            get { return mes_RP; }
            set { mes_RP = value; }
        }

        private short ano_RP;
        public short Ano_RP
        {
            get { return ano_RP; }
            set { ano_RP = value; }
        }

        public Individou_RP(String nome_RP, byte mes_RP, short ano_RP)
        {
            this.Nome_RP = nome_RP;
            this.Mes_RP = mes_RP;
            this.Ano_RP = ano_RP;
        }

        public Individou_RP() : this ("Sem nome", 0, 0)
        {
        }

        public Individou_RP(String nome_RP) : this (nome_RP, 0, 0)
        {
        }

        override public string ToString()
        {
            return Nome_RP + "\t" + Mes_RP + "\t" + Ano_RP;
        }
    }
}
