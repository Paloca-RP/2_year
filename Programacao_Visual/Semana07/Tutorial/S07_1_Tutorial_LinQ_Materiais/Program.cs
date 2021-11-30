using System;
using System.Collections.Generic;
using System.Linq;

namespace TP06_TutorialLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XXXXXXXXXXX 1 TESTE DA LISTA");
            Alunos alunos = new Alunos();
            Console.WriteLine(alunos.ToString());

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("XXXXXXXXXXX 2 Todos os nomes de alunos");
            Console.WriteLine("\nXXX Nome XXX\n");
            var todos1 = from i in alunos select i.Nome;
            foreach (var i in todos1)
                Console.WriteLine(i.ToString());

            Console.WriteLine("\nXXX Contacto XXX\n");
            var todos2 = from i in alunos select i.Contacto;
            foreach (var i in todos2)
                Console.WriteLine(i.ToString());
            Console.WriteLine("\nXXX Email XXX\n");

            var todos3 = from i in alunos select i.Contacto.Mail;
            foreach (var i in todos3)
                Console.WriteLine(i.ToString());

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("XXXXX 4 Todas as cadeiras");
            var todos4 = from i in alunos select i.Cadeiras;
            foreach (var i in todos4)
                foreach(UnidadeCurricular c in i)
                    Console.WriteLine(c.ToString());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("XXXX 5 Todos os Ordenados por Nome");
           //por ordem por nomeeee !!!!
            var todosPorNomes =  from i in alunos
                                 orderby i.Nome
                                 select  i.Nome;
            foreach(var i in todosPorNomes)
                Console.WriteLine(i.ToString());

            var todosPorTelefone = from i in alunos 
                                   orderby i.Contacto.Telefone
                                   select i.Contacto.Telefone;
            foreach (var i in todosPorTelefone)
                Console.WriteLine(i.ToString());
            
            var todosPorMail = from i in alunos
                               orderby  i.Contacto.Mail
                               select i.Contacto.Mail;
            foreach(var i in todosPorMail)
                Console.WriteLine(i.ToString());

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("XXXX 6 Todos os Ordenados por Nome");
            //por ordem ascendente !!!!
            var todosPorNomesdescendente = from i in alunos
                                orderby i.Nome descending
                                select i.Nome;
            foreach (var i in todosPorNomesdescendente)
                Console.WriteLine(i.ToString());

            var todosPorTelefonedescendente = from i in alunos
                                   orderby i.Contacto.Telefone descending
                                   select i.Contacto.Telefone;
            foreach (var i in todosPorTelefonedescendente)
                Console.WriteLine(i.ToString());

            var todosPorMaildescendente = from i in alunos
                               orderby i.Contacto.Mail descending
                               select i.Contacto.Mail;
            foreach (var i in todosPorMaildescendente)
                Console.WriteLine(i.ToString());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("XXXX 7 Cotem, começa, Termina");
            Console.WriteLine("Cláudias");
            var claudias = from i in alunos
                           where i.Nome.Contains("Cláudia")
                           select i.Nome;
            foreach(var i in claudias)
                Console.WriteLine(i.ToString());
            Console.WriteLine("\nComeçado com AN\n");
            var comecaPorAN = from i in alunos
                              where i.Nome.StartsWith("An")
                              select i.Nome;
            foreach(var i in comecaPorAN)
                Console.WriteLine(i.ToString());
            Console.WriteLine("\nTeminados com A\n");
            var terminaPorA = from i in alunos
                               where i.Nome.EndsWith("a")
                              select i.Nome;
            foreach( var i in terminaPorA)
                Console.WriteLine(i.ToString());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("XXXX 8 Take Skip e Group by");
            var seteAlunosLei = (from i in alunos
                                where i.Curso == Curso.LEI
                                select i.Nome).Take(7);
            Console.WriteLine("Primeiros 7 alunos de LEI");
            foreach(var aluno in seteAlunosLei)
                Console.WriteLine(aluno);

            Console.WriteLine("4 e 5 aluno de LEI");
            var quartoEquinto = (from i in alunos
                                 where i.Curso == Curso.LEI
                                 select i.Nome).Take(5).Skip(3);
            Console.WriteLine("quarto e quinto Aluno");
            foreach(var aluno in quartoEquinto)
                Console.WriteLine(aluno);
            Console.WriteLine("Agrupados por curso");
            var alunosPorCurso = from i in alunos group i.Nome by i.Curso;
            foreach(var curso in alunosPorCurso)
            {
                Console.WriteLine("\t xxxxx Curso: " + curso.Key);
                foreach (var aluno in curso)
                    Console.WriteLine(aluno);
            }

        }
    }
}