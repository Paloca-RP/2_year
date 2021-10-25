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
            /*Nivel 2*/
            Console.WriteLine("Hello World!");
           
            Console.WriteLine("Prima return para continuar");
            Console.ReadKey();
            Console.Clear();

            /*Nivel 3*/
            Console.WriteLine("\nXXXXX - Tipos de Dados - Slide 7" +
                "\n\nUm tipo de dados define um conjunto de valores e as" +
                "\noperações que podemos executar com esses valores");
            Console.WriteLine("\nprima return para continuar");
            Console.ReadKey();
            Console.Clear();

            /*Nivel 4 A*/
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

            /*Nivel 4B*/
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

            /*Nivel 4C*/
            int variavel1, tmp, variavel2 = 2;
            variavel1 = 1;

            tmp = variavel1;
            variavel1 = variavel2;
            variavel2 = tmp;

            Console.WriteLine("XXXXX – slide 9 - Instruções e operadores de atribuição");
            Console.WriteLine("variável 1 = " + variavel1 + "\n" +
               "variável 2 = " + variavel2 + "\n");
        }
    }
}
