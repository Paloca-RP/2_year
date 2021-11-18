using System;

namespace T1_RicardoPalhoca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nxxxxx Nivel 1 - Classe e objectos");

            CartaoDebito_RP c1 = new CartaoDebito_RP("111111111", (decimal)20.0);
            CartaoDebito_RP c2 = new CartaoDebito_RP();
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());

            Console.WriteLine("\n xxxxxxxx Nivel 2 - Composição");
            Cliente_RP cliente1 = new Cliente_RP("Jorge Aranda", c1);
            Cliente_RP cliente2 = new Cliente_RP();
            Console.WriteLine(cliente1.ToString());
            Console.WriteLine(cliente2.ToString());

            Console.WriteLine("\n xxxxxxx Nivel 3 - Herança");
            ClienteComCredito_RP CCC1 = new ClienteComCredito_RP((decimal)1000.0, "Jorge ", c1);
            ClienteComCredito_RP CCC2 = new ClienteComCredito_RP();
            Console.WriteLine(CCC1); Console.WriteLine(CCC2);

            Console.WriteLine("\nXXXXX Nível 4 - Listas");

            Agencia_RP agencia1 = new Agencia_RP("Agência das Laranjeiras");
            agencia1.Clientes_RP.Add(CCC1);
            agencia1.Clientes_RP.Add(CCC2);
            Console.WriteLine(agencia1.ToString());
            Console.WriteLine("\nxxxxxxxx Nivel 5 - Enumerados");
            var dia1 = (Balcao_RP)1;
            var dia2 = (Balcao_RP)2;
            var dia3 = (Balcao_RP)3;
            var dia4 = (Balcao_RP)4;

            Console.WriteLine(dia1 + " - " + dia2 + " - " + dia3 + " - " + dia4);


        }
    }
}
