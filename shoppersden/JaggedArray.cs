using shoppersden.Models;
using System.Net.Http.Headers;
using Bogus;
using shoppersden.Repositories;
namespace shoppersden
{
    public class JaggedArray
    {
        //jagged array no of columns are dynamic
       static Customer[][] customerJaggedArray = new Customer[3][];
        public static void Main(string[] args) {
            
            var commerce = new Bogus.DataSets.Commerce("en");
            var date = new Bogus.DataSets.Date();
           

            for(int i = 0; i < customerJaggedArray.Length; i++)
            {
                customerJaggedArray[i] = new Customer[new Random().Next(1,10)];      
              
                for (int j = 0;j < customerJaggedArray[i].Length; j++)
                {
                    Product product = new Product();
                    product.ProductId = Faker.RandomNumber.Next(1000, 5000);
                    product.Name = commerce.ProductName();
                    product.Description = commerce.ProductDescription();
                    product.DOP = date.Past();
                    product.Price = Faker.RandomNumber.Next(100, 5000);
                    product.Quantity = Faker.RandomNumber.Next(1, 100);
                    product.ImageUrl = commerce.ProductAdjective();
                    Customer customer = new Customer(product);
                    customerJaggedArray[i][j] = customer;
                }
            }
            ShowJaggedArray();

        }

        public static void ShowJaggedArray()
        {
            for(int i=0;i< customerJaggedArray.Length; i++)
            {
                Console.WriteLine($"Customer No{i}");
                Console.WriteLine($"Product Details..........{customerJaggedArray[i].Length}");
                for (int j = 0; j < customerJaggedArray[i].Length; j++)
                {
                    Console.WriteLine(customerJaggedArray[i][j].Product);
                }
            }

        }




  
    }
}