using shoppersden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden
{
   public class InheritanceDemo
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin(Faker.Name.FullName(),
                Convert.ToString(Faker.RandomNumber.Next(10000,1000000)));
            admin.Password= admin.GeneratePassword();

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
            Person person = admin; //implicit
            Console.WriteLine(person);

            //Person person1=new Person(Faker.Name.FullName(), Faker.Identification.UkNhsNumber());
            //Admin admin1 = person1 as Admin; //explicit

        }
    }
}
