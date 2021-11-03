using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS03_RP
{
    class Retangulo_RP : Figura_RP, IRedimensionável_RP
    {
        private float largura_RP;
        private float altura_RP;

        public Retangulo_RP(int x, int y, float altura, float largura) : base(x , y )
        {
            this.largura_RP = largura;
            this.altura_RP = altura;
        }

        public float GetAltura_RP()
        {
            return this.altura_RP;
        }
        public float GetLargura_RP()
        {
            return this.largura_RP;
        }

        override public float GetArea_RP()
        {
            return this.GetAltura_RP() * this.GetLargura_RP();
        }

        override public string ToString()
        {
            return "Tipo:: Retangulo; Coordenada X: " + base.GetCoordenadaX_RP() + "; Coordenada Y: " + base.GetCoordenadaY_RP() + "; Altura: " + this.GetAltura_RP() + "; Largura: " + this.GetLargura_RP();
        }

        override public void Redimensionar_RP(int valor)
        {
            this.largura_RP += valor;
            this.altura_RP += valor;
        }
    }
}
