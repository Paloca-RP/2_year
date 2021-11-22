using System;
using System.Collections.Generic;
using System.Text;

namespace TP06_Collections
{
    class SetAlunos : HashSet<Aluno>
    {
        // Como SetAlunos é um HashSet<Aluno> 
        // 1. Tem já todos os métodos de HashSet<T>
        // 2. herda os Equals e GetHashCode de Object
        //    para os quais dois objetos "Aluno" são iguais se 
        //    referenciarem o mesmo endereço de memória ...
        // 3. Por isso teremos de redefinir os Equal e GetHshcode
        //    da classe Aluno por forma a que dois alunos sejam iguais
        //    de acordo com os nossos critérios: dois alunos serão 
        //    iguais se tiverem o mesmo numero de aluno (ver classe Aluno)
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
