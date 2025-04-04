using ShoppersDenV3.Models;
using ShoppersDenV3.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3
{
    class GenericListDemo
    {
        static void Main(string[] args)
        {
            IProductRepository productRepository = new ProductRepository();
            for(int i = 0; i < Faker.RandomNumber.Next(2,50); i++)
            {
                var commerce = new Bogus.DataSets.Commerce();
                var date = new Bogus.DataSets.Date();

                Product product = new Product(Faker.RandomNumber.Next(10000, 100000), commerce.Product(),
                    new Money(Faker.RandomNumber.Next(100, 10000), Faker.RandomNumber.Next(100, 10000)),
                 new Description(commerce.ProductAdjective(),
                    commerce.ProductMaterial(),
                    commerce.ProductDescription()),Faker.RandomNumber.Next(100, 10000));
                productRepository.AddProduct(product);
            
            }

            Console.WriteLine($"No of Products{productRepository.GetAllProducts().Count()}");

            foreach (var product in productRepository.GetAllProducts())
            {
                Console.WriteLine($"Product={product}");
            }

        }
    }
}
