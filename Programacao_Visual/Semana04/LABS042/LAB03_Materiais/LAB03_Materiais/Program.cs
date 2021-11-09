using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB01_PV201617
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("// Niveis 1 a 6 do LAB03 *****************");
            Circulo circ1 = new Circulo(1, 2, 3);
            Quadrado quad1 = new Quadrado(4);
            Quadrado quad2 = new Quadrado(100, 200, 300);
            

            Console.WriteLine(circ1 + " A=" + circ1.Area);
            Console.WriteLine(quad1 + " A=" + quad1.Area);
            Console.WriteLine(quad2 + " A=" + quad2.Area);

            //Nivel 6
            Reta reta1 = new Reta(10, 20, 30, 40);
            Console.WriteLine(reta1 + " A=" + quad2.Area);
            Desenho des1 = new Desenho();
            des1.AdicionarFigura(circ1);
            des1.AdicionarFigura(quad1);
            des1.AdicionarFigura(quad2);
           
            //Nivel 6
            des1.AdicionarFigura(reta1);

            Console.WriteLine(des1);

            Console.WriteLine("\n// Nivel 4 - Mover (0,2) *****************");
            IMovimentavel[] movs = new IMovimentavel[3];
            Circulo circ2 = new Circulo(0, 0, 15);
            Quadrado quad3 = new Quadrado(1, 1, 7);
            
            movs[0] = circ2;
            movs[1] = quad3;
            movs[2] = des1;
            
            for (int i = 0; i < movs.Length; i++)
            {
                movs[i].Mover(1000, 2000);
                Console.WriteLine(i + " - " + movs[i].ToString());
            }

            Console.WriteLine("\n// Nivel 5 - Area total das figuras *****************");
            Console.WriteLine("Area = " + des1.Area);

            Console.WriteLine("\n// Nivel 5 - Area total das figuras *****************");
            Console.WriteLine(des1);
            Console.WriteLine("\n// Nivel 5 - Remover Figura (1) *****************");
            des1.RemoverFigura(1);
            Console.WriteLine(des1);
            Console.ReadKey();
        }
    }
}
