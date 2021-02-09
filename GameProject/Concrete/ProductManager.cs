using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameProject.Concrete
{
    class ProductManager
    {
        public bool Add(Product product)
        {
            Program.products.Add(product);
            Console.WriteLine($"{product.ProductName} prdocut added db");
            return true;
        }
        public List<Product> ShowAll()
        {
            return Program.products;
        }
        public Product GetProductById(string productId)
        {
            if (Program.products.FirstOrDefault(prod => prod.ProductId == productId) != null)
                return Program.products.FirstOrDefault(prod => prod.ProductId == productId);
            else
                throw new Exception($"There is no product with this id {productId}");
        }
        public List<Product> GetProductsByCategoryId(string categoryId)
        {
            return Program.products.Where(products => products.CategoryId == categoryId).ToList();
        }
        public List<Product> GetProductsByTotalSales(int minSales)
        {
            return Program.products.Where(products => products.TotalSales <= minSales).ToList();
        }
        public List<Product> GetProductsHasCampaign()
        {
            return Program.products.Where(product => product.IsCampaign == true).ToList();
        }
    }
}
