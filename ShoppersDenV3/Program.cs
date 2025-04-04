// See https://aka.ms/new-console-template for more information

using ShoppersDenV2.Models;

namespace ShoppersDenV3
{
   class Program
    {
        public static void Main(string[] args)
        {
            Order order = new Order();
            order.OrderId = Faker.RandomNumber.Next(1, 10000000);
            order.OrderAmount = Faker.RandomNumber.Next(100, 10000000);
            order.OrderDate = new Bogus.DataSets.Date().Past();
            if (order.IsValidOrder())
            {
                Console.WriteLine("Valid Order");
            }
            else
            {
                Console.WriteLine("Invalid Order");
            }

        }
    }
}
