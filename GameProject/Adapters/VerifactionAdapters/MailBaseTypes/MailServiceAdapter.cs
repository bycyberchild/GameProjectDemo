using GameProject.Abstract;
using GameProject.Entities;
using System;

namespace GameProject.Adapters.VerifactionAdapters.MailBaseTypes
{
    class MailServiceAdapter : ICustomerCheckServices
    {
        public bool CheckIFRealPerson(Customer customer)
        {
            Console.WriteLine("Mail base checked");
            return true;
        }
    }
}
