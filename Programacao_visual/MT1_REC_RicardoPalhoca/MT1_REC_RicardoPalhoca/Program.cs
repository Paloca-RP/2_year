using System;

namespace MT1_REC_RicardoPalhoca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nXXXXXXXXXXXXXX CRIAR E USAR OBJETOS");

            Pessoa p1 = new Pessoa("Diogo Fernandes", "123456789", (short)1999);

            Console.WriteLine(p1.Nome_RP);
            Console.WriteLine(p1.Numero_RP);
            Console.WriteLine(p1.Ano_RP);
            Console.ReadKey();
            Console.Clear();

            // metodo imprime 
            Pessoa p2 = new Pessoa();

            Imprime(p1.Nome_RP, p1.Numero_RP, p1.Ano_RP);
            Imprime(p2.Nome_RP, p2.Numero_RP, p2.Ano_RP);

            Console.ReadKey();
            Console.Clear();
            //valor nome o resto por omissão
            Pessoa p3 = new Pessoa("José Saramago");
            Imprime(p3.Nome_RP, p3.Numero_RP, p3.Ano_RP);
        }
        /// <summary>
        /// Fiquei no ponto 15
        /// </summary>
        public static void Imprime(String nome_RP, String numero_RP, short ano_RP)
        {
            Console.WriteLine(nome_RP);
            Console.WriteLine(numero_RP);
            Console.WriteLine(ano_RP);
        }
    }

}
