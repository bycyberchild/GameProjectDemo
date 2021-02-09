using GameProject.Abstract;
using GameProject.Entities;
using System;

namespace GameProject.Adapters.VerifactionAdapters.Personality
{
    class MernisServiceAdapter : ICustomerCheckServices
    {
        public bool CheckIFRealPerson(Customer customer)
        {
            Console.WriteLine("Mernis checked");
            return true;
        }
    }
}
