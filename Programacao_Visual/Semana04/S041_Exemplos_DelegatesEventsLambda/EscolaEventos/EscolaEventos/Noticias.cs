using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaEventos
{
    public class Noticias
    {
        private List<string> noticias = new List<string>();

        public void InscricoesAbriram(Disciplina disciplina)
        {
            noticias.Add("Abriram as inscrições na disciplina " + disciplina.Nome);
        }

        public void Mostrar()
        {
            Console.WriteLine("\n\n----- Noticias ----- \n");
            foreach (string noticia in noticias)
                Console.WriteLine("- " + noticia);
            Console.WriteLine();
        }
    }
}
