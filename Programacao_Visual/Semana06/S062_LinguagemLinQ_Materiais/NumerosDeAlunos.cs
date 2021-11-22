using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP06_Collections
{
    public class NumerosDeAlunos : HashSet<String>
    {
        public NumerosDeAlunos(Unidade unidade, int ano, int qtdAlunos)
        {
            for (int i = 0; i < qtdAlunos; i++)
                this.Add(
                    ano.ToString().Substring(2) +
                    "0" +
                    (int)unidade +
                    i.ToString("000"));
            
        }

        override
        public String ToString()
        {
            String str = "";
            foreach (String s in this)
            {
                str += s + "\n";
            }
            return str;
        }

        public NumerosDeAlunos CopyOfNumeroDeAlunos
        {
            get
            {
                return (NumerosDeAlunos)from i in this select i;
            }
        }
    }
}
