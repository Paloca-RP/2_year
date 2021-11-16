using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S051_TutorialColecoes_RP
{
    class Autor_RP
    {
        public string Nome_RP { get; set; }
        public string LinguaOriginal_RP { get; set; }

        public Autor_RP(string nome, string lingua)
        {
            this.Nome_RP = nome;
            this.LinguaOriginal_RP = lingua;
        }

        public override string ToString()
        {
            return "Nome: " + this.Nome_RP + " | Língua Original: " + this.LinguaOriginal_RP;
        }
    }
}
