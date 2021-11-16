using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S051_TutorialColecoes_RP
{
    class Livro_RP
    {
        public string Titulo_RP { get; set; }
        public DateTime DataPrimeiraEdicao { get; set; }
        public Autor_RP Autor_RP { get; set; }

        public Livro_RP(string titulo, DateTime data, Autor_RP autor)
        {
            this.Titulo_RP = titulo;
            this.DataPrimeiraEdicao = data;
            this.Autor_RP = autor;
        }

        public override string ToString()
        {
            return "Título: " + this.Titulo_RP + " | Data Primeira Edição: " + this.DataPrimeiraEdicao.Year + "/" + this.DataPrimeiraEdicao.Month + "/" + this.DataPrimeiraEdicao.Day + " | Autor: " + this.Autor_RP.ToString();
        }
    }
}
