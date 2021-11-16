using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT1REC_RicardoPalhoca
{
    class Serie_RP : Livro_RP
    {
        public string TituloDaSerie_RP { get; set; }

        public Serie_RP(string tituloDaSerie_RP,
            string titulo_RP, 
            int stock_RP, 
            Auto_RP autor_RP) : base (stock_RP, titulo_RP,autor_RP )
        {
            TituloDaSerie_RP = tituloDaSerie_RP;    
        }

        public Serie_RP() : this("Sem titulo de Serie", "Sem Titulo", 0, new Auto_RP())
        {

        }

        public override string ToString()
        {
            return TituloDaSerie_RP + "***** \n\t" + base.ToString();
        }
    }
}
