using System;
using System.Collections.Generic;

namespace S051_TutorialColecoes_RP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX Listas - List < T > ");

            //Criar uma lista de inteiros
            List<int> listaDeInteiros = new List<int>();

            //Inserir valores de 0 a 19 na lista
            for (int i = 0; i < 20; i++)
            {
                listaDeInteiros.Add(i);
            }

            //Imprimir os valores da lista
            foreach (int i in listaDeInteiros)
            {
                Console.WriteLine(i);
            }

            //Somar o conteudo da lista e imprimir o resultado
            int soma = 0;
            foreach (int i in listaDeInteiros)
            {
                soma += i;
            }
            Console.WriteLine(soma);

            //Inserir valores de 0 a 19 na lista
            for (int i = 0; i < 20; i++)
            {
                listaDeInteiros.Add(i);
            }

            //Imprimir os valores da lista
            foreach (int i in listaDeInteiros)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nXXXXXXXXXXXXXXXXXXX CLASSES");
            DateTime date1 = new DateTime(2022, 01, 01);
            DateTime date2 = new DateTime(2023, 01, 01);
            CartaoDoCidadao_RP cc1 = new CartaoDoCidadao_RP("123456789", date1);
            CartaoDoCidadao_RP cc2 = new CartaoDoCidadao_RP("637869385", date2);
            Console.WriteLine(cc1.ToString());
            Console.WriteLine(cc2.ToString());

            Console.WriteLine("\nXXXXXXXXXXXXXXXXXXX COMPOSIÇÃO");
            DateTime dataNasc1 = new DateTime(2002, 03, 04);
            DateTime dataNasc2 = new DateTime(2001, 05, 12);
            Pessoa_RP pessoa1 = new Pessoa_RP("Ana Monteiro", dataNasc1, cc1);
            Pessoa_RP pessoa2 = new Pessoa_RP("Filipe Santos", dataNasc2, cc2);
            Console.WriteLine(pessoa1.ToString());
            Console.WriteLine(pessoa2.ToString());

            Console.WriteLine("\nXXXXXXXXXXXXXXXXXXX HERANÇA");
            DateTime date3 = new DateTime(2022, 02, 01);
            DateTime dataNasc3 = new DateTime(2002, 03, 04);
            CartaoDoCidadao_RP cc3 = new CartaoDoCidadao_RP("222222222", date3);
            Aluno_RP aluno1 = new Aluno_RP("Lena Pereira", dataNasc3, cc3, "202000622");
            Console.WriteLine(aluno1.ToString());

            Console.WriteLine("\nXXXXXXXXXXXXXXXXXXX COLEÇÕES => List<T>");
            List<Pessoa_RP> pessoas = new List<Pessoa_RP>();
            Pessoa_RP pessoa3 = new Pessoa_RP("Hugo Fernandes", dataNasc1, cc1);
            Pessoa_RP pessoa4 = new Pessoa_RP("Marta Santos", dataNasc2, cc2);
            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);
            pessoas.Add(pessoa3);
            pessoas.Add(pessoa4);

            foreach (Pessoa_RP p in pessoas)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nXXXXXXXXXXXXXXXXXXX COLEÇÕES QUE HERDAM DE List < T > ");
            Pessoas_RP p1 = new Pessoas_RP();
            p1.Add(pessoa1);
            p1.Add(pessoa2);
            p1.Add(pessoa3);
            p1.Add(pessoa4);
            Console.WriteLine(p1.ToString());

            Console.WriteLine("XXXXXXXXXXXXXXXXXXX Consolidação de listas 1 => List < FiguraGeometrica_NA > ");
            Ponto_RP ponto1 = new Ponto_RP(10, 20);
            Ponto_RP ponto2 = new Ponto_RP(10, 20);
            Ponto_RP ponto3 = new Ponto_RP(10, 20);
            Ponto_RP ponto4 = new Ponto_RP(10, 20);

            Console.WriteLine(ponto1.ToString());
            Console.WriteLine(ponto2.ToString());
            Console.WriteLine(ponto3.ToString());
            Console.WriteLine(ponto4.ToString());

            FiguraGeometrica_RP f1 = new FiguraGeometrica_RP(ponto1);
            FiguraGeometrica_RP f2 = new FiguraGeometrica_RP(ponto2);
            FiguraGeometrica_RP f3 = new FiguraGeometrica_RP(ponto3);
            FiguraGeometrica_RP f4 = new FiguraGeometrica_RP(ponto4);

            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());
            Console.WriteLine(f3.ToString());
            Console.WriteLine(f4.ToString());

            Retangulo_RP ret1 = new Retangulo_RP(ponto1, 5);
            Retangulo_RP ret2 = new Retangulo_RP(ponto2, 5);
            Retangulo_RP ret3 = new Retangulo_RP(ponto3, 5);
            Retangulo_RP ret4 = new Retangulo_RP(ponto4, 5);

            Console.WriteLine(ret1.ToString());
            Console.WriteLine(ret2.ToString());
            Console.WriteLine(ret3.ToString());
            Console.WriteLine(ret4.ToString());

            Pontos_RP pontos = new Pontos_RP();
            pontos.Add(ponto1);
            pontos.Add(ponto2);
            pontos.Add(ponto3);
            pontos.Add(ponto4);
            Console.WriteLine(pontos.ToString());

            FigurasGeometricas_RP FigurasGeometricas = new FigurasGeometricas_RP();
            FigurasGeometricas.Add(f1);
            FigurasGeometricas.Add(f2);
            FigurasGeometricas.Add(f3);
            FigurasGeometricas.Add(f4);
            Console.WriteLine(FigurasGeometricas.ToString());

            Retangulos_RP retangulos = new Retangulos_RP();
            retangulos.Add(ret1);
            retangulos.Add(ret2);
            retangulos.Add(ret3);
            retangulos.Add(ret4);
            Console.WriteLine(retangulos.ToString());

            Autor_RP autor = new Autor_RP("Sandra Melo", "PT");
            Console.WriteLine(autor.ToString());

            Livro_RP livro = new Livro_RP("Peaky Blinders", date1, autor);
            Console.WriteLine(livro.ToString());

            Livraria_RP livraria = new Livraria_RP();
            livraria.Add(livro);
            Console.WriteLine(livraria.ToString());
        }
    }
}
