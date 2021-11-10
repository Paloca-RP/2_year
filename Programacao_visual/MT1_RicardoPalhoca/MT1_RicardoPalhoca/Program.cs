using System;

namespace MT1_RicardoPalhoca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("xxxxxxxx Nivel 1 - Publicação");

            Publicacao_RP p1 = new Publicacao_RP("Lusiadas");
            Publicacao_RP p2 = new Publicacao_RP();

            Console.WriteLine(p1.Titulo_RP);
            Console.WriteLine(p2.Titulo_RP);

            Console.WriteLine("xxxxxxx Nivel 2 - Herança");

            Livro_RP p3 = new Livro_RP("Memorial do Convento", "José Saramago");
            Livro_RP p4 = new Livro_RP();

            Console.WriteLine(p3.ToString());//tem de meter o tostring 

            Console.WriteLine("xxxxxxxx Nivel 3 - Coleções");

            Livraria_RP p5 = new Livraria_RP("Paloca's Bookstore");
            Console.WriteLine(p5.ToString());

            Console.WriteLine("xxxxxxx Nivel 4 - Polimorfismo");

            p5.Add(p1);
            p5.Add(p2);
            p5.Add(p3);
            p5.Add(p4);
            Console.WriteLine(p5.ToString());

        }
    }
}
