using GameProject.Abstract;
using GameProject.Entities;
using System;

namespace GameProject.Adapters.PaymentAdapters
{
    class PaytrServiceAdapter : IPaymentServices
    {
        public bool Pay(Customer customer, Payment payment)
        {
            Console.WriteLine($"Payment completed with Paytr {customer.FirstName} bouth {payment.Product.ProductId} , paid {payment.Bill}");
            throw new NotImplementedException();
        }
    }
}
