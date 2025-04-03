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

            //is operator
            if (admin is Person)
            {
                Console.WriteLine("Yes Derived");
            }
            else
            {
                Console.WriteLine("No Not Derived");
            }

            //as operator
            Person person = admin;
            Console.WriteLine(person);

            Person person1=new Person(Faker.Name.FullName(), Faker.Identification.UkNhsNumber());
            Admin admin1 = person1;

        }
    }
}
