using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S051_TutorialColecoes_RP
{
    class Ponto_RP
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Ponto_RP(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return "(" + this.X + "," + this.Y + ")";
        }
    }
}
