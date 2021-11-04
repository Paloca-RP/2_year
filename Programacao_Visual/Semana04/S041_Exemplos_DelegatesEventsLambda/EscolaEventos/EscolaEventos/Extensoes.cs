using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaEventos
{
    public static class Extensoes
    {
        public static string AddDateToday(this string str)
        {
            return str + " - " + DateTime.Now.ToShortDateString();
        }

        public static string AddDate(this string str, DateTime date)
        {
            return str + " - " + date.ToShortDateString();
        }
    }
}
