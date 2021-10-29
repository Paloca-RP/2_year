using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02_POO
{
    // Uma classe asbtrata é uma classe que não pode ser instanciada
    // da qual não podemos criar objetos
    // serve para agregar código numa super classe da qual nunca existirão objetos
    //abstract
    class FiguraGeometrica : IMovimentavel
    {
        // RELAÇÃO DE COMPOSIÇÂO ENTRE CLASSES
        // uma classe TEM um objeto de outra classe
        // uma classe É COMPOSTA pr objetos de outras classes
        // A Classe FiguraGeometrica É COMPOSTA por um Ponto
        private Ponto origem;
        public Ponto getOrigem() { return origem; }
        public void setOrigem(Ponto novaOrigem) { origem = novaOrigem; }


        public FiguraGeometrica(Ponto origem)
        {
            this.origem = origem;
        }

        public FiguraGeometrica() : this (new Ponto()) { }

        virtual
        public void Movimentar(int dx, int dy)
        {
            origem.Movimentar(dx, dy);
        }

        public override string ToString()
        {
            return origem.ToString();
        }

        //abstract public void Ampliar(int factor);
    }
}
