using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S051_TutorialColecoes_RP
{
    class Pessoa_RP
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public CartaoDoCidadao_RP CartaoCidadao { get; set; }

        public Pessoa_RP(string nome, DateTime dataNascimento, CartaoDoCidadao_RP cartaoCidadao)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.CartaoCidadao = cartaoCidadao;
        }

        public override string ToString()
        {
            return this.Nome + " - " + this.DataNascimento.Year + "/" + this.DataNascimento.Month + "/" + this.DataNascimento.Day + " - " + this.CartaoCidadao;
        }
    }
}
