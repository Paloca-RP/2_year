using System;
using System.Collections.Generic;
using System.Text;

namespace TP03_CSharp
{

   

    public class Desenho
    {
        
        private int qtdFigurasNoDesenho;
        private int tamanhoDoDesenho;

        private FiguraGeometrica[] desenho;

        // XXXXXXXXX Slide 12 - Indexers
        // Indexers - permitem aceder a UM  array no interior da classe
        // pelo nome do objeto ...
        public FiguraGeometrica this[int index]
        {
            get { return desenho[index]; }
            set { desenho[index] = value; }
        }

        public Desenho(int tamanhoDoDesenho)
        {
            this.tamanhoDoDesenho = tamanhoDoDesenho;
            desenho = new FiguraGeometrica[this.tamanhoDoDesenho];
            qtdFigurasNoDesenho = 0; //0-2
        }

        public void AdicionarFigura(FiguraGeometrica fg)
        {
            if (qtdFigurasNoDesenho < tamanhoDoDesenho)
            {
                desenho[qtdFigurasNoDesenho] = fg;
            }
            else
            {
                tamanhoDoDesenho *= 2; // 4
                FiguraGeometrica[] tmp = new FiguraGeometrica[tamanhoDoDesenho];
                for (int i =0; i<qtdFigurasNoDesenho; i++)
                {
                    tmp[i] = desenho[i];
                }
                tmp[qtdFigurasNoDesenho] = fg;
                desenho = tmp;
            }
            qtdFigurasNoDesenho++;
        }

        override
        public String ToString()
        {
            String str = "";
            for (int i=0; i<qtdFigurasNoDesenho; i++)
                str += desenho[i].ToString() + "\n";
            return str;
        }

       
        
        // XXXXXXXXXXXXXXXXXXXXXXXXXX
        // DELEGATES
        // 3. No método onde pretendermos 
        // 	lançar o evento verificamos 
        // 	se este está a null e disparamo-lo
        public void MoveX(int x)
        {
            foreach (FiguraGeometrica fg in desenho)
                fg.Movimentar(x, 0);
            if (OnMoved != null)
                OnMoved();
        }

        // XXXXXXXXXXXXXXXXXXXXXXXXXX
        // DELEGATES
        // 2. Na classe declarar um evento desse tipo de delegate
        public event Metodo OnMoved;
        // o meu evento chama-se OnMoved não retorna nada e não aceita parametros
        // uma vez que é do tipo Metodo

    }

    // XXXXXXXXXXXXXXXXXXXXXXXXXX
    // DELEGATES - funcionam como Tipos de Métodos
    // Funcionam como um tipo que define um determinado Tipo de Método
    // As variaveis destes tipos guardam referências de métodos
    // a sua utilização passa por 5 (CINCO!) etapas
    // três 3 para definir e duas 2 para usar
    // DEFINICAO
    // 1. no namespace definir um delegate 
    public delegate void Metodo();
    // todos os métodos que retornem void e não aceitem parametros

}
