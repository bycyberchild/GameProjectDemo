using GameProject.Abstract;
using GameProject.Entities;
using System;

namespace GameProject.Concrete
{
    class PaymentManager
    {
        private Payment _currentPayment;
        private Customer _customer;
        private Product _product;
        private IPaymentServices _paymentServices;
        private double _price;
        public PaymentManager(IPaymentServices paymentServices,Customer customer,Product product,int count=1)
        {
            _paymentServices = paymentServices;
            _customer = customer;
            _product = product;
            _price = CalculateBill(_product, count);
            _currentPayment = new Payment(_product, _customer, _price,count);//İlgili ürün için bir payment oluşturuyoruz
        }

        private double CalculateBill(Product product,int count)
        {
            return product.UnitPrice * count;
        }

        private void ShowPayment(Payment payment)
        {
            Console.WriteLine($"Payment Id : {payment.PaymentId}" +
                $"\n Product Name : {payment.Product.ProductName}" +
                $"\n Product Id : {payment.Product.ProductId}" +
                $"\n Count : {payment.ProductCount}" +
                $"\n Customer Name : {payment.Customer.FirstName}" +
                $"\n Customer Id : {payment.Customer.CustomerId}" +
                $"\n Bill : {payment.Bill}");
        }
        public bool Pay()
        {
            ShowPayment(_currentPayment);
            _paymentServices.Pay(_customer,_currentPayment);
            return true;
        }
    }
}

