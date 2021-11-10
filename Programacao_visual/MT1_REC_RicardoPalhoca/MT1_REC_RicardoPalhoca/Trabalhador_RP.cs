using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT1_REC_RicardoPalhoca
{
    class Trabalhador_RP
    {
        private string nome_RP;

        public string Nome_RP
        {
            get { return nome_RP; }
            set { nome_RP = value; }
        }

        private long numero_RP;

        public long Numero_RP
        {
            get { return numero_RP; }
            set { numero_RP = value; }
        }

        private byte qtdAnos_RP;

        public byte QtdAnos_RP
        {
            get { return qtdAnos_RP; }
            set { qtdAnos_RP = value; }
        }

        public Trabalhador_RP( String nome_RP, long numero_RP, byte qtdAnos_RP)
        {
            this.Nome_RP = nome_RP;
            this.Numero_RP = numero_RP;
            this.QtdAnos_RP = qtdAnos_RP;
        }

        public Trabalhador_RP() : this("Sem Nome", 0, 0)
        {
        }
        public Trabalhador_RP(String nome_RP) : this(nome_RP, 0, 0)
        {
        }

        override public string ToString()
        {
            return Nome_RP + "\t" + Numero_RP + "\t" + QtdAnos_RP;
        }
    }
}
