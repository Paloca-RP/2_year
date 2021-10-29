using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02_POO
{
    // Interfaces são listas/conjuntos/coleções
    // de métodos públicos e abstratos por definição
    interface IMovimentavel
    {
        // um Método abstrato não tem corpo {}
        // um método abstrato é apenas a declaração do método
        void Movimentar(int dx, int dy);

        // Movimentar é public e abstrato por definição!!
    }
}
