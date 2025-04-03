// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ShoppersDenv1.Models;

namespace ShoppersDenv1
{
    class Program
    {
        static void Main(string[] args)
        {
            var commerce = new Bogus.DataSets.Commerce();
            var date=new Bogus.DataSets.Date();

            Product product = new Product();
            product.Id = Faker.RandomNumber.Next(10000, 100000);
            product.Name = commerce.Product();
            product.Description=commerce.ProductDescription();
            product.Price = new Money(Faker.RandomNumber.Next(100, 10000),
               Faker.RandomNumber.Next(100, 10000));
            product.Quantity= Faker.RandomNumber.Next(1, 100);
            Console.WriteLine($"Product={product}");

        }
    }
}