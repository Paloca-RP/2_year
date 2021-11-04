using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03_CSharp
{
    // Relação de HERANÇA entre classes
    // Uma (sub)classe HERDA de uma (super)classe (ou classe base)
    // Uma classe É outra classe
    // Quadrado HERDA de Rectangulo
    // Um Retangulo É Uma FiguraGeometrica 
    class Rectangulo : FiguraGeometrica
    {
        public int Largura { get; set; }
        public int Altura { get; set; }

        // Rectangulo nãoé Abstract e herda Area de FiguraGeometrica
        // pelo que tem de implementar a propriedade Area ...
        // Só de leitura ;-)
        override public int Area { get { return Altura * Largura; } }
        // ou só de escrita
        public Ponto NovaPosicao { set { base.Origem = value; } }


        // Só o contrutor com mais parâmetros possui código
        public Rectangulo(Ponto p, int largura, int altura) : base (p)
        {
            Largura = largura;
            Altura = altura;
        }

        // Todos os restantes construtores invocam/executam o construtor com mais parâmetros
        public Rectangulo() : this(new Ponto(), 0,0){ }

        // Tenho de redefinir o ToSTring de FiguraGeometrica
        // porque o de Rectangulo é diferente
        override public String ToString()
        {
            return base.ToString() + " ["+ Largura + "|" + Altura + "]";
        }

       // Não preciso de redefinir o Movimentar porque
       // é semelhante ao de FiguraGeometrica

        // Para não ser abstrata
        // Retangulo TEM DE IMPLEMENTAR
        // o método Ampliar
        override public void Ampliar(int factor)
        {
            Largura *= factor;
            Altura *= factor;
        }
    }
}
