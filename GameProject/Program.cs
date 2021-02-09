using GameProject.Adapters.PaymentAdapters;
using GameProject.Adapters.VerifactionAdapters.MailBaseTypes;
using GameProject.Concrete;
using GameProject.Entities;
using GameProject.Helpers;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        //
        public static List<Customer> customers = new List<Customer>();
        public static List<Product> products = new List<Product>();
        public static List<Payment> payments = new List<Payment>();
        public static int CustomerId = 0;
        public static int ProductId = 0;
        public static int CampaignId = 0;
        public static int PaymentId = 0;
        //

        static CustomerManager customerManager = new CustomerManager(new MailServiceAdapter());
        static ProductManager productManager = new ProductManager();
        //DB gibi kullanacağım
        static void Main(string[] args)
        {
            // Senaryolar için
            AddUsers(); // Kullanıcılar ekle
            AddProducts(); // Ürünler ekle

            PaymentManager paymentManager = new PaymentManager(
                new PayfullServiceAdapter(), // Ödeme servisi
                Program.customers[0], // Satın alan oyuncu/müşteri
                productManager.GetProductsByTotalSales(0)[0], // Satın alınan ürün
                5 // Satın alınan adet
                );
            //Satın almak istediğimiz ürünün ödeme yöntemini,ürünü ve adedi iletiyoruz

            if(paymentManager.Pay()) { Console.WriteLine("Payment successfull"); }

        }

        static void AddUsers()
        {
            // Eklenen kullanıcılar

            customerManager.Add(new Customer()
            {
                Username = "bycyberchild93193193",
                Address = "abc sokak",
                DateOfBirth = new DateTime(1994, 11, 30),
                FirstName = "Berk",
                LastName = "Dedekargınoğlu",
                NationalityId = "1111111111"
            });

            customerManager.Add(new Customer()
            {
                Username = "hakan4192931",
                Address = "abc sokak",
                DateOfBirth = new DateTime(1994, 11, 30),
                FirstName = "Hakan",
                LastName = "Demir",
                NationalityId = "1111111111"
            });

            customerManager.Add(new Customer()
            {
                Username = "cengizcan59129",
                Address = "abc sokak",
                DateOfBirth = new DateTime(1994, 11, 30),
                FirstName = "Cengiz",
                LastName = "Can",
                NationalityId = "1111111111"
            });

        }

        static void AddProducts()
        {
            // Eklenen ürünler

            productManager.Add(new Product()
            {
                ProductName = "TestProduct_1",
                Details = "",
                UnitPrice = 15,
                UnitsInStock = 25
            });

            productManager.Add(new Product()
            {
                ProductName = "TestProduct_2",
                Details = "",
                UnitPrice = 15,
                UnitsInStock = 25
            });

            productManager.Add(new Product()
            {
                ProductName = "TestProduct_3",
                Details = "",
                UnitPrice = 15,
                UnitsInStock = 25
            });
        }
    }
}
