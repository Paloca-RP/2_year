using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaEventos
{
    public class Aluno
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    nome = value;
                else
                    nome = "N/D";
            }
        }

        public int Numero { get; set; }


        public Aluno(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
        }

        public override string ToString()
        {
            return "nome: " + nome + "   numero: " + Numero;
        }

        public void InscreverDisciplina(Disciplina disciplina)
        {
            disciplina.Inscrever(this);
        }
    }
}
