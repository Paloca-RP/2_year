using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S051_TutorialColecoes_RP
{
    class CartaoDoCidadao_RP
    {
        public string Numero { get; set; }
        public DateTime DataValidade { get; set; }

        public CartaoDoCidadao_RP(string numero, DateTime dataValidade)
        {
            this.Numero = numero;
            this.DataValidade = dataValidade;
        }

        public override string ToString()
        {
            return this.Numero + " - " + this.DataValidade.Year + "/" + this.DataValidade.Month;
        }
    }
}
