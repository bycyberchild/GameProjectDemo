using GameProject.Helpers;
using System;

namespace GameProject.Entities
{
    class Payment : EntityHelpers
    {
        public Payment(Product product,Customer customer,double bill,int productCount)
        {
            PaymentId = "102-" + GenerateUniqueId();//Payment için 102 ile başlıyor
            Product = product;
            DateOfSale = DateTime.Now;
            Bill = bill;
            IsSuccessfull = false;
            Customer = customer;
            ProductCount = productCount;

        }
        public Customer Customer { get; set; }
        public int ProductCount { get; set; }
        public string PaymentId { get; set; }
        public Product Product { get; set; }
        public DateTime DateOfSale { get; set; }
        public bool IsSuccessfull { get; set; }
        public double Bill { get; set; }
    }
}
