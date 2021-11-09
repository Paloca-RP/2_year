using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT1_REC_RicardoPalhoca
{
    class Pessoa
    {
        //propriadades da classe Pessoa
        private string nome_RP;
        public String Nome_RP
        {
            get { return nome_RP; }
            set { nome_RP = value; }
        }

        private string numero_RP;
        public String Numero_RP
        {
            get { return numero_RP; }
            set { numero_RP = value; }
        }

        private short ano_RP;
        public short Ano_RP
        {
            get { return ano_RP; }
            set { ano_RP = value; }
        }
        
        // Construtor da classe pessoa
        public Pessoa(String nome_RP, String numero_RP, short ano_RP) //ctor tab tab
        {
            this.Nome_RP = nome_RP;
            this.Numero_RP = numero_RP;
            this.Ano_RP = ano_RP;
        }
        //contrutor sem parametros
       public Pessoa() : this ("Sem Nome", "Sem Numero", (short) 0)
       {
       }
        //construtor que recebem parametros 
        public Pessoa(String nome_RP) : this (nome_RP, "Sem Numero", 0)
        {
        }
    }
}
