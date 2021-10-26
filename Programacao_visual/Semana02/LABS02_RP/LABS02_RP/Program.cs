// Tal como em Java, a linhas antecedidas por //
// não são consideradas código pelo compilador
// Para comentar e descomentar código no VS
// selecciona-se o código e Ctrl k + Ctrl C
// Em C# usam-se namespaces com uma função equivalente
// aos packages do JAVA.
// A diretiva using do C# é semelhante ao import do JAVA e
// permite usar tipos de outro namespace
//// sem ter de os especificar

using System;

namespace LABS02_RP
{
    // Em C# os comentários em XML, equivalentes ao Javadoc
    // do Java, iniciam-se por /// e originam ficheiros em XML
    /// <summary>
    /// ola mundo
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            /*Nivel 2
            Console.WriteLine("Hello World!");
           
            Console.WriteLine("Prima return para continuar");
            Console.ReadKey();
            Console.Clear();

            //Nivel 3
            Console.WriteLine("\nXXXXX - Tipos de Dados - Slide 7" +
                "\n\nUm tipo de dados define um conjunto de valores e as" +
                "\noperações que podemos executar com esses valores");
            Console.WriteLine("\nprima return para continuar");
            Console.ReadKey();
            Console.Clear();

            //Nivel 4 A
            Console.WriteLine("\nXXXXX – IDENTIFICADORES Slide 7" +
                "\n\nUm identificador é um nome que damos " +
                "\n a uma entidade de um programa de c#" +
                "\n como classes, variáveis ou métodos" +
                "\nEm C# todos as entidades públicas (ou none) " +
                "\n têm os seus nomes em PascalCase " +
                "\n (PrimeiraLetraDeCadaPalavraMaiuscula" +
                "\n\nEm C# as entidades que não sejam públicas (ou none) " +
                "\n têm os seus nomes em camelCase " +
                "\n (primeiraLetraDaPrimeiraPalavraMinuscula");
            Console.WriteLine("\nMandam as práticas de bem programar que" +
                "\n\nNão usemos no código caracteres específicos do português" +
                "\n mas podemos usá-los nos comentários ou nas saídas" +
                "\n Exemplo: não usar Ç ã, á, í etc." +
                "\n\nNão usemos acrónimos nem abreviaturas nos identificadores" +
                "\n Exemplo: não usar num para numero, opc para opcao etc." +
                "\n\nEscolhemos cuidadosamente os nomes das variáveis " +
                "\n por forma a identificarem a entidade envolvida." +
                "\n\nEscolhemos verbos para ações, procedimento e funções" +
                "\n Exemplo: CalculaMedia, TrocaValores" +
                "\n\nEscolhemos substantivos para classes, e variáveis" +
                "\n Exemplo: Aluno, Escola, posicao, media ");
            Console.WriteLine("\nprima return para continuar");
            Console.ReadKey();
            Console.Clear();

            //Nivel 4B
            Console.WriteLine("\nXXXXX - TIPOS DE DADOS POR VALOR E POR REFERÊNCIA – Slide 8" +
                 "\n\ntipo por valor (int, double char etc): " +
                 "\n na variável é escrito um valor" +
                 "\n\ntipo por referência (Int32, Double, Char etc): " +
                 "\n na variável é escrita uma referência " +
                 "\n (o endereço de memória onde está o objeto)" +
                 "\n\nEm c# os tipos simples (incorporados ou built-in) " +
                 "\n podem ser vistos como nomes alternativos (alias)" +
                 "\n para as classes existentes." +
                 "\n\nOs tipos simples são tipos por valor " +
                 "\n significando que as suas variáveis armazenam valores");
            Console.WriteLine("prima return para continuar");
            Console.ReadKey();
            Console.Clear();

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
            */
            Console.WriteLine("\nXXXXX slide 10 - Operador condicional ? :");
            Console.Write("\nEscreva o nome de um mês em minúsculas >");
            string str = Console.ReadLine();
            Console.WriteLine(str == "fev" ? "tem 28 dias" : "tem 30 ou 31 dias");
            Console.WriteLine("prima return para continuar");
            Console.ReadKey();
            Console.Clear();             

            //Nivel 6

            //fazer exercicios do nivel!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 


            Console.WriteLine("\nXXXXX Slide 11 - seleção if-else");
            switch (str) // str tem de ser de um tipo enumeravel ou string
            {
                case "janeiro":
                case "março":
                case "maio":
                case "julho":
                case "agosto":
                case "outubro":
                case "dezembro":
                    Console.WriteLine("tem 31 dias");
                    break;
                case "abril":
                case "junho":
                case "setembro":
                case "novembro":
                    Console.WriteLine("tem {0} dias", 30);
                    break;
                case "fevereiro":
                    Console.WriteLine("tem {0} ou {1} dias", 28, 29);
                    break;
                default:
                    Console.WriteLine("mês desconhecido");
                    break;
            }
            Console.WriteLine("prima return para continuar");
            Console.ReadKey();
            Console.Clear();




            /*
            //Nivel 7
            //fazer exercicios do nivel!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 





            Console.WriteLine("\nXXXXX Slide 12 - seleção if-else");
            if (str == "fevereiro")
            {
                // se tiver mais de uma instrução temos de 
                //criar um bloco com chavetas
                Console.WriteLine("tem {0} dias", 28);
                Console.WriteLine("Se o bloco da cláusula" +
                    "\ntiver duas ou mais instruções" +
                    "\n temos de as agrupar num bloco");
            }
            else if ((str == "abril") || (str == "junho") || (str == "setembro") || (str == "novembro"))
                // se a intrução for simples não precisa de chavetas
                Console.WriteLine("tem {0} dias", 30);
            else
                Console.WriteLine("tem {0} dias", 31);
            Console.WriteLine("prima return para continuar");
            Console.ReadKey();
            //Nivel 8
            Console.WriteLine("\nXXXXX slide 13 - Quando usar qual delas?");
                    Console.WriteLine("\nOperador condicional ?" +
                        "\n Sempre que o resultado da avaliação seja atribuível a " +
                        "\n a uma variável e facilite a leitura." +
                        "\n\nSwitch" +
                        "\n Quando str for uma String ou um enumerável." +
                        "\n\nif /else" +
                        "\n Quando não pudermos usar os dois anteriores");
                    Console.WriteLine("\nprima return para continuar");
                    Console.ReadKey();
            Console.WriteLine("Mais eficiente, usamos sempre que possível" +
                 "\nInfelizmente só podemos usá-la para iterar coleções");
            string str1 = "abcdefgh";
            // ler para cada char chamado s no código abaixo
            // existente na coleção str1
            // execute o código do bloco abaixo
            foreach (char s in str1)
            {
                Console.Write(" {0}-", s);
                Console.Write(" {0}-", s + 1);
            }*/

        }
    }
}
