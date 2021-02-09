using GameProject.Entities;

namespace GameProject.Abstract
{
    interface IPaymentServices
    {
        bool Pay(Customer customer,Payment payment);
    }
}
