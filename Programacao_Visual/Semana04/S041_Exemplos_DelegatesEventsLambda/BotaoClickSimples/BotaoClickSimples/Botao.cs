namespace BotaoClickSimples
{
    public delegate void MetodoSimples();

    public class Botao
    {
        public event MetodoSimples Click;

        public void Carregar()
        {
            if (Click != null)
                Click();
        }
    }
}