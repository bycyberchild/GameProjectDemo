using GameProject.Helpers;
using System;
using System.Collections.Generic;

namespace GameProject.Entities
{
    class Product:EntityHelpers
    {
        public Product()
        {
            Id = Program.ProductId++.ToString();
            ProductId = "100-"+GenerateUniqueId();
            Like = 0;
            TotalSales = 0;
            ProductImages = new List<string>();
            Comments = new List<string>();
            IsCampaign = false;
        }
        public string Id { get; }
        public string ProductId { get; set; }
        public string CategoryId { get; }
        public string ProductName { get; set; }
        public string Details { get; set; }
        public List<string> ProductImages { get; set; }
        public int UnitsInStock { get; set; }
        public double UnitPrice { get; set; }
        public int Like { get; set; }
        public int TotalSales { get; set; }
        public bool IsCampaign { get; set; }
        public List<string> Comments { get; set; }
    }
}
