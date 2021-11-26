using System;
using System.Collections.Generic;
using System.Text;

namespace TP06_TutorialLinQ
{
    public class Aluno
    {
        public String Codigo { get; set; }
        public String Nome { get; set; }
        public Boolean Inscrito { get; set; }
        public Contacto Contacto { get; set; }
        public Curso Curso { get; set; }
        public List<UnidadeCurricular> Cadeiras { get; set; } // UC's onde se inscreveu

        public override string ToString()
        {
            String str = Codigo + "  " +
                Nome + "  " +
                (Inscrito ? "Está Inscrito" : "Não está inscrito") + "\n" +
                Contacto + "\n";
            foreach (UnidadeCurricular u in Cadeiras)
                str += u + "\n";
            return str;

        }
    }
}
