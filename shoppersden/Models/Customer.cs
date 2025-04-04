using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden.Models
{
    public enum Gender { MALE,FEMALE,TRANSGENDER}
    //customer object sort
    public class Customer
        //:IComparable<Customer>
    {
        //default constructor
        public Customer()
        {
        }

        public Customer(Product products)
        {
            Product = products;
        }

        //parameterized constructor

        public Customer(long userId, string name, string email, DateTime dOB, string password, string address, string city, string state, string zipCode, string phoneNumber, bool isActive, Gender gender)
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
            Gender = gender;
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
        public Gender Gender { get; set; }
        public Product Product{ get; set; }

        /*
        public int CompareTo(Customer other)
        {

            return this.DOB.CompareTo(other.DOB);
        }*/

        public override string ToString()
        {
            return UserId + " " + Name + " " + Email + " " + DOB + " " + Password + " " + Address + " " + City + " " + State + " " + ZipCode + " " + PhoneNumber + " " + IsActive+""+Gender;
        }
    }
}
