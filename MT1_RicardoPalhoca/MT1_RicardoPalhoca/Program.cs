using System;

namespace MT1_RicardoPalhoca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nxxxxxxxx Nivel 1 - Publicação \n");

            Publicacao_RP p1 = new Publicacao_RP("Lusiadas");
            Publicacao_RP p2 = new Publicacao_RP();

            Console.WriteLine(p1.Titulo_RP);
            Console.WriteLine(p2.Titulo_RP);

            Console.WriteLine("\n xxxxxxx Nivel 2 - Herança \n");

            Livro_RP p3 = new Livro_RP("Memorial do Convento", "José Saramago");
            Livro_RP p4 = new Livro_RP();
        }
    }
}
