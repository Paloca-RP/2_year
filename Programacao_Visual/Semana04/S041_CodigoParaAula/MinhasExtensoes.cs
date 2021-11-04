using System;
using System.Collections.Generic;
using System.Text;

namespace TP03_CSharp
{
    // XXXXXXXXXXXXXXXXXXXXXXXXXX
    // Exemplo da extensão da classe String (selada!)
    // com um método para verifdicar se a string é numérica
    // 1. Criar uma classe estática onde será definido o método de extensão (ou usar uma existente). 

    public static class  MinhasExtensoes
    {
        // 2. Definir um método de classe (static)
        public static bool IsNumeric(this String s)
        // 3. Colocar como primeiro parâmetro do método o nome da classe 
        // à qual se está a acrescentar o método (String) 
        // antecedido pela palavra reservada this. 
        // A palavra reservada this só pode ser aplicada ao primeiro parâmetro.
        {
            float output;
            return float.TryParse(s, out output); // note-se o uso de out para
                                                 // fazer sair um valor de uma variável
                                                 // que só foi inicializada
                                                 // dentro do método TryParse
        }
    }
}
