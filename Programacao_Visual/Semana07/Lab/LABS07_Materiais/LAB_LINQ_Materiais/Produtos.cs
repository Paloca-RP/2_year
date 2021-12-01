using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB06
{
    class Produtos : List<Product>
    {
        override public string ToString()
        {
            string str = "";
            foreach (Product product in this)
                str += product.ToString() + "\n";
            return str;
        }

        public IEnumerable<Product> GetListaProdutos()
        {
            return this.Select(i => i);
        }

        public IEnumerable<Product> GetProdutosSemStock()
        {
            return this.Where(i => i.UnitsInStock == 0)
                       .Select(i => i);
        }

        public IEnumerable<string> GetListaProdutosOrdemAlfabetica()
        {
            return this.OrderBy(i => i.ProductName)
                       .Select(i => i.ProductName);
        }

        public IEnumerable<Product> GetListaBebidasMenos25Euros()
        {
            return this.Where(i => i.UnitPrice < 25 && i.Category.Equals("Beverages"))
                       .OrderBy(i => i.UnitPrice)
                       .Select(i => i);
        }
        public Product GetProdutoMaisBarato()
        {
            return (this.OrderBy(i => i.UnitPrice)
                        .Select(i => i)).First();
        }
        public Product GetProdutoMaisCaro()
        {
            return (this.OrderBy(i => i.UnitPrice)
                        .Select(i => i)).Last();
        }
        public decimal GetMediaPreco()
        {
            return (this.Select(i => i.UnitPrice))
                        .Average();
        }

        public IEnumerable<Object> GetDinheiroStockPorProduto()
        {
            return this.Select( i => new {
                                        Nome = i.ProductName, 
                                        ValorTotal = (i.UnitPrice * i.UnitsInStock) 
                                    });
        }

        public IEnumerable<Product> GetListaProdutosOrdenadaPreco()
        {
            return this.OrderBy(i => i.UnitPrice)
                       .Select(i => i);
        }

        public IEnumerable<string> GetCategoriaProdutos()
        {
            return this.Select(i => i.Category)
                       .Distinct();
        }

        public bool ProdutosMiasCarosQue200()
        {
            return this.Where(i => i.UnitPrice > 200)
                       .Select(i => i).Any();
        }

        public double GetMediaUnidadesEmStock()
        {
            return this.Select(i => i.UnitsInStock)
                       .Average();
        }
        public IEnumerable<Product> GetPrimeiros3ProdutosCustamMais50()
        {
            return this.Where(i => i.UnitPrice > 50)
                       .Select(i => i)
                       .Take(3);
        }

        public IEnumerable<Product> Get4e5ComecamPorC()
        {
            return this.Where(i => i.ProductName.StartsWith("C"))
                       .Select(i => i)
                       .Take(5)
                       .Skip(3);
        }

        public IEnumerable<Product> GetProdutosOrdenadosCategoriaENome()
        {
            return this.OrderBy(i => i.Category)
                       .ThenBy(i => i.ProductName)
                       .Select(i => i);
        }

        public IEnumerable<IGrouping<string, Product>> GetProdutosPorCategoria()
        {
            return this.GroupBy(i => i.Category)
                       .Select(i => i);
        }
    }
}
