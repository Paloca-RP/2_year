using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02_POO
{
    // Relação de HERANÇA entre classes
    // Uma (sub)classe HERDA de uma (super)classe (ou classe base)
    // Uma classe É outra classe
    // Quadrado HERDA de Rectangulo
    // Um Retangulo É Uma FiguraGeometrica 
    class Rectangulo : FiguraGeometrica
    {
        private int largura, altura; // Atributos ou campos ... sempre privados camelCase

        public int getLargura() { return largura; }
        public void setLargura(int largura) { this.largura = altura; }

        // Só o contrutor com mais parâmetros possui código
        public Rectangulo(Ponto p, int largura, int altura) : base (p)
        {
            this.largura = largura;
            this.altura = altura;
        }

        // Todos os restantes construtores invocam/executam o construtor com mais parâmetros
        public Rectangulo() : this(new Ponto(), 0,0){ }

        // Tenho de redefinir o ToSTring de FiguraGeometrica
        // porque o de Rectangulo é diferente
        override public String ToString()
        {
            return base.ToString() + " ["+ largura + "|" + altura + "]";
        }

       // Não preciso de redefinir o Movimentar porque
       // é semelhante ao de FiguraGeometrica

        // Para não ser abstrata
        // Retangulo TEM DE IMPLEMENTAR
        // o método Ampliar
        //override public void Ampliar(int factor)
        //{
        //    largura *= factor;
        //    altura *= factor;
        //}
    }
}
