using GameProject.Helpers;
using System;

namespace GameProject.Entities
{
    class Customer:EntityHelpers
    {
        private DateTime _createdAt;

        public Customer()
        {
            _createdAt = DateTime.Now;
            Id = Program.CustomerId++.ToString();
            CustomerId = "101-" + GenerateUniqueId();
        }
        public string Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get { return _createdAt; } }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
        public string CustomerId { get; }
        public string Address { get; set; }

    }
}
