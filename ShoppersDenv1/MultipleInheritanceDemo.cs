using ShoppersDenv1.Exceptions;
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
            try
            {
                category.SetName(commerce.Department());
            }
            catch (NameFormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            category.CreatedAt = DateTime.Now;
            //generates new guid
            category.Id = Guid.NewGuid();
            
            if (category.IsDeleted)
            {
                Console.WriteLine("Category is deleted");
            }
            else
            {
                Console.WriteLine($"Category Id: {category.Id}, Name:{category.GetName()}");
                category.SoftDelete();


            }
        }
    }
}
