using System;
using System.Collections.Generic;
using System.Text;

namespace TP06_Collections
{
    public class Aluno
    {
        public String Nome { get; set; }
        public String Numero { get; set; }

        override
        public String ToString()
        {
            return Numero + "\t" + Nome;
        }

        public override int GetHashCode()
        {
            return Numero.GetHashCode();
        }


        public override bool Equals(object obj)
        {
            // Is null
            if (Object.ReferenceEquals(null, obj))
            {
                return false;
            }

            // Is the same object
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }

            // Is not the same type
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Aluno a = obj as Aluno;
            return String.Equals(Numero, a.Numero);
        }
    }
}
