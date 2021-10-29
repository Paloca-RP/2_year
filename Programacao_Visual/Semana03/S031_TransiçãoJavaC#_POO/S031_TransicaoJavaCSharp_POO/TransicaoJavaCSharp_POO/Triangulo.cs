using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02_POO
{
    class Triangulo : FiguraGeometrica
    {
        Ponto v2;
        Ponto v3;

        public Triangulo(Ponto v1, Ponto v2, Ponto v3):base(v1)
        {
            this.v2 = v2;
            this.v3 = v3; ;
        }

        public Triangulo() : this(new Ponto(), new Ponto(), new Ponto()) { }

        // Tenho de redefinir o ToSTring de FiguraGeometrica
        // porque o de Triangulo é diferente
        override public String ToString()
        {
            return base.ToString() + v2.ToString() + v3.ToString();
        }

        // Tenho de redefinir o Movimentar de FiguraGeometrica
        // porque o de Triangulo é diferente
        override public void Movimentar(int dx, int dy)
        {
            base.Movimentar(dx, dy);
            v2.Movimentar(dx, dy);
            v3.Movimentar(dx, dy);
        }

        //public override void Ampliar(int factor)
        //{
        //    // Assumindo que os nosso triangulos estão no 1º quadrante
        //    // deslocar para a origem das coordenadas
        //    // não deslocamos a origem porque também não 
        //    // a "ampliamos"
        //    int v2XDeslocado = v2.getX() - getOrigem().getX();
        //    int v2YDeslocado = v2.getY() - getOrigem().getY();
        //    int v3XDeslocado = v3.getX() - getOrigem().getX();
        //    int v3YDeslocado = v3.getY() - getOrigem().getY();

        //    // Multiplica pelo factor de ampliação
        //    int v2XAmpliada = v2XDeslocado * factor;
        //    int v2YAmpliada = v2YDeslocado * factor;
        //    int v3XAmpliada = v3XDeslocado * factor;
        //    int v3YAmpliada = v3YDeslocado * factor;

        //    // desloca para a posição inicial
        //    v2.setX(v2XAmpliada + getOrigem().getX());
        //    v2.setY(v2YAmpliada + getOrigem().getY());
        //    v3.setX(v3XAmpliada + getOrigem().getX());
        //    v3.setY(v3YAmpliada + getOrigem().getY());

        //}


    }
}
