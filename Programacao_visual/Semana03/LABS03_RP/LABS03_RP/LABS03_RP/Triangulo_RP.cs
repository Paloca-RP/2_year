using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS03_RP
{
    class Triangulo_RP : Figura_RP, IRedimensionável_RP
    {
        private float base_RP;
        private float altura_RP;
        public Triangulo_RP(int x, int y, float RPse_, float altura) : base(x, y)
        {
            this.base_RP = RPse_;
            this.altura_RP = altura;
        }

        public float GetAltura_RP()
        {
            return this.altura_RP;
        }
        public float Getbase_RP()
        {
            return this.base_RP;
        }

        override public float GetArea_RP()
        {
            return (this.Getbase_RP() * this.GetAltura_RP()) / 2;
        }

        override public string ToString()
        {
            return "Tipo: Triangulo; Coordenada X: " + base.GetCoordenadaX_RP() + "; Coordenada Y: " + base.GetCoordenadaY_RP() + "; RPse: " + this.Getbase_RP() + "; Altura: " + this.GetAltura_RP();
        }

        override public void Redimensionar_RP(int valor)
        {
            this.base_RP += valor; 
            this.altura_RP += valor;
        }
    }
}
