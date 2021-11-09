using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB01_PV201617 
{
    // Nivel 6
    class Reta : Figura
    {
        private int x2, y2;

        public Reta()
        {
            x2 = 1;
            y2 = 1;
        }

        public Reta(int x1, int y1, int x2, int y2) : base(x1,y1)
        {
            this.x2 = x2;
            this.y2 = y2;
        }

        public int X2 { get { return x2; } set { x2 = value; } }
        public int Y2 { get { return y2; } set { y2 = value; } }


       

        public double Area
        {
            get
            {
                Console.WriteLine("throw new NotImplementedException();");
                return 0.0;
            }
        }

        public override void Mover(int dx, int dy)
        {
            base.Mover(dx, dy);
            x2 += dx;
            y2 += dy;
        }

        public override string ToString()
        {
            return base.ToString() + " - (" + x2 + "," + y2 + ")";
        }
    }
}
