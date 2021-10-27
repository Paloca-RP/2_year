using System;

namespace LABS02_RP
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            //Nivel 4C
            int variavel1, tmp, variavel2 = 2;
            variavel1 = 1;

            tmp = variavel1;
            variavel1 = variavel2;
            variavel2 = tmp;

            Console.WriteLine("XXXXX – slide 9 - Instruções e operadores de atribuição");
            Console.WriteLine("variável 1 = " + variavel1 + "\n" +
               "variável 2 = " + variavel2 + "\n" +
               "variavel 1 = " + variavel1++ + "\n" +
               "varivel 2 = " + variavel2-- + "\n");
            variavel1 += 10;
            variavel2 -= 20;
            Console.WriteLine("variável 1 = " + variavel1 + "\n" +
              "variável 2 = " + variavel2 + "\n");
            Console.WriteLine("prima return para continuar");
            Console.ReadKey();

            //Nivel 5
            //A e B    
            if(variavel1 > 10) 
            {
                Console.WriteLine("O valor " + variavel1 + " é maior que 10");
            } else {
                Console.WriteLine("O valor " + variavel1 +" é menor ou igual que 10");
            }
            //C e D
            if (variavel2 >= 0)
            {
                variavel2 = 1;
                Console.Write(variavel2 + " ");
            }
            else
            {
                variavel2 = -1;
                Console.Write(variavel2+ " ");
            }

            Console.WriteLine("prima return para continuar");
            Console.ReadKey();
            Console.Clear();

            //Nivel 6
            Console.WriteLine("Insira um numero de 1 a 5");
            var stringTmp1_RP = Console.ReadLine();

            int inteiro_RP = int.Parse(stringTmp1_RP);

            switch (inteiro_RP)
            {
                default:
                    Console.WriteLine("DEU BRONCA");
                    break;
                case 1:
                    Console.WriteLine("UM");
                    break;
                case 2:
                    Console.WriteLine("DOIS");
                    break;
                case 3:
                    Console.WriteLine("TRES");
                    break;
                case 4:
                    Console.WriteLine("QUATRO");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;
            }
            Console.WriteLine("prima return para continuar");
            Console.ReadKey();
            Console.Clear();
                        
            //Nivel 7
            Console.WriteLine("Insira um numero de 1 a 5");
            var stringTmp2_RP = Console.ReadLine();

            double numero_RP = double.Parse(stringTmp2_RP);

            if ((numero_RP >= 0.0 && numero_RP < 1.0) ||
                (numero_RP >= 1.0 && numero_RP < 2.0) ||
                (numero_RP >= 2.0 && numero_RP < 3.0) ||
                (numero_RP >= 3.0 && numero_RP < 4.0) ||
                (numero_RP >= 4.0 && numero_RP < 5.0) ||
                (numero_RP >= 5.0 && numero_RP < 6.0))
            {
                Console.WriteLine(Math.Round(numero_RP, MidpointRounding.ToZero)); ;
            }
            else
            {
                Console.WriteLine("DEU BRONCA");
            }
            Console.WriteLine("prima return para continuar");
            Console.ReadKey();
            Console.Clear();
            
            //Nivel 9
            Console.Write("Insira o nome: ");
            string stringTmp3_RP = Console.ReadLine();

            foreach (char c in stringTmp3_RP)
            {
                Console.WriteLine((char)c);
            }
            Console.WriteLine("\nprima return para continuar");
            Console.ReadKey();
            Console.Clear();
                         
            //Nivel 10
                
            int[] varNUM = new int[5];
            int i;
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("Insira um número: ");
                varNUM[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("\n {0}  ", varNUM[i]);
            }
            Console.WriteLine("\n\nprima return para continuar");
            Console.ReadKey();
            Console.Clear();

            //Nivel 11            
            /* O bloco de insAtruções que escreveu no nível 7 alíneas
            3a) a 3d) pelo menos uma vez e até que seja digitado
            um valor inferior a 0 ou igual ou superior a 6.-*/

            //Nivel 12 mesma coisa qyue o 11

            //Nivel 16
            //copiar do enunciado 











        }
    }
}




