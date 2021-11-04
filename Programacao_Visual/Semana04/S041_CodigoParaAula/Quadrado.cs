using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03_CSharp

{
    // Relação de HERANÇA entre classes
    // Uma (sub)classe HERDA de uma (super)classe (ou classe base)
    // Uma classe É outra classe
    // Quadrado HERDA de Rectangulo
    // Um Quadrado É Um Retangulo
    class Quadrado : Rectangulo
    {

        public Quadrado(Ponto p, int lado) : base(p, lado, lado)
        {
        }
    }
}
