using System;
using System.Collections.Generic;
using System.Text;

namespace TP06_Collections
{

    class Sala : Dictionary<Lugares, Aluno>
    {

        //public override string ToString()
        //{
        //    String str = "";
        //    foreach (KeyValuePair<Lugares, Aluno> a in this)
        //        str += a.Key.ToString() + "- " + a.Value.ToString() + "\n";
        //    return str;
        //}

        // A partir do C# 3.0 podemos usar o tipo implicito var
        public override string ToString()
        {
            String str = "";
            foreach (var a in this)
                str += a.Key.ToString() + "- " + a.Value.ToString() + "\n";
            return str;
        }
    }
}
