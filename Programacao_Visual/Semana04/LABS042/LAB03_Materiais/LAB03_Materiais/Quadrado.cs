using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB01_PV201617
{
    // Nivel 1
    public class Quadrado : Figura
    {
        private int lado;

        public Quadrado()
        {
            lado = 1;
        }

        public Quadrado(int lado)
        {
            this.lado = lado;
        }

        public Quadrado(int x, int y, int lado)
            : base(x, y)
        {
            this.lado = lado;
        }

        public int Lado { get { return lado; } set { lado = value; } }

        // Nivel 2
        public double Area
        {
            get { return this.Lado * this.Lado; }
        }

        // Nivel 2
        public override string ToString()
        {
            return base.ToString() + " L=" + lado;
        }
    }
}
