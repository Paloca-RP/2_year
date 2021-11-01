using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS03_RP
{
    class Quadrado_RP : Retangulo_RP
    {
        private float lado_RP;

        public Quadrado_RP(int x, int y, float lado) : base(x , y , lado, lado)
        {
            this.lado_RP = lado;
        }

        public float GetLado_RP()
        {
            return this.lado_RP;
        }

        override public string ToString()
        {
            return "Tipo: Quadrado; Coordenada X: " + base.GetCoordenadaX_RP() + "; Coordenada Y: " + base.GetCoordenadaY_RP() + "; Lado: " + this.GetLado_RP();
        }

        override public float GetArea_RP()
        {
            return this.GetLado_RP() * this.GetLado_RP();
        }

        override public void Redimensionar_RP(int valor)
        {
            this.lado_RP += valor;
        }

    }
}
