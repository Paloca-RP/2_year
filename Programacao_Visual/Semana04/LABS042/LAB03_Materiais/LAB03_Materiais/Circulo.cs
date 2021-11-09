using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB01_PV201617
{
    // Nivel 1
    public class Circulo : Figura
    {
        private int raio;

        public Circulo()
        {
            raio = 1;
        }

        public Circulo(int raio)
        {
            this.raio = raio;
        }

        public Circulo(int x, int y, int raio)
            : base(x, y)
        {
            this.raio = raio;
        }

        public int Raio { get { return raio; } set { raio = value; } }

        // Nivel 2
        

        public double Area { get { return Math.PI * this.raio * this.raio; } }

        // Nivel 2
        public override string ToString()
        {
            return base.ToString() + " R=" + raio;
        }

    }
}
