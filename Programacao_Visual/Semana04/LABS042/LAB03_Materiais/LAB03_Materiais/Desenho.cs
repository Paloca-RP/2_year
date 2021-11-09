using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB01_PV201617
{
    // Nivel 3
    public class Desenho : IMovimentavel  // IMover - Nivel 4
    {
        private Figura[] figuras;
        public int numeroFiguras;
        private const int NUMEROMAXIMOFIGURAS = 100;

        public Desenho()
        {
            figuras = new Figura[NUMEROMAXIMOFIGURAS];
            numeroFiguras = 0;
        }

        public void AdicionarFigura(Figura figura)
        {
            if (numeroFiguras <= NUMEROMAXIMOFIGURAS)
                figuras[numeroFiguras++] = figura;
        }

        public int NumeroFiguras { get; set; }

        // Nivel 4
        public void Mover(int dx, int dy)
        {
            for (int i = 0; i < numeroFiguras; i++)
                figuras[i].Mover(dx, dy);
        }


        // Nivel 3
        public override string ToString()
        {
            string txt = "";

            txt += "Desenho:";
            for (int i = 0; i < numeroFiguras; i++)
                txt += "\nfig" + i + " - " + figuras[i].ToString();
            return txt;
        }


        //Nivel 5
        public double Area
        { 
            get
            {
                double area = 0.0;
                for (int i = 0; i < numeroFiguras; i++)
                    area += figuras[i].Area;
                return area;
            }
        }


    // Nivel 5
    public void RemoverFigura(int indice)
        {
            if (indice >= 0 && indice < numeroFiguras)
            {
                for (int i = indice; i < numeroFiguras - 1; i++)
                    figuras[indice] = figuras[indice + 1];
                numeroFiguras--;
            }
        }
    }
}
