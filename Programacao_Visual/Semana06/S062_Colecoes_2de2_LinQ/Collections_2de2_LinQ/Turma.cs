using System;
using System.Collections.Generic;
using System.Text;

namespace TP06_Collections
{
    class Turma
    {

        // Como Turma tem uma propriedade do tipo List<Aluno> 
        // 1. Caso o construtor não receba um parametro para
        //    inicializar o atributo do tipo List<Aluno>
        //    teremos de criar a List<Aluno> no construtor!!!
        // 2. Temos de codificar todos os métodos de List<T> que necessitemos

        public String Curso { get; set; }
        public int Ano { get; set; }
        public String Nome { get; set; }
        // Turma tem um atributo (Propriedade) do tipo List<Aluno>
        public List<Aluno> Alunos { get; set; }

        public Aluno this[int i] // indexer p/ a lista Alunos
        {
            get { return Alunos[i]; }
            set { Alunos[i] = value; }
        }


        public Turma(String curso, int ano, String nome)
        {
            // Como não recebe nenhum parametro
            // para uma List<Aluno>
            // o construtor deve criar uma instancia
            // de List<Aluno>
            Alunos = new List<Aluno>();
        }

        // Como turma não é uma List<Aluno>
        // temos de implementar todos os métodos de
        // que possamos necessitar

        public void Add(Aluno al)
        {
            Alunos.Add(al);
        }

        public void Remove (Aluno al)
        {
            Alunos.Remove(al);
        }

        public void RemoveAt(int i)
        {
            Alunos.RemoveAt(i);
        }

        public Aluno GetAt(int i)
        {
            return Alunos[i];
        }

        // a única diferença do ToString da classe Alunos é que
        // em turma iteramos a propriedade Alunos
        // em vez de iterar o próprio (this) objeto
        override public String ToString()
        {
            String str = "Turma: " + Nome + " " + Ano + "º ano" + " do" + Curso + "\n";
            foreach (Aluno a in Alunos)
            {
                str += a + "\n";
            }
            return str;
        }
    }
}
