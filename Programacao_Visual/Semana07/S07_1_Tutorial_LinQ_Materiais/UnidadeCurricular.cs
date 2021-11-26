using System;
using System.Collections.Generic;
using System.Text;

namespace TP06_TutorialLinQ
{
    public class UnidadeCurricular
    {
        public String Codigo { get; set; }
        public Curso Curso { get; set; }
        public int Semestre { get; set; }
        public String Nome { get; set; }
        public AnoLetivo InscritoNoAno { get; set; }


        public override string ToString()
        {
            return InscritoNoAno + "   " + Codigo + "   " + Curso + "\t" + Semestre + "   " + Nome;
        }
    }
}
