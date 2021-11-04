using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03_CSharp
{
    abstract public class FiguraGeometrica : IMovimentavel
    {
        // As Propriedade uniformizam o acesso a métodos e atributos
        // mantendo o encapsulamento de dados
        // uma propriedade com atributo explicito
        private Ponto origem;
        public Ponto Origem {
            get { return origem; }
            set { origem = value; }
        }

        // As Propriedades podem ser declaradas abstract:
        // A propriedades podem ser só de leitura ou só de escrita ...
        abstract public int Area { get;}

        public FiguraGeometrica(Ponto origem)
        {
            // Usamos a propriedade
            Origem = origem;
        }

        public FiguraGeometrica() : this (new Ponto()) { }

        virtual
        public void Movimentar(int dx, int dy)
        {
            Origem.Movimentar(dx, dy);
        }

        public override string ToString()
        {
            return Origem.ToString();
        }

        abstract public void Ampliar(int factor);
        
    }
}
