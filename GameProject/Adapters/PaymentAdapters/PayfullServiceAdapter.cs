using GameProject.Abstract;
using GameProject.Entities;
using System;

namespace GameProject.Adapters.PaymentAdapters
{
    class PayfullServiceAdapter : IPaymentServices
    {
        public bool Pay(Customer customer, Payment payment)
        {
            Console.WriteLine($"Payment completed with Payfull {customer.FirstName} bouth {payment.Product.ProductId} , paid {payment.Bill}");
            return true;
        }
    }
}
