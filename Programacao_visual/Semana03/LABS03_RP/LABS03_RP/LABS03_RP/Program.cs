using System;

namespace LABS03_RP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XXXXXXXXXXXX NIVEL 1 - Figuras Círculo e Quadrado \n");
            Quadrado_RP quadrado = new Quadrado_RP(1, 1, 5);
            Quadrado_RP quadrado2 = new Quadrado_RP(2, 0, 3);
            Círculo_RP circulo = new Círculo_RP(-1, 0, 3);

            Console.WriteLine("XXXXXXXXXXXX NIVEL 2 - ToString e GetArea \n");
            Console.WriteLine(quadrado.ToString());
            Console.WriteLine("Área do Quadrado: " + quadrado.GetArea_RP());
            Console.WriteLine("Área do Quadrado: " + quadrado2.GetArea_RP());
            Console.WriteLine(circulo.ToString());
            Console.WriteLine("Área do Círculo: " + circulo.GetArea_RP());
            Console.WriteLine("Pressione para continuar !!");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("XXXXXXXXXXXX NIVEL 3 - Desenho \n");
            Desenho_RP desenho = new Desenho_RP(3);
            desenho.AdicionarFigura_RP(quadrado);
            desenho.AdicionarFigura_RP(circulo);
            desenho.AdicionarFigura_RP(quadrado2);
            Console.WriteLine(desenho.ToString());
            Console.WriteLine("Pressione para continuar !!");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("XXXXXXXXXXXX NIVEL 4 - Interface \n");
            IMovimentavel_RP[] movimentaveis = new IMovimentavel_RP[3];
            movimentaveis[0] = quadrado;
            movimentaveis[1] = circulo;
            movimentaveis[2] = desenho;
            foreach (IMovimentavel_RP m in movimentaveis)
            {
                m.Mover_RP(2, 3);
                Console.WriteLine(m.ToString());
            }
            Console.WriteLine("Pressione para continuar !!");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("XXXXXXXXXXXX NIVEL 5 - Área total do desenho, Remover Figura \n");
            //tres figuras no desenho, 25 + 9 + 28.26
            Console.WriteLine("Área total do desenho: " + desenho.GetArea_RP());
            desenho.RemoverFigura_RP(0);
            Console.WriteLine(desenho.ToString());
            Console.WriteLine("Pressione para continuar !!");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("XXXXXXXXXXXX NIVEL 6 - Criar retangulo, Adicionar ao desenho\n");
            Retangulo_RP retangulo = new Retangulo_RP(-2, -1, 3, 5);
            desenho.AdicionarFigura_RP(retangulo);
            Console.WriteLine(desenho.ToString());
            Console.WriteLine("Pressione para continuar !!");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("XXXXXXXXXXXX NIVEL 7 - Triangulo, redimensionável \n");
            Triangulo_RP triangulo = new Triangulo_RP(0, 0, 2, 6);
            Console.WriteLine(triangulo.ToString());
            IRedimensionável_RP[] redimensionavel = new IRedimensionável_RP[3];
            redimensionavel[0] = quadrado;
            redimensionavel[1] = circulo;
            redimensionavel[2] = triangulo;
            foreach (IRedimensionável_RP r in redimensionavel)
            {
                r.Redimensionar_RP(5);
                Console.WriteLine(r.ToString());
            }
        }
    }
}
