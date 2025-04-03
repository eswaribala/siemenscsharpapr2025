using shoppersden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden
{
    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin(Faker.Name.FullName(),
                Faker.Identification.UkNhsNumber(),
                Convert.ToString(Faker.RandomNumber.Next(10000,1000000)));  

            Console.WriteLine(admin);
        }
    }
}
