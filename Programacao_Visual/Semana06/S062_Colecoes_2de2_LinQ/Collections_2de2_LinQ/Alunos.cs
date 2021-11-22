using System;
using System.Collections.Generic;
using System.Text;

namespace TP06_Collections
{
    public class Alunos : List<Aluno>
    {
        // Como Alunos é uma List<Aluno> 
        // 1. Tem já todos os métodos de List<T>
        // 2. Só temos de codificar o ToString 
        override
        public String ToString()
        {
            String str = "";
            foreach (Aluno a in this)
            {
                str += a + "\n";
            }
            return str;
        }
    }
}
