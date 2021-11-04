using System;

namespace BotaoClickSimples
{
    public class Mensagem
    {
        public string Texto { get; set; }

        public void Mostrar()
        {
            Console.WriteLine(Texto);
        }
    }
}