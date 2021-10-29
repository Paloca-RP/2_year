using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02_POO
{
    class Ponto : IMovimentavel
    {
        // Atributos ou campos 
        //... sempre privados camelCase
        private int x, y; 

        // Acessores e modificadores
        public int getX() { return x; }
        public void setX(int x) { this.x = x; }
        public int getY() { return y; }
        public void setY(int y) { this.y = y; }

        // CONSTRUTORES:
        // REGRA 1 - Só escrevemos código no construtor
        // com mais parâmetros
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // REGRA 2 - Todos os restantes construtores
        // invocam o construtor com valores por defeito
        // para cada parâmetro
        public Ponto() : this(0,0){ }
        public Ponto(int x) : this(x, 0) { }

        // Porque é que não podemos criar um segundo construtor ?
        // public Ponto(int y) : this(0, y) { }

        // por vezes tal não é possível ...
        public Ponto (char coordenada, int valor)
        {
            if (coordenada == 'x') {
                this.x = valor;
                this.y = 0;
            }
            else
            {
                this.x = 0;
                this.y = valor;
            }
        }

        public void Movimentar (int dx, int dy)
        {
            x += dx;
            y += dy;
        }

        new public String ToString()
        {
            return "(" + x + "," + y +")";
        }
    }
}
