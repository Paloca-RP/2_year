using System.Collections.Generic;

namespace LAB06
{
    class Stock : Dictionary<Product, int>
    {
        public void Venda(Product product, int quantidade)
        {
            if (this[product] >= quantidade && this[product] > 0)
                this[product] -= quantidade;
        }

        override public string ToString()
        {
            string str = "";
            foreach (KeyValuePair<Product, int> i in this)
                str += i.Key.ToString() + " - " + i.Value.ToString() + "\n";
            return str;
        }
    }
}
