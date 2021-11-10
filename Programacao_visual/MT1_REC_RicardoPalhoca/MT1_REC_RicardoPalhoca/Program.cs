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

            Imprime_Pessoa(p1.Nome_RP, p1.Numero_RP, p1.Ano_RP);
            Imprime_Pessoa(p2.Nome_RP, p2.Numero_RP, p2.Ano_RP);

            Console.ReadKey();
            Console.Clear();
            //valor nome o resto por omissão
            Pessoa p3 = new Pessoa("José Saramago");
            Imprime_Pessoa(p3.Nome_RP, p3.Numero_RP, p3.Ano_RP);
            /////////// /// /   //  /   //  /   /   /
            ///
            Console.ReadKey();
            Console.Clear();
            Individou_RP i1 = new Individou_RP("Zeca Couves", 2, (short)1984);
            Individou_RP i2 = new Individou_RP();
            Individou_RP i3 = new Individou_RP("Gzuz");
            Console.WriteLine(i1.ToString());
            Console.WriteLine(i2.ToString());
            Console.WriteLine(i3.ToString());

            Aluno_RP a2 = new Aluno_RP();
            Aluno_RP a3 = new Aluno_RP("Diogo Neves", "482397", true);
            Console.WriteLine(a2.ToString());
            Console.WriteLine(a3.ToString());

            Trabalhador_RP t1 = new Trabalhador_RP("Tion Wayne", 92387, 21);
            Trabalhador_RP t2 = new Trabalhador_RP();
            Trabalhador_RP t3 = new Trabalhador_RP("Lello");
            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());
            Console.WriteLine(t3.ToString());
        }
        public static void Imprime_Pessoa(String nome_RP, String numero_RP, short ano_RP)
        {
            Console.WriteLine(nome_RP);
            Console.WriteLine(numero_RP);
            Console.WriteLine(ano_RP);
        }

        public static void Imprime_Individou(String nome_RP, byte mes_RP, short ano_RP)
        {
            Console.WriteLine(nome_RP);
            Console.WriteLine(mes_RP);
            Console.WriteLine(ano_RP);
        }
    }

}
