using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03_CSharp
{
    public class Ponto : IMovimentavel
    {
        // XXXX Slide 4
        // Atributo e método de Classe
        // Antecedido pela keyword static
        // Só existe um para todos os objetos da classe
        private static int pontosCriados;
        public static int GetPontosCriados() { return pontosCriados; }


        // XXXX Slide 5 Constantes - const
        // São de classe por definição
        // não podem ser alteradas
        public const double PI = 3.1415926;

        // XXXX Slide 6 Variáveis não alteráveis - readOnly
        // são de objeto/instância e só podem ser alteradas no construtor
        public readonly double OutroPi = 3.1415;

        // XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        // SLIDE 7 - propriedades
        // Vão substituir os atributos
        // Doravante usaremos Propriedades 
        // em lugar dos atributos + get/set
        // XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

        // As Propriedades são públicas ... PascalCase

        // Uma Propriedade pode ter um atributo
        // explicitamente associado:
        private int x; // experimente o encapsulamento com double x 
        // e dizemos que é
        // Uma Propriedade com um atributo  explicito
        public int X
        {
            get { return x; } // experimente o encapsulamento com { return Convert.ToInt32(x); }
            set { x = value; }
        }
        // Ou ter um atributo implicitamente associado
        // e dizemos que é
        // uma Propriedade com atributo implicito
        public int Y { get; set; }


        public Ponto(int x, int y, double outroPi)
        {
            // Slide 7 Uso de propriedades no objeto
            X = x;
            Y = y;
            // Slide 4 - static - de classe
            pontosCriados++;
            // Slide 6 - readonly - não alteráveis no programa
            // mas inicializaveis no construtor
            OutroPi = outroPi;
        }

        public Ponto(int x, int y) : this(x, y, Math.PI) { }
        public Ponto() : this(0, 0, Math.PI) { }

        public void Movimentar(int dx, int dy)
        {
            X += dx;
            Y += dy;
            // descomente as linhas abaixo
            // surpresa? Como explica?
            //x += dx;
            //y += dy;
        }

        override
        public String ToString()
        {
            return "(" + X + "," + Y + ")";
        }

        // XXXXXXXXXXXXXXXXX
        // Slide 24 - Redefinição de Operadores
        // Permite usar os operadores normais com tipos não elementares 
        // EX:: vamos definir o operador + para somar dois pontos
        // Permite criar conversões entre tipos de dados não convertíveis
        // Declaram-se como métodos normais em que:
        // o identificador é a palavra-chave ‘operator’ seguida do símbolo do operador
        // EX: operator +
        // os argumentos são os operandos usados com esses operadores
        // EX: (Ponto p1, Ponto p2)
        // XXXXXXXXXXXXXXXX
        // Definimos o operador +
        // para somar dois pontos
        public static Ponto operator + (Ponto p1, Ponto p2)
        {
            return new Ponto (p1.X + p2.X, p1.Y + p2.Y);
        }

    }
}
