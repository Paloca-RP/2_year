using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS03_RP
{
    class Desenho_RP : IMovimentavel_RP, IRedimensionável_RP
    {
        private Figura_RP[] array_RP;
        private int quantidadeFiguras_RP;

        public Desenho_RP(int tamanhoArray)
        {
            this.array_RP = new Figura_RP[tamanhoArray];
            this.quantidadeFiguras_RP = 0;
        }

        public void AdicionarFigura_RP(Figura_RP figura)
        {
            try
            {
                this.array_RP[this.quantidadeFiguras_RP] = figura;
                this.quantidadeFiguras_RP++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        override public string ToString()
        {
            if (this.quantidadeFiguras_RP == 0)
                return "Sem desenho";
            string str = "";
            int aux = -1;
            foreach (Figura_RP figura in this.array_RP)
            {
                aux++;
                if (figura == null)
                    continue;
                str += "Figura (" + aux + "): " + figura.ToString() + "\n";

            }
            return str;
        }

        public void Mover_RP(int dx, int dy)
        {
            if (this.quantidadeFiguras_RP == 0)
            {
                Console.WriteLine("Sem desenho");
                return;
            }
            foreach (Figura_RP figura in this.array_RP)
                figura.Mover_RP(dx, dy);
        }

        public float GetArea_RP()
        {
            if (this.quantidadeFiguras_RP == 0)
                return 0;
            float area = 0;
            foreach (Figura_RP figura in this.array_RP)
            {
                if (figura == null)
                    continue;
                area += figura.GetArea_RP();
            }

            return area;
        }

        public void RemoverFigura_RP(int indice)
        {
            try
            {
                for (int i = indice; i < this.quantidadeFiguras_RP; i++)
                {
                    if (i + 1 != this.quantidadeFiguras_RP)
                        this.array_RP[i] = this.array_RP[i + 1];
                }
                this.array_RP[this.quantidadeFiguras_RP - 1] = null;
                this.quantidadeFiguras_RP--;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Redimensionar_RP(int valor)
        {
            if (this.quantidadeFiguras_RP == 0)
                return;
            foreach (Figura_RP figura in this.array_RP)
            {
                if (figura == null)
                    continue;
                figura.Redimensionar_RP(valor);
            }
        }
    }
}
