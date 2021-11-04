using System;
using System.Collections.Generic;

namespace TP03_CSharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("XXXXXXXXX SLIDE 4 Membros de Classe - keyword static");
            Ponto p1 = new Ponto(1, 2);
            Console.WriteLine("// Fora da classe invocamos um método de classe (static)");
            Console.WriteLine("// com o NomeDaClasse.NomeDoMetodo()");
            Console.WriteLine("qtd pontos criados: " + Ponto.GetPontosCriados());
            Ponto p2 = new Ponto(2, 3);
            Console.WriteLine("qtd pontos criados: " + Ponto.GetPontosCriados());
            Console.WriteLine("Com static consegue contar os pontos criados, sem static não ... porquê?");
            Console.WriteLine("Prima uma tecla para continuar :> ");

            //Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXX SLIDE 5 Constantes - keyword const");
            Console.WriteLine("Ponto.Pi= " + Ponto.PI);
            // Console.WriteLine("Pi=" + p1.PI); ERRO - é de classe
            // Console.WriteLine("Pi=" + Ponto.Pi++); ERRO não pode ser alterada
            Console.WriteLine("Refere-se à constante PI antecedendo-a do nome da classe e não de um objeto ... porquê?");
            Console.WriteLine("Prima uma tecla para continuar :> ");

            //Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXX SLIDE 6 Não alteráveis - keyword readonly");
            Ponto p3 = new Ponto(3, 4, 3.1416);
            Console.WriteLine("p3.OutroPi= " + p3.OutroPi);
            Ponto p4 = new Ponto(4, 5, 3.1415926);
            Console.WriteLine("p4.OutroPi= " + p4.OutroPi);
            // Console.WriteLine("Pi=" + Ponto.Pi++); ERRO não pode ser alterada
            Console.WriteLine("em p3 OutroPi tem um valor e em P4 tem outro valor ... porquê?");
            Console.WriteLine("Prima uma tecla para continuar :> ");

            //Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXX SLIDE 7 Propriedades");
            Console.WriteLine("Acesso transparente: p1.X = " + p1.X);
            Console.WriteLine("Escrita transparente: p1.X = " + (p1.X = 10));
            Console.WriteLine("Prima uma tecla para continuar :> ");

            //Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXX SLIDE 9 - Propriedades só de leitura ou só de escrita");
            FiguraGeometrica f1 = new Rectangulo(p1, 2, 3);
            Console.WriteLine("f1.Area =" + f1.Area);
            Rectangulo r1 = new Rectangulo(p1, 3, 4);
            Console.WriteLine("            r1= " + r1.ToString());
            r1.NovaPosicao = new Ponto(11, 22);
            Console.WriteLine("r1.NovaPosicao= " + r1.ToString());
            Console.WriteLine("Prima uma tecla para continuar :> ");

            //Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXX SLIDE 11 - Inicialização de Propriedades na criação do objeto");
            // Inicialização de propriedades 
            // na construção do objeto
            Ponto p6 = new Ponto() { X = 5, Y = 6 };
            Ponto p7 = new Ponto() { X = 7 };
            Console.WriteLine(p6);
            Console.WriteLine(p7);
            Console.WriteLine("Prima uma tecla para continuar :> ");

            //Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXX SLIDE 12 - Indexers - indexadores");
            Rectangulo r2 = new Rectangulo(p2, 22, 33);
            Rectangulo r3 = new Rectangulo(p3, 33, 44);
            Rectangulo r4 = new Rectangulo(p4, 44, 55);
            Desenho d1 = new Desenho(2);
            d1.AdicionarFigura(r1);
            d1.AdicionarFigura(r2);
            d1.AdicionarFigura(r3);
            d1.AdicionarFigura(r4);
            Console.WriteLine("d1[1] = " + d1[1]);

            for (int p = 0; p < 4; p++)
                Console.WriteLine("d1[" + p + "] = " + d1[p]);
            Console.WriteLine("Sem indexadores como é que acederia a cada elemento p do array?");
            Console.WriteLine("Prima uma tecla para continuar :> ");

            Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXX SLIDES 14 e 15- delegates");
            Console.WriteLine("** Um tipo de métodos define " +
                "\n**   todos os métodos com o mesmo tipo de retorno " +
                "\n**   e a mesma lista de parametros");
            Console.WriteLine("** Podemos dizer que um delegate define" +
                "\n**   um tipo de métodos." +
                "\n** Permite passar referências para métodos " +
                "\n**   como parâmetros de métodos.");

            Console.ReadKey();
            Console.WriteLine("XXXXXXXXX SLIDE 16 - Delegates com templates Func e Action");
            Console.WriteLine("// XXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("// DELEGATES on .NET 5.0");
            Console.WriteLine("// Func e Action São tipos delegate genéricos.");
            Console.WriteLine("// Existem 16x2 diferentes tipos de delegates(de 0 a 15 parâmetros)");
            Console.WriteLine("// 1. declaramos o delegate como sendo de um dos templates");
            Console.WriteLine("// 2. criamo-lo (na mesma instrução) com uma lambda expression");
            Console.WriteLine("// 3. usamo-lo como nos .NET core anteriores (ver slides 27 a 33)");

            // Declaramos o nosso delegate como sendo do tipo Func ou Action parametrizado para os nossos tipos e
            Func<int, int, int> add =   //1 declaração c/ template
                                        // Criamo - los como lambda expressions
                 (firstNumber, secondNumber) => { return firstNumber + secondNumber; }; //2 criação c/ lambda expression

            // invocamos o delegate com parametros reais
            Console.WriteLine(add(1, 2));

            Action<string, string> change = // 1.declaração do delegate
                (roomOrigin, roomDestiny) => { roomDestiny = roomDestiny != roomOrigin ? roomOrigin : "No Room"; };

            string room1 = "A260";
            string room2 = "E205";
            Console.WriteLine("Note que change é um método e que os parametros são passados por valor ;-)");
            change(room1, room2);
            Console.WriteLine("ROriginal: " + room1 + " RDestino: " + room2);
            Console.WriteLine("Compreendeu porque é que não trocou? De certeza?");
            change(room1, room2);
            Console.WriteLine("ROriginal: " + room1 + " RDestino: " + room2);

            Console.WriteLine("Teriamos de trocar as salas");
            room2 = room2 != room1 ? room1 : "No Room";
            Console.WriteLine("ROriginal: " + room1 + " RDestino: " + room2);
            Console.WriteLine("Mas podemos verificar se foram trocadas");
            Action<string, string> isChanged = // 1.declaração do delegate
               (roomOrigin, roomDestiny) => { Console.WriteLine(roomDestiny != roomOrigin ? roomOrigin : "Same room"); };
            isChanged(room1, room2);

            Console.WriteLine("\nXXXXXXXXX INVOCAÇÃO DE MÈTODOS QUE" +
                "\nXXXXXXXXX ACEITAM UM MÉTODO COMO ARGUMENTO");
            umMetodoQueAceitaUmDelegate(MetodoParaODelegate);
            umMetodoQueAceitaUmDelegate(OutroMetodoParaOMesmoDelegate);

            Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXX SLIDE 17 - Funções anónimas");
            Console.WriteLine("** Uma Função Anónima é uma instrução " +
                "\n**   ou expressão “inline” que pode ser usada" +
                "\n**   sempre que seja esperado um tipo delegate.");
            Console.WriteLine("** Pode ser usada para inicializar " +
                "\n**   um determinado delegate");
            Console.WriteLine("** Ou ser passada como parâmetro " +
                "\n**  de um método em lugar de um determinado delegate.");
            Console.WriteLine("** Há dois tipos de funções anónimas");
            Console.WriteLine("**     - Métodos anónimos");
            Console.WriteLine("**     - Expressões Lambda");

            Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXX SLIDE 18 - Métodos anónimos");
            Console.WriteLine("** Método anónimo é uma instrução sem nome associado.");
            Console.WriteLine("** Para definir métodos anónimos:");
            Console.WriteLine("** 1.Usa - se o operador delegate");
            Console.WriteLine("** 2.Seguido da lista de parâmetros");
            Console.WriteLine("** e do código { definição do método}.");
            Console.WriteLine("** No exemplo em vez de adicionar ao evento" +
                "\n**    um método de um objeto" +
                "\n**    ou um método incluído na classe onde está o código " +
                "\n**    fornece-se diretamente o método com parâmetros e código.");
            Console.WriteLine("** Quando usamos o operador delegate " +
                "\n**   podemos omitir a lista de parâmetros, " +
                "\n**   caso em que o método anónimo assim criado " +
                "\n**   pode ser convertido para um tipo delegado " +
                "\n**   com qualquer lista de parâmetros" +
                "\n** Esta é a única funcionalidade não suportada " +
                "\n** por expressões lambda");

            // até ao C# 3 -> ver delegate p/ slide 18
            // declarado depois do método Main
            priceWithProfit percentMargin50 = delegate (decimal price)
            {
                decimal profit = 0.5M * price;
                Console.WriteLine("price with Profit: " + (profit + price));
            };

            // No C# 3.0 e superior
            Action<decimal> margemDeLucro50 = delegate (decimal preco)
            {
                decimal lucro = 0.5M * preco;
                Console.WriteLine("price with Profit: " + (lucro + preco));
            };

            // executa o método anónimo
            percentMargin50(100);
            margemDeLucro50(100);

            Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXX SLIDE 19 - Expressões Lambda");
            Console.WriteLine("** Em C# uma expressão lambda é uma " +
                "\n**    função anónima que pode ser usada para criar delegados.");
            Console.WriteLine("** Para definir expressões lambda:" +
                "\n**    1.Especifica - se a lista de  parâmetros " +
                "\n**    2.Seguida do simbolo =>" +
                "\n**    3.Seguido do código a executar ");
            Action<decimal> percentMargin10EL = (price) =>
            {
                decimal profit = 0.5M * price;
                Console.WriteLine
                ("price with Profit: " +
                (profit + price));
            };

            // executa a expressão Lambda
            percentMargin10EL(100);

            Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXX SLIDE 20 - Variáveis de tipo implicito");
            var val = 25;
            val = 30;
            val = val + 123;
            var car = 'c';
            car = 'd';
            var nomes = new List<string>();

            Console.WriteLine("\nXXXXXXXXX SLIDES 21 - Tipos nullable");
            // TRADICIONAL EM C#
            Nullable<int> i = null;
            if (i.HasValue)
                Console.WriteLine(i.Value);
            //ou (i) 
            else
                Console.WriteLine("Null");
            // SIMPLIFICADA EM C# -> syntatic sugar
            int? j = null;
            if (j.HasValue)
                Console.WriteLine(j.Value);
            //ou (j) 
            else
                Console.WriteLine("Null");

            Console.WriteLine("\nXXXXXXXXX SLIDES 22 - Operador null-coalescing");

            //Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXX SLIDE 23 - Redefinição de operadores");
            Console.WriteLine("p1: " + p1);
            Console.WriteLine("p2: " + p2);
            p3 = p1 + p2;
            Console.WriteLine("p3 = p1 + p2");
            Console.WriteLine("p3 = " + p3);
            Console.WriteLine("Como é que somaria dois pontos sem usar a redefinição de operadores?");
            Console.WriteLine("p1 + p2 = " + p1 + p2);
            Console.WriteLine("Porquê? O que é que está a acontecer?");
            Console.WriteLine("(p1 + p2) = " + (p1 + p2));
            Console.WriteLine("Porquê? O que é que está a acontecer?");
            Console.WriteLine("Prima uma tecla para continuar :> ");

            //Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXX SLIDE 24 - Métodos de Extensão");
            string test = "4.0";
            Console.WriteLine("The String \"" + test + "\" é numérica: " + test.IsNumeric());
            test = "200 anos";
            Console.WriteLine("The String \"" + test + "\" é numérica: " + test.IsNumeric());
            Console.WriteLine("Prima uma tecla para continuar :> ");

            Console.WriteLine("\nXXXXXXXXX SLIDE 29 - events e sua utilização");
            Console.WriteLine("XXXXX INSCRIÇÃO DE MÉTODOS NO EVENT");
            MyEvent += MetodoParaOMyEvent; //
            MyEvent += delegate { Console.WriteLine("Do Método Anónimo só usaremos quando não tivermos argumentos"); };
            MyEvent += (x, y) => { Console.WriteLine("Da Expressao Lambda direitinha ao event: " + x + y); };
            Console.WriteLine("XXXXX A partir do C# 9 podemos usar _ " +
                "\nXX  para especificar que a lamba expression não" +
                "\nXX usa determinado parametro" +
                "\nXX pelo que a utilização demétodos anónimos deixa de fazer sentido");
            MyEvent += (x_, y_) => { Console.WriteLine("De outra Lambda Exp. sem argumentos"); };

            Console.WriteLine("XXXXX DISPARO SEGURO DO EVENT" +
                "\nXX Verifica se o event é null antes de disparar");
            MyEvent?.Invoke(12, 12); ;

            Console.WriteLine("XXXXX INSCRIÇÃO E REMOÇÃO de Event" +
                "\nXX com add remove explicito." +
                "\nXX raramente temos de os definir" +
                "\nXX sobre a sua utilização ver" +
                "\nXX https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-implement-interface-events");
            MyEventComAddERemove += MetodoParaOMyEvent; 
            MyEventComAddERemove += delegate { Console.WriteLine("Do Método Anónimo só usaremos quando não tivermos argumentos"); };
            MyEventComAddERemove += (x, y) => { Console.WriteLine("Da Expressao Lambda direitinha ao event: " + x + y); };
            MyEventComAddERemove -= MetodoParaOMyEvent;
        }// fim do main

        // XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        // NOTE COMO PASSAMOS UMA REFERENCIA PARA UM MÉTODO (de um tipo delegate)
        // COMO ARGUMENTO/PARÂMETRO para o método:
        // delegate usado como tipo do parâmetro do método
        public delegate int AceitaDoubleRetornaInt(double umDouble);

        // método que aceita uma referencia para um método como parametro (um delegate)
        public static void umMetodoQueAceitaUmDelegate(AceitaDoubleRetornaInt metodo)
        {
            Console.WriteLine(metodo(123.456));
        }

        // métodos do tipo do delegate AceitaDoubleRetornaInt
        public static int MetodoParaODelegate(double valor)
        {
            return (int)Math.Ceiling(valor);
        }
        public static int OutroMetodoParaOMesmoDelegate(double valor)
        {
            return (int)(Math.Floor(valor));
        }

        //XXXXXXXXXXXXXXXXXXXXXXXXX
        // delegate para o slide 18
        public delegate void priceWithProfit(decimal price);

        // XXXXXXXXXXXXXXXXXXXXXXXX
        // event(os) para o slide 29
        static public event Action<int, int> MyEvent;

        static public void MetodoParaOMyEvent(int x, int y)
        {
            Console.WriteLine("Do método tradicional: " + x + "_" + y);
        }

        // XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        // Ilstração de um event com add/remove explicito
        // note que não consegue disparar este event
        // apenas adicionar e remover delegates
        static public event Action<int, int> MyEventComAddERemove
        {
            add
            {
                
                Console.WriteLine("Foi adicionado um delegate ao evento");
            }
            remove
            {
                Console.WriteLine("Foi removido do evento um delegate ");
            }
        }

    }

}
