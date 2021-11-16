using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S051_TutorialColecoes_RP
{
    class Aluno_RP : Pessoa_RP
    {
        public string NumeroAluno { get; set; }

        public Aluno_RP(string nome, DateTime dataNascimento, CartaoDoCidadao_RP cartaoCidadao, string numeroAluno) : base(nome, dataNascimento, cartaoCidadao)
        {
            this.NumeroAluno = numeroAluno;
        }

        public override string ToString()
        {
            return base.ToString() + "\tCODAL: " + this.NumeroAluno;
        }
    }
}
