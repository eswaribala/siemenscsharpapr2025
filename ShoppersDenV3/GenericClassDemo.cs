using ShoppersDenV3.Models;
using ShoppersDenV3.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3
{
    class GenericClassDemo
    {
        static void Main(string[] args)
        {
            IGenericRepository<Category> categoryRepository = 
                new GenericRepository<Category>();

            for (int i = 0; i < Faker.RandomNumber.Next(2, 50); i++)
            {
                var commerce = new Bogus.DataSets.Commerce();
                var date = new Bogus.DataSets.Date();

                Category category = new Category();
                category.CategoryId = Faker.RandomNumber.Next(10000, 100000);
                category.Name = commerce.Categories(1)[0];

                categoryRepository.AddData(category);

            }

            IGenericRepository<Product> genericRepository =
                new GenericRepository<Product>();

         
            for (int i = 0; i < Faker.RandomNumber.Next(2, 50); i++)
            {
                var commerce = new Bogus.DataSets.Commerce();
                var date = new Bogus.DataSets.Date();

                Product product = new Product(Faker.RandomNumber.Next(10000, 100000), commerce.Product(),
                    new Money(Faker.RandomNumber.Next(100, 10000), Faker.RandomNumber.Next(100, 10000)),
                 new Description(commerce.ProductAdjective(),
                    commerce.ProductMaterial(),
                    commerce.ProductDescription()), Faker.RandomNumber.Next(100, 10000));
                genericRepository.AddData(product);

            }

            Console.WriteLine($"No of Products{genericRepository.GetValues().Count()}");


            IGenericRepository<Message> messageRepository =
                new GenericRepository<Message>();

            for (int i = 0; i < Faker.RandomNumber.Next(2, 50); i++)
            {
                Message message = new Message();
                message.MessageId = Faker.RandomNumber.Next(1, 100);
                message.Sender = Faker.Name.FullName();
                message.Receiver = Faker.Name.FullName();
                message.Content = Faker.Lorem.Sentence();
                message.TimeStamp = DateTime.Now;

                messageRepository.AddData(message);

            }

        }
    }
}
