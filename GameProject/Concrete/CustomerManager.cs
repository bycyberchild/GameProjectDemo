using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CustomerManager
    {
        private ICustomerCheckServices _checkServices;
        public CustomerManager(ICustomerCheckServices checkServices)
        {
            _checkServices = checkServices;
        }
        public Customer Add(Customer customer)
        {
            if (_checkServices.CheckIFRealPerson(customer))
            {
                Program.customers.Add(customer);
                Console.WriteLine($"{customer.FirstName} customer added db");
                return customer;
            }
            throw new Exception("Validation error");
        }
    }
}
