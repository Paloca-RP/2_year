using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS03_RP
{
    abstract class Figura_RP : IMovimentavel_RP, IRedimensionável_RP
    {
        private int coordenadaX_RP;
        private int coordenadaY_RP;

        public Figura_RP(int x, int y)
        {
            this.coordenadaX_RP = x;
            this.coordenadaY_RP = y;
        }

        public int GetCoordenadaX_RP()
        {
            return this.coordenadaX_RP;
        }
        public int GetCoordenadaY_RP()
        {
            return this.coordenadaY_RP;
        }

        public void Mover_RP(int dx, int dy)
        {
            this.coordenadaX_RP = dx;
            this.coordenadaY_RP = dy;
        }

        public abstract float GetArea_RP();

        public abstract void Redimensionar_RP(int valor);
    }
}
