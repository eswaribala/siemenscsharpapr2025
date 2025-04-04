using ShoppersDenV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV2
{
    class ExtensionDemo
    {
        static void Main(string[] args)
        {
            // Example usage of the extension method
           string input = "South Korea’s Constitutional Court removed impeached President Yoon Suk Yeol from office on Friday (April 4, 2025), four months after he threw South Korean politics into turmoil by declaring martial law and sending troops to parliament in an ill-fated effort to break through legislative gridlock.";
           input.SplitText().ToList().ForEach(W => Console.WriteLine(W));

            SeasonalOrder order = new SeasonalOrder();
            order.OrderId = Faker.RandomNumber.Next(1,10000000);
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
