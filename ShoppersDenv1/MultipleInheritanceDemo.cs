using ShoppersDenv1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenv1
{
    class MultipleInheritanceDemo
    {
        static void Main(string[] args)
        {
            var commerce = new Bogus.DataSets.Commerce();
            Category category = new Category();
            category.CategoryId = Faker.RandomNumber.Next(1000, 100000);
            category.Name = commerce.Department();
            category.CreatedAt = DateTime.Now;
            category.Id = Guid.NewGuid();
            if (category.IsDeleted)
            {
                Console.WriteLine("Category is deleted");
            }
            else
            {
                Console.WriteLine($"Category Id: {category.Id}");
                category.SoftDelete();


            }
        }
    }
}
