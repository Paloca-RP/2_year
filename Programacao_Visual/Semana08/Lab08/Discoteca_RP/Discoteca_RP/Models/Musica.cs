using System.Collections.Generic;

namespace Discoteca_RP.Models
{
    public class Musica
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }

        public int AnoEdicao { get; set; }

        public List<string> Executantes { get; set; }

        public Musica(int codigo, string titulo, int anoEdicao)
        {
            Codigo = codigo;
            Titulo = titulo;    
            AnoEdicao = anoEdicao;
            Executantes = new List<string>();
        }
       
        public Musica() : this (-1,"N/A", -1)
        {

        }
    }
}
