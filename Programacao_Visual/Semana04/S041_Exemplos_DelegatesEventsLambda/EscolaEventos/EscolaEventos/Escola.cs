using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaEventos
{
    public class Escola
    {
        private Aluno joao = new Aluno("Joao Carlos", 1534);
        private Aluno manuel = new Aluno("Manuel Silva", 1426);
        private Aluno ana = new Aluno("Ana Martins", 2134);

        public void Run()
        {
            Console.WriteLine("Alunos:");
            Console.WriteLine(joao);
            Console.WriteLine(manuel);
            Console.WriteLine(ana);

            Disciplina pv = new Disciplina("Programação Visual");
            Disciplina es = new Disciplina("Engenharia de Software");

            Console.WriteLine("\nDisciplinas:");
            Console.WriteLine(pv);
            Console.WriteLine(es);

            Noticias noticias = new Noticias();

            Console.WriteLine("\nNoticias:");
            noticias.Mostrar();

            // O Manuel e a Ana querem inscrever-se a PV quando abrirem as inscrições
            pv.InscricoesAbriram += new InformacaoDisciplina(manuel.InscreverDisciplina);

            // Antes: 
            // pv.InscricoesAbertas += new InformacaoDisciplina(ana.InscreverDisciplina);
            // Depois:
            // Forma simplificada de instanciar o delegate. O compilador C# encarrega-se de usar implicitamente o 'new'
            pv.InscricoesAbriram += ana.InscreverDisciplina;

            // O Manuel e o João querem inscrever-se a ES quando abrirem as inscrições
            // Antes:
            // es.InscricoesAbriram += new InformacaoDisciplina(manuel.InscreverDisciplina);
            // es.InscricoesAbriram += new InformacaoDisciplina(joao.InscreverDisciplina);
            // Depois
            // Em vez dos alunos se inscreverem no evento através do método InscreverDisciplina da classe aluno
            // passa a inscrever-se os alunos através do método InscreverAlunos que foi criado aqui na classe Escola
            // Neste caso não é necessário referir o objecto antes do nome do método (na realidade é como se fizesse this.InscreverAlunos)
            // Esta solução pode retirar a necessidade da classe Aluno conhecer a classe Disciplina eliminando-se dessa classe o método InscreverDisciplina..
            es.InscricoesAbriram += InscreverAlunos;

            // Inscrição no evento através da criação de um 'método anonimo'
            // Neste caso usa-se a palavra 'delegate' como nome do método, seguida dos parâmetros e do código do método.
            es.InscricoesAbriram += delegate (Disciplina disciplina)
            {
                Console.WriteLine("(Run Escola - método anónimo)> Abriram Inscricoes em " + disciplina.Nome);
            };

            // Inscrição no evento através da criação de uma expressão lambda
            // Neste caso usa-se o formato: (parâmetros entrada) => { instruções a executar }
            // Nota 1: pode-se omitir os parênteses nos parâmetros de entrada se for só um parâmetro. O mesmo para as chavetas no código se for só uma instrução.
            // Nota 2: pode-se omitir o(s) tipo(s) do(s) parãmetro(s) se o compilador for capaz de os inferir a partir da instrução onde foram colocados.
            es.InscricoesAbriram += disciplina => Console.WriteLine("(Run Escola - expressão lambda)> Abriram Inscricoes em " + disciplina.Nome);

            // As noticias querem saber quando são abertas inscrições em disciplinas
            pv.InscricoesAbriram += new InformacaoDisciplina(noticias.InscricoesAbriram);
            es.InscricoesAbriram += new InformacaoDisciplina(noticias.InscricoesAbriram);

            Console.WriteLine("Abrir Inscrições às disciplinas");
            pv.AbrirInscricoes();
            es.AbrirInscricoes();

            Console.WriteLine("\nNoticias:");
            noticias.Mostrar();


            Console.WriteLine("\nDisciplinas:");
            Console.WriteLine(pv);
            Console.WriteLine(es);

            // Utilização do método de extensão "AddDateToday()" `para objectos da classe 'string' acrescentado na classe estática 'Extensoes' deste projecto
            Console.WriteLine("Informação obtida em".AddDateToday());

            DateTime date = new DateTime(2010, 12, 14);
            string msg = "Copyright © EST Setubal";

            // Utilização do método de extensão "AddDate(Date d)" `para objectos da classe 'string' acrescentado na classe estática 'Extensoes' deste projecto
            Console.WriteLine(msg.AddDate(date));

            Console.ReadLine();
        }

        void InscreverAlunos(Disciplina disciplina)
        {
            disciplina.Inscrever(manuel);
            disciplina.Inscrever(joao);
        }
    }
}
