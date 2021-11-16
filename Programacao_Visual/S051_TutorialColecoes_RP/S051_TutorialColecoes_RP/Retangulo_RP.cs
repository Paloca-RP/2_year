using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S051_TutorialColecoes_RP
{
    class Retangulo_RP : FiguraGeometrica_RP
    {
        public int Lado { get; set; }

        public Retangulo_RP(Ponto_RP ponto, int lado) : base(ponto)
        {
            this.Lado = lado;
        }

        public override string ToString()
        {
            return base.ToString() + " Lado: " + this.Lado;
        }
    }
}
