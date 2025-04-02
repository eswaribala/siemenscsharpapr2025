using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden.Models
{
    class Customer
    {
        //default constructor
        public Customer()
        {
        }
        //parameterized constructor

        public Customer(long userId, string name, string email, DateTime dOB, string password, string address, string city, string state, string zipCode, string phoneNumber, bool isActive)
        {
            UserId = userId;
            Name = name;
            Email = email;
            DOB = dOB;
            Password = password;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
            PhoneNumber = phoneNumber;
            IsActive = isActive;
        }

        public long UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }

    }
}
