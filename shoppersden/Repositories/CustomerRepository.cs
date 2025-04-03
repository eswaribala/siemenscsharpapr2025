using shoppersden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden.Repositories
{
    class CustomerRepository
    {
        //declaring array
        private Customer[] customers;
        private static int i = 0;

        public CustomerRepository()
        {
            //define array size
            customers = new Customer[10];
        }

        

        public void AddCustomer(Customer customer)
        {
            //initalizing array
            customers[i] = customer;
            i++;
        }

        public Customer[] GetCustomers()
        {
            return customers;
        }

        public Gender getRandomGender()
        {
          var genderValues=  Enum.GetValues(typeof(Gender));
           return (Gender)genderValues.GetValue(new Random().Next((genderValues.Length)));

        }

    }
}
