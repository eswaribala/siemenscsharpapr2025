using shoppersden.Models;
using shoppersden.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden
{
    class RefInOutDemo
    {
        public static void Main(string[] args)
        {

            //generate 100 customers
            CustomerRepository customerRepository = new CustomerRepository();

            for (int i = 0; i < 10; i++)
            {
                Customer customer = new Customer(Faker.RandomNumber.Next(1000, 5000),
                    Faker.Name.FullName(),
                    Faker.Internet.Email(),
                    Faker.Identification.DateOfBirth(),
                    Faker.Identification.UkPassportNumber(),
                    Faker.Address.StreetAddress(),
                    Faker.Address.City(),
                    Faker.Address.UsMilitaryState(),
                    Faker.Address.ZipCode(),
                    Faker.Phone.Number(),
                    Faker.Boolean.Random(),
                    customerRepository.getRandomGender()
                    );
                customerRepository.AddCustomer(customer);
            }

            //retrieve customers
            Customer[] customersArray=customerRepository.GetCustomers();
            //linq
            
            customersArray.ToList().ForEach(c => Console.WriteLine(c));

            Console.WriteLine("Enter UserId to search for customer phone number: ");
            long UserId= Convert.ToInt64( Console.ReadLine());
           string result= SearchData(ref customersArray, UserId);
            if(result!=null)
                Console.WriteLine("Phone Number: " + result);
            else
                Console.WriteLine("UserId not found");

            int value = 10;
            Console.WriteLine("Value before modify: " + value);
            ModifyValue(ref value);
            Console.WriteLine("Value after modify: " + value);

        }


        static string SearchData(ref Customer[] customers, long UserId)
        {
            //LINQ
           return  customers.ToList().Find(Customer => Customer.UserId == UserId).PhoneNumber;

        }

        static void ModifyValue(ref int value)
        {
           
            value= value * new Random().Next(2,1000);
           
        }

    }
}
