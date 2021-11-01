using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS03_RP
{
    class Círculo_RP : Figura_RP, IRedimensionável_RP
    {
        private float raio_RP;

        public Círculo_RP(int x, int y, float raio) : base(x , y )
        {
            this.raio_RP = raio;
        }

        public float GetRaio_RP()
        {
            return this.raio_RP;
        }

        override public string ToString()
        {
            return "Tipo: Círculo; Coordenada X: " + base.GetCoordenadaX_RP() + "; Coordenada Y: " + base.GetCoordenadaY_RP() + "; Raio: " + this.GetRaio_RP();
        }

        override public float GetArea_RP()
        {
            return 3.14f * (this.GetRaio_RP() * this.GetRaio_RP());
        }

        override public void Redimensionar_RP(int valor)
        {
            this.raio_RP += valor;
        }
    }
}
