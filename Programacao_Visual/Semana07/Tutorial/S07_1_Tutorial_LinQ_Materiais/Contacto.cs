using System;
using System.Collections.Generic;
using System.Text;

namespace TP06_TutorialLinQ
{
    public class Contacto
    {
        public String Mail { get; set; }
        public String Telefone { get; set; }



        public override string ToString()
        {
            return Telefone + "\t" + Mail;
        } 
    }
}
