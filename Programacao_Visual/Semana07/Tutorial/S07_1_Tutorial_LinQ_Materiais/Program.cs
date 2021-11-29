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
        }
    }
}