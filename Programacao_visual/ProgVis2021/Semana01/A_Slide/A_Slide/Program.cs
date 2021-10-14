using System;

namespace TP01_Slides
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int numint = 5, numint2 = 6, aux;
            aux = numint;
            numint = numint2;
            numint2 = aux;

            bool b = (numint == 5);
            Console.WriteLine(b);
        }
    }
}
