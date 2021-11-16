using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S051_TutorialColecoes_RP
{
    class FiguraGeometrica_RP
    {
        public Ponto_RP Ponto_RP { get; set; }

        public FiguraGeometrica_RP(Ponto_RP ponto_RP)
        {
            this.Ponto_RP = ponto_RP;
        }

        public override string ToString()
        {
            return this.Ponto_RP.ToString();
        }
    }
}
