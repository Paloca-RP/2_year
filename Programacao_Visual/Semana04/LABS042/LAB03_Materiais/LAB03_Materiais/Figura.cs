using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB01_PV201617
{
    // Nivel 1
    public abstract class Figura : IMovimentavel  // IMovimentavel - Nivel 4
    {
        private int x, y;

        public Figura()
        {
        }

        public Figura(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }


        // Nivel 2 ou 3
       
        public double Area { get { return 0.0; } }

        // Nivel 2
        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }


        // Nivel 4
        // virtual do Nível 6
        public virtual void Mover(int dx, int dy)
        {
            x += dx;
            y += dy;
        }
    }
}
