using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB06
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public override string ToString()
        {
            return ProductId + " - " + ProductName + " - " + Category + " - " + UnitPrice + " - " + UnitsInStock;
        }
        //Nivel 7
        public override int GetHashCode()
        {
            return this.ProductId.GetHashCode();
        }

        public override bool Equals(object objecto)
        {

            if (Object.ReferenceEquals(null, objecto))
                return false;

            if (Object.ReferenceEquals(this, objecto))
                return true;

            if (objecto.GetType() != this.GetType())
                return false;

            Product a = objecto as Product;
            return String.Equals(this.ProductId, a.ProductId);
        }
    }
}
