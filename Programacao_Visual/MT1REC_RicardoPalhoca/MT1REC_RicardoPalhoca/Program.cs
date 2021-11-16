using System;

namespace MT1REC_RicardoPalhoca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("xxxxxxxx Nivel 1 - Autor");

            Auto_RP p1 = new Auto_RP("Portugues", "José Saramago");
            Auto_RP p2 = new Auto_RP();

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            Console.WriteLine("xxxxxxxx Nivel 2 - Composição");

            Livro_RP livro1 = new Livro_RP(10, "Memorial do Convento",p1);
            Livro_RP livro2 = new Livro_RP(p1);
            Livro_RP livro3 = new Livro_RP();


            Console.WriteLine(livro1.ToString());
            Console.WriteLine(livro2.ToString());
            Console.WriteLine(livro3.ToString());

            Console.WriteLine("xxxxxxx Nivel 3 - Herança");


            Console.WriteLine("xxxxxxxx Nivel 4 - Coleções");

            Livraria_RP p5 = 
                new Livraria_RP() { Nome_RP = "Paloca's Bookstore" };
            Console.WriteLine("************\n" + p5.ToString() + "************");

            Console.WriteLine("xxxxxxx Nivel 5 - Polimorfismo");

            p5.Add(livro1);
            p5.Add(livro2);
            p5.Add(livro3);
            Console.WriteLine(p5.ToString());
        }
    }
}