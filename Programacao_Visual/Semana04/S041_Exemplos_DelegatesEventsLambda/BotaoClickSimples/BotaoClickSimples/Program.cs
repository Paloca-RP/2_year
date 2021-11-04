using System;

namespace BotaoClickSimples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mensagem msg = new Mensagem();
            msg.Texto = "Uma mensagem";

            Botao botao = new Botao();

            botao.Click += Ola;
            botao.Click += msg.Mostrar;
            botao.Click += Adeus;

            botao.Carregar();

            Console.ReadLine();
        }

        public static void Ola()
        {
            Console.WriteLine("Ola");
        }

        public static void Adeus()
        {
            Console.WriteLine("Adeus");
        }
    }
}
